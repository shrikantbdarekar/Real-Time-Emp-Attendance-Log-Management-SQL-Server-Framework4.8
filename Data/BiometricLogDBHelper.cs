using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace CSEmployeeAttendance25.Data
{
    public class BiometricLogDBHelper
    {
        private DatabaseHelper _dbHelper;

        public BiometricLogDBHelper()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Get All Biometric Logs
        public List<BiometricLogDTO> GetBiometricLogs(string batchCode)
        {
            string query = "SELECT * FROM BiometricLogs Where BatchCode=@BatchCode;";
            SqlParameter[] parameters = { new SqlParameter("@BatchCode", batchCode) };
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
            List<BiometricLogDTO> logs = new List<BiometricLogDTO>();

            foreach (DataRow row in dt.Rows)
            {
                logs.Add(new BiometricLogDTO
                {
                    LogId = Convert.ToInt64(row["LogId"]),
                    BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                    PunchTime = Convert.ToDateTime(row["PunchTime"]),
                    DeviceId = Convert.ToInt32(row["DeviceId"]),
                    PunchTypeFlag = Convert.ToInt32(row["PunchTypeFlag"]),
                    VerificationMode = Convert.ToInt32(row["VerificationMode"]),
                    StatusCode = Convert.ToInt32(row["StatusCode"]),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                    RecordType = row["RecordType"].ToString(),
                    BatchCode = row["BatchCode"].ToString(),
                    StartDate = Convert.ToDateTime(row["StartDate"]),
                    EndDate = Convert.ToDateTime(row["EndDate"]),
                    InOut = row["InOut"].ToString(),
                    ManualEntryRemark = row["ManualEntryRemark"].ToString()
                });
            }
            return logs;
        }

        public List<BiometricLogDTOWithEmployee> GetBiometricLogsWithEmployee(string batchCode)
        {
            string query = @"SELECT E.EmployeeId,E.EmployeeCode,E.EmployeeName,B.* FROM BiometricLogs B
                           JOIN Employees E ON B.BMEmployeeId = E.EmployeeId AND B.BatchCode=@BatchCode;";
            SqlParameter[] parameters = { new SqlParameter("@BatchCode", batchCode) };
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
            List<BiometricLogDTOWithEmployee> logs = new List<BiometricLogDTOWithEmployee>();

            foreach (DataRow row in dt.Rows)
            {
                logs.Add(new BiometricLogDTOWithEmployee
                {
                    LogId = Convert.ToInt64(row["LogId"]),
                    BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                    PunchTime = Convert.ToDateTime(row["PunchTime"]),
                    DeviceId = Convert.ToInt32(row["DeviceId"]),
                    PunchTypeFlag = Convert.ToInt32(row["PunchTypeFlag"]),
                    VerificationMode = Convert.ToInt32(row["VerificationMode"]),
                    StatusCode = Convert.ToInt32(row["StatusCode"]),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                    RecordType = row["RecordType"].ToString(),
                    BatchCode = row["BatchCode"].ToString(),
                    StartDate = Convert.ToDateTime(row["StartDate"]),
                    EndDate = Convert.ToDateTime(row["EndDate"]),
                    InOut = row["InOut"].ToString(),
                    ManualEntryRemark = row["ManualEntryRemark"].ToString(),

                    EmployeeId = Convert.ToInt64(row["EmployeeId"]),
                    EmployeeCode = row["EmployeeCode"].ToString(),
                    EmployeeName = row["EmployeeName"].ToString()
                });
            }
            return logs;
        }

        public List<BiometricLogDTOWithEmployee> GetBiometricLogsForEmployeeMonthLog(DateTime startDate,DateTime endDate)
        {
            string query = @"SELECT E.EmployeeId, E.EmployeeCode, E.EmployeeName, E.HourlySalary, B.*  
                 FROM BiometricLogs B JOIN Employees E ON B.BMEmployeeId = E.BMEmployeeId 
                 WHERE B.PunchTime>=@StartDate AND B.PunchTime<=@EndDate
                 ORDER BY B.PunchTime, B.BMEmployeeId;";

            SqlParameter[] parameters = { 
                new SqlParameter("@StartDate", startDate) ,
                new SqlParameter("@EndDate", endDate),
                //new SqlParameter("@EmployeeId", employeeId)
            };
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
            List<BiometricLogDTOWithEmployee> logs = new List<BiometricLogDTOWithEmployee>();

            foreach (DataRow row in dt.Rows)
            {
                logs.Add(new BiometricLogDTOWithEmployee
                {
                    LogId = Convert.ToInt64(row["LogId"]),
                    BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                    PunchTime = Convert.ToDateTime(row["PunchTime"]),
                    DeviceId = Convert.ToInt32(row["DeviceId"]),
                    PunchTypeFlag = Convert.ToInt32(row["PunchTypeFlag"]),
                    VerificationMode = Convert.ToInt32(row["VerificationMode"]),
                    StatusCode = Convert.ToInt32(row["StatusCode"]),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                    RecordType = row["RecordType"].ToString(),
                    BatchCode = row["BatchCode"].ToString(),
                    StartDate = Convert.ToDateTime(row["StartDate"]),
                    EndDate = Convert.ToDateTime(row["EndDate"]),
                    InOut = row["InOut"].ToString(),
                    ManualEntryRemark = row["ManualEntryRemark"].ToString(),

                    EmployeeId = Convert.ToInt64(row["EmployeeId"]),
                    EmployeeCode = row["EmployeeCode"].ToString(),
                    EmployeeName = row["EmployeeName"].ToString()
                });
            }
            return logs;
        }

        public List<BiometricLogDTOEmployeeMonthHour> GetBiometricLogsForEmployeeMonthHour(DateTime startDate, DateTime endDate)
        {
            string query = @"SELECT 
                E.EmployeeId,
                E.EmployeeCode,
                E.EmployeeName,
                E.HourlySalary,
                B.BMEmployeeId,
                CONVERT(DATE, B.PunchTime) AS PunchDate,

                -- InTime in 24-hour format
                MAX(CASE WHEN B.InOut = 'IN' THEN CAST(B.PunchTime AS TIME) END) AS InTime,
                -- InTime in 12-hour format
                FORMAT(MAX(CASE WHEN B.InOut = 'IN' THEN B.PunchTime END), 'hh:mm tt') AS InTime12Hr,

                -- OutTime in 24-hour format
                MAX(CASE WHEN B.InOut = 'OUT' THEN CAST(B.PunchTime AS TIME) END) AS OutTime,
                -- OutTime in 12-hour format
                FORMAT(MAX(CASE WHEN B.InOut = 'OUT' THEN B.PunchTime END), 'hh:mm tt') AS OutTime12Hr,

                -- Calculate DayHours (HH:MM format)
                FORMAT(DATEDIFF(MINUTE, 
                    MAX(CASE WHEN B.InOut = 'IN' THEN CAST(B.PunchTime AS TIME) END), 
                    MAX(CASE WHEN B.InOut = 'OUT' THEN CAST(B.PunchTime AS TIME) END)
                ) / 60, '00') + ':' +
                FORMAT(DATEDIFF(MINUTE, 
                    MAX(CASE WHEN B.InOut = 'IN' THEN CAST(B.PunchTime AS TIME) END), 
                    MAX(CASE WHEN B.InOut = 'OUT' THEN CAST(B.PunchTime AS TIME) END)
                ) % 60, '00') AS DayHours,

                -- ActualDayHours calculation
                FORMAT(
                    CASE 
                        WHEN DATEDIFF(MINUTE, 
                            MAX(CASE WHEN B.InOut = 'IN' THEN CAST(B.PunchTime AS TIME) END), 
                            MAX(CASE WHEN B.InOut = 'OUT' THEN CAST(B.PunchTime AS TIME) END)
                        ) > 390 AND 
                             DATEDIFF(MINUTE, 
                            MAX(CASE WHEN B.InOut = 'IN' THEN CAST(B.PunchTime AS TIME) END), 
                            MAX(CASE WHEN B.InOut = 'OUT' THEN CAST(B.PunchTime AS TIME) END)
                        ) < 520
                        THEN DATEDIFF(MINUTE, 
                            MAX(CASE WHEN B.InOut = 'IN' THEN CAST(B.PunchTime AS TIME) END), 
                            MAX(CASE WHEN B.InOut = 'OUT' THEN CAST(B.PunchTime AS TIME) END)
                        ) - 30
                        ELSE DATEDIFF(MINUTE, 
                            MAX(CASE WHEN B.InOut = 'IN' THEN CAST(B.PunchTime AS TIME) END), 
                            MAX(CASE WHEN B.InOut = 'OUT' THEN CAST(B.PunchTime AS TIME) END)
                        )
                    END / 60, '00'
                ) + ':' +
                FORMAT(
                    CASE 
                        WHEN DATEDIFF(MINUTE, 
                            MAX(CASE WHEN B.InOut = 'IN' THEN CAST(B.PunchTime AS TIME) END), 
                            MAX(CASE WHEN B.InOut = 'OUT' THEN CAST(B.PunchTime AS TIME) END)
                        ) > 390 AND 
                             DATEDIFF(MINUTE, 
                            MAX(CASE WHEN B.InOut = 'IN' THEN CAST(B.PunchTime AS TIME) END), 
                            MAX(CASE WHEN B.InOut = 'OUT' THEN CAST(B.PunchTime AS TIME) END)
                        ) < 520
                        THEN DATEDIFF(MINUTE, 
                            MAX(CASE WHEN B.InOut = 'IN' THEN CAST(B.PunchTime AS TIME) END), 
                            MAX(CASE WHEN B.InOut = 'OUT' THEN CAST(B.PunchTime AS TIME) END)
                        ) - 30
                        ELSE DATEDIFF(MINUTE, 
                            MAX(CASE WHEN B.InOut = 'IN' THEN CAST(B.PunchTime AS TIME) END), 
                            MAX(CASE WHEN B.InOut = 'OUT' THEN CAST(B.PunchTime AS TIME) END)
                        )
                    END % 60, '00'
                ) AS ActualDayHours,

               -- Calculate DaySalary with exactly 2 decimal places
                CAST(ROUND(
                    CAST(DATEDIFF(MINUTE, 
                        MAX(CASE WHEN B.InOut = 'IN' THEN CAST(B.PunchTime AS TIME) END), 
                        MAX(CASE WHEN B.InOut = 'OUT' THEN CAST(B.PunchTime AS TIME) END)
                    ) AS DECIMAL(10,2)) / 60 * E.HourlySalary, 
                    2
                ) AS DECIMAL(10,2)) AS DaySalary

            FROM BiometricLogs B
            JOIN Employees E ON B.BMEmployeeId = E.BMEmployeeId
            WHERE B.InOut <> '' 
            AND B.PunchTime >= @StartDate 
            AND B.PunchTime <= @EndDate
            GROUP BY E.EmployeeId, E.EmployeeCode, E.EmployeeName, E.HourlySalary, B.BMEmployeeId, CONVERT(DATE, B.PunchTime);";

            SqlParameter[] parameters = {
                new SqlParameter("@StartDate", startDate) ,
                new SqlParameter("@EndDate", endDate),
                //new SqlParameter("@EmployeeId", employeeId)
            };
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
            List<BiometricLogDTOEmployeeMonthHour> logs = new List<BiometricLogDTOEmployeeMonthHour>();

            foreach (DataRow row in dt.Rows)
            {
                logs.Add(new BiometricLogDTOEmployeeMonthHour
                {
                    EmployeeId = Convert.ToInt64(row["EmployeeId"]),
                    EmployeeCode = row["EmployeeCode"] as string ?? "",
                    EmployeeName = row["EmployeeName"] as string ?? "",
                    BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                    PunchDate = Convert.ToDateTime(row["PunchDate"]),
                    // Convert time to TimeSpan safely (handles NULL values)
                    InTime = TimeSpan.TryParse(row["InTime"]?.ToString(), out TimeSpan inTimeValue) ? inTimeValue : (TimeSpan?)null,
                    OutTime = TimeSpan.TryParse(row["OutTime"]?.ToString(), out TimeSpan outTimeValue) ? outTimeValue : (TimeSpan?)null,
                    // Convert 12-hour format time safely
                    InTime12Hr = row["InTime12Hr"] as string ?? "",
                    OutTime12Hr = row["OutTime12Hr"] as string ?? "",

                    DayHours = row["DayHours"] as string ?? "",
                    ActualDayHours = row["ActualDayHours"] as string ?? "",
                    HourSalary = Convert.ToDecimal(row["HourlySalary"].ToString()),
                    DaySalary = Convert.ToDecimal(row["DaySalary"].ToString())
                });
            }
            return logs;
        }

        public List<BiometricLogDTOWithEmployee> GetBiometricLogsWithEmployeeOneEntry(string batchCode)
        {
            string query = @"WITH PunchCounts AS (
                SELECT B.BMEmployeeId,CAST(B.PunchTime AS DATE) AS PunchDate,
                COUNT(*) AS EntryCount FROM BiometricLogs B
                GROUP BY B.BMEmployeeId, CAST(B.PunchTime AS DATE)
                HAVING COUNT(*) < 2)
                SELECT E.EmployeeId,E.EmployeeCode,E.EmployeeName,B.* 
                FROM BiometricLogs B
                JOIN Employees E ON B.BMEmployeeId = E.EmployeeId
                JOIN PunchCounts PC ON B.BMEmployeeId = PC.BMEmployeeId 
                AND CAST(B.PunchTime AS DATE) = PC.PunchDate
                WHERE B.BatchCode = @BatchCode
                ORDER BY PunchDate, B.BMEmployeeId;";

            SqlParameter[] parameters = { new SqlParameter("@BatchCode", batchCode) };
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
            List<BiometricLogDTOWithEmployee> logs = new List<BiometricLogDTOWithEmployee>();

            foreach (DataRow row in dt.Rows)
            {
                logs.Add(new BiometricLogDTOWithEmployee
                {
                    LogId = Convert.ToInt64(row["LogId"]),
                    BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                    PunchTime = Convert.ToDateTime(row["PunchTime"]),
                    DeviceId = Convert.ToInt32(row["DeviceId"]),
                    PunchTypeFlag = Convert.ToInt32(row["PunchTypeFlag"]),
                    VerificationMode = Convert.ToInt32(row["VerificationMode"]),
                    StatusCode = Convert.ToInt32(row["StatusCode"]),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                    RecordType = row["RecordType"].ToString(),
                    BatchCode = row["BatchCode"].ToString(),
                    StartDate = Convert.ToDateTime(row["StartDate"]),
                    EndDate = Convert.ToDateTime(row["EndDate"]),
                    InOut = row["InOut"].ToString(),
                    ManualEntryRemark = row["ManualEntryRemark"].ToString(),

                    EmployeeId = Convert.ToInt64(row["EmployeeId"]),
                    EmployeeCode = row["EmployeeCode"].ToString(),
                    EmployeeName = row["EmployeeName"].ToString()
                });
            }
            return logs;
        }

        public List<BiometricLogDTOWithEmployee> GetBiometricLogsWithEmployeeTwoPlusEntry(string batchCode)
        {
            string query = @"WITH PunchCounts AS (
                SELECT B.BMEmployeeId,CAST(B.PunchTime AS DATE) AS PunchDate,
                COUNT(*) AS EntryCount FROM BiometricLogs B
                GROUP BY B.BMEmployeeId, CAST(B.PunchTime AS DATE)
                HAVING COUNT(*) > 2)
                SELECT E.EmployeeId,E.EmployeeCode,E.EmployeeName,B.* 
                FROM BiometricLogs B
                JOIN Employees E ON B.BMEmployeeId = E.EmployeeId
                JOIN PunchCounts PC ON B.BMEmployeeId = PC.BMEmployeeId 
                AND CAST(B.PunchTime AS DATE) = PC.PunchDate
                WHERE B.BatchCode = @BatchCode
                ORDER BY PunchDate, B.BMEmployeeId;";

            SqlParameter[] parameters = { new SqlParameter("@BatchCode", batchCode) };
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
            List<BiometricLogDTOWithEmployee> logs = new List<BiometricLogDTOWithEmployee>();

            foreach (DataRow row in dt.Rows)
            {
                logs.Add(new BiometricLogDTOWithEmployee
                {
                    LogId = Convert.ToInt64(row["LogId"]),
                    BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                    PunchTime = Convert.ToDateTime(row["PunchTime"]),
                    DeviceId = Convert.ToInt32(row["DeviceId"]),
                    PunchTypeFlag = Convert.ToInt32(row["PunchTypeFlag"]),
                    VerificationMode = Convert.ToInt32(row["VerificationMode"]),
                    StatusCode = Convert.ToInt32(row["StatusCode"]),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                    RecordType = row["RecordType"].ToString(),
                    BatchCode = row["BatchCode"].ToString(),
                    StartDate = Convert.ToDateTime(row["StartDate"]),
                    EndDate = Convert.ToDateTime(row["EndDate"]),
                    InOut = row["InOut"].ToString(),
                    ManualEntryRemark = row["ManualEntryRemark"].ToString(),

                    EmployeeId = Convert.ToInt64(row["EmployeeId"]),
                    EmployeeCode = row["EmployeeCode"].ToString(),
                    EmployeeName = row["EmployeeName"].ToString()
                });
            }
            return logs;
        }

        public List<BiometricLogDTOWithEmployee> GetBiometricLogsWithEmployeeDuplicateEntry(string batchCode)
        {
            string query = @"SELECT 
                    E.EmployeeId,E.EmployeeCode,E.EmployeeName,BL1.*
                FROM BiometricLogs BL1
                JOIN BiometricLogs BL2 
                    ON BL1.BMEmployeeId = BL2.BMEmployeeId 
                    AND BL1.LogId <> BL2.LogId
                    AND ABS(DATEDIFF(MINUTE, BL1.PunchTime, BL2.PunchTime)) <= 15
                    AND BL1.InOut != ''
                JOIN Employees E 
                    ON BL1.BMEmployeeId = E.BMEmployeeId
                ORDER BY BL1.PunchTime,BL1.BMEmployeeId;
                WHERE B.BatchCode = @BatchCode
                ORDER BY PunchDate, B.BMEmployeeId;";

            SqlParameter[] parameters = { new SqlParameter("@BatchCode", batchCode) };
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
            List<BiometricLogDTOWithEmployee> logs = new List<BiometricLogDTOWithEmployee>();

            foreach (DataRow row in dt.Rows)
            {
                logs.Add(new BiometricLogDTOWithEmployee
                {
                    LogId = Convert.ToInt64(row["LogId"]),
                    BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                    PunchTime = Convert.ToDateTime(row["PunchTime"]),
                    DeviceId = Convert.ToInt32(row["DeviceId"]),
                    PunchTypeFlag = Convert.ToInt32(row["PunchTypeFlag"]),
                    VerificationMode = Convert.ToInt32(row["VerificationMode"]),
                    StatusCode = Convert.ToInt32(row["StatusCode"]),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                    RecordType = row["RecordType"].ToString(),
                    BatchCode = row["BatchCode"].ToString(),
                    StartDate = Convert.ToDateTime(row["StartDate"]),
                    EndDate = Convert.ToDateTime(row["EndDate"]),
                    InOut = row["InOut"].ToString(),
                    ManualEntryRemark = row["ManualEntryRemark"].ToString(),

                    EmployeeId = Convert.ToInt64(row["EmployeeId"]),
                    EmployeeCode = row["EmployeeCode"].ToString(),
                    EmployeeName = row["EmployeeName"].ToString()
                });
            }
            return logs;
        }

        // Get Biometric Log by ID
        public BiometricLogDTO GetBiometricLogById(long logId)
        {
            string query = "SELECT * FROM BiometricLogs WHERE LogId = @LogId";
            SqlParameter[] parameters = { new SqlParameter("@LogId", logId) };
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            return new BiometricLogDTO
            {
                LogId = Convert.ToInt64(row["LogId"]),
                BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                PunchTime = Convert.ToDateTime(row["PunchTime"]),
                DeviceId = Convert.ToInt32(row["DeviceId"]),
                PunchTypeFlag = Convert.ToInt32(row["PunchTypeFlag"]),
                VerificationMode = Convert.ToInt32(row["VerificationMode"]),
                StatusCode = Convert.ToInt32(row["StatusCode"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                RecordType = row["RecordType"].ToString(),
                BatchCode = row["BatchCode"].ToString(),
                StartDate = Convert.ToDateTime(row["StartDate"]),
                EndDate = Convert.ToDateTime(row["EndDate"]),
                InOut = row["InOut"].ToString(),
                ManualEntryRemark = row["ManualEntryRemark"].ToString()
            };
        }

        // Add Biometric Log
        public bool AddBiometricLog(BiometricLogDTO log)
        {
            string query = @"INSERT INTO BiometricLogs (BMEmployeeId, PunchTime, DeviceId, PunchTypeFlag, 
                         VerificationMode, StatusCode, CreatedAt, RecordType, BatchCode, StartDate, EndDate, InOut, ManualEntryRemark) 
                         VALUES (@BMEmployeeId, @PunchTime, @DeviceId, @PunchTypeFlag, @VerificationMode, 
                         @StatusCode, GETDATE(), @RecordType, @BatchCode, @StartDate, @EndDate, @InOut, @ManualEntryRemark)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@BMEmployeeId", log.BMEmployeeId),
                new SqlParameter("@PunchTime", log.PunchTime),
                new SqlParameter("@DeviceId", log.DeviceId),
                new SqlParameter("@PunchTypeFlag", log.PunchTypeFlag),
                new SqlParameter("@VerificationMode", log.VerificationMode),
                new SqlParameter("@StatusCode", log.StatusCode),
                new SqlParameter("@RecordType", log.RecordType),
                new SqlParameter("@BatchCode", log.BatchCode),
                new SqlParameter("@StartDate", log.StartDate),
                new SqlParameter("@EndDate", log.EndDate),
                new SqlParameter("@InOut", log.InOut),
                new SqlParameter("@ManualEntryRemark", log.ManualEntryRemark)
            };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete Biometric Log
        public bool DeleteBiometricLog(long logId)
        {
            string query = "DELETE FROM BiometricLogs WHERE LogId = @LogId";
            SqlParameter[] parameters = { new SqlParameter("@LogId", logId) };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete Biometric Log
        public bool DeleteBatchHistory(string batchCode)
        {
            string query = "DELETE FROM BiometricLogs WHERE BatchCode = @BatchCode";
            SqlParameter[] parameters = { new SqlParameter("@BatchCode", batchCode) };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete Biometric Log
        public bool DeleteBiometricLogDuplicateEntry(string batchCode)
        {
            string query = @"WITH DuplicateLogs AS (
                SELECT 
                    BL1.LogId, 
                    BL1.BMEmployeeId, 
                    BL1.PunchTime, 
                    BL1.InOut,
                    ROW_NUMBER() OVER (
                        PARTITION BY BL1.BMEmployeeId, CONVERT(DATE, BL1.PunchTime) -- Partition by Employee & Date
                        ORDER BY 
                            CASE 
                                WHEN FORMAT(BL1.PunchTime, 'tt') = 'AM' THEN 1 -- AM first
                                ELSE 2 -- PM last
                            END,
                            BL1.PunchTime ASC  -- Earliest AM first, latest PM last
                    ) AS RowNum
                FROM BiometricLogs BL1
                JOIN BiometricLogs BL2
                    ON BL1.BMEmployeeId = BL2.BMEmployeeId
                    AND BL1.LogId <> BL2.LogId
                    AND ABS(DATEDIFF(MINUTE, BL1.PunchTime, BL2.PunchTime)) <= 15
                WHERE BL1.BatchCode = @BatchCode  -- Apply batch filtering
            )
            DELETE FROM BiometricLogs 
            WHERE LogId IN (SELECT LogId FROM DuplicateLogs WHERE RowNum > 1);";

            SqlParameter[] parameters = { new SqlParameter("@BatchCode", batchCode) };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        // Get distinct BatchCodes where InOut flag process is pending
        public DataTable GetDistinctBatchCodesWithInOut()
        {
            string query = @"SELECT DISTINCT BatchCode, StartDate,
                CONCAT(BatchCode, ' #', FORMAT(StartDate, 'dd-MM-yyyy'), ' #', FORMAT(EndDate, 'dd-MM-yyyy')) AS BatchName 
                FROM BiometricLogs 
                Where InOut!=''
                ORDER BY StartDate DESC";
            return _dbHelper.ExecuteQuery(query, null);
        }

        // Get distinct BatchCodes where InOut flag process is complete
        public DataTable GetDistinctBatchCodesWithoutInOut()
        {
            string query = @"SELECT DISTINCT BatchCode, StartDate,
                CONCAT(BatchCode, ' #', FORMAT(StartDate, 'dd-MM-yyyy'), ' #', FORMAT(EndDate, 'dd-MM-yyyy')) AS BatchName 
                FROM BiometricLogs 
                Where InOut=''
                ORDER BY StartDate DESC";
            return _dbHelper.ExecuteQuery(query, null);
        }

        // Get distinct BatchCodes both InOut flag process is pending and complete
        public DataTable GetDistinctBatchCodesAll()
        {
            string query = @"SELECT DISTINCT BatchCode, StartDate,
                CONCAT(BatchCode, ' #', FORMAT(StartDate, 'dd-MM-yyyy'), ' #', FORMAT(EndDate, 'dd-MM-yyyy')) AS BatchName,
                -- New column: Status based on InOut field
                CASE 
                    WHEN InOut = '' THEN 'InOut-PENDING'
                    ELSE 'InOut-PROCESSED'
                END AS Status
            FROM BiometricLogs
            ORDER BY StartDate DESC;";
            return _dbHelper.ExecuteQuery(query, null);
        }

        // Import CSV file and insert data into BiometricLogs table
        public string ImportCSVToDatabaseSimple(string filePath, DateTime startDate, DateTime endDate)
        {
            string batchCode = "BCODE-" + DateTime.Now.ToString("yyyyMMddhhmmss").ToString();

            List<BiometricLogDTO> logs = new List<BiometricLogDTO>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    //bool isFirstLine = true;

                    while ((line = sr.ReadLine()) != null)
                    {
                        //if (isFirstLine) // Skip header row
                        //{
                        //    isFirstLine = false;
                        //    continue;
                        //}

                        //string[] values = line.Split(',');
                        string[] values = line.Split('\t');

                        if (values.Length < 6) // Ensure all required fields are present
                            continue;

                        // Import data for selected month duratuin only.
                        DateTime punchDateTime = Convert.ToDateTime(values[1]);

                        if (punchDateTime >= startDate && punchDateTime <= endDate)
                        {
                            BiometricLogDTO log = new BiometricLogDTO
                            {
                                BMEmployeeId = Convert.ToInt32(values[0]),
                                PunchTime = punchDateTime,
                                DeviceId = Convert.ToInt32(values[2]),
                                PunchTypeFlag = Convert.ToInt32(values[3]),
                                VerificationMode = Convert.ToInt32(values[4]),
                                StatusCode = Convert.ToInt32(values[5]),
                                CreatedAt = DateTime.Now, //Convert.ToDateTime(values[6]),
                                RecordType = "AUTO", //values[7],
                                BatchCode = batchCode, //values[8],
                                StartDate = startDate, //Convert.ToDateTime(values[9]),
                                EndDate = endDate, //Convert.ToDateTime(values[10]),
                                InOut = string.Empty, //values[11],
                                ManualEntryRemark = string.Empty //values[12]
                            };

                            logs.Add(log);
                        }
                    }
                }

                // Insert logs into the database
                //return InsertBiometricLogOneByOneDTO(logs);

                BulkInsertBiometricLogs(logs);
                return batchCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error importing CSV: " + ex.Message);
                return string.Empty;
            }
        }

        // Insert multiple biometric log records
        private bool InsertBiometricLogOneByOneDTO(List<BiometricLogDTO> logs)
        {
            foreach (var log in logs)
            {
                AddBiometricLog(log);

                //string query = @"INSERT INTO BiometricLogs 
                //(BMEmployeeId, PunchTime, DeviceId, PunchTypeFlag, VerificationMode, StatusCode, CreatedAt, 
                // RecordType, BatchCode, StartDate, EndDate, InOut, ManualEntryRemark) 
                //VALUES (@BMEmployeeId, @PunchTime, @DeviceId, @PunchTypeFlag, @VerificationMode, @StatusCode, @CreatedAt, 
                // @RecordType, @BatchCode, @StartDate, @EndDate, @InOut, @ManualEntryRemark)";

                //SqlParameter[] parameters =
                //{
                //    new SqlParameter("@BMEmployeeId", log.BMEmployeeId),
                //    new SqlParameter("@PunchTime", log.PunchTime),
                //    new SqlParameter("@DeviceId", log.DeviceId),
                //    new SqlParameter("@PunchTypeFlag", log.PunchTypeFlag),
                //    new SqlParameter("@VerificationMode", log.VerificationMode),
                //    new SqlParameter("@StatusCode", log.StatusCode),
                //    new SqlParameter("@CreatedAt", log.CreatedAt),
                //    new SqlParameter("@RecordType", log.RecordType),
                //    new SqlParameter("@BatchCode", log.BatchCode),
                //    new SqlParameter("@StartDate", log.StartDate),
                //    new SqlParameter("@EndDate", log.EndDate),
                //    new SqlParameter("@InOut", log.InOut),
                //    new SqlParameter("@ManualEntryRemark", log.ManualEntryRemark)
                //};

                //_dbHelper.ExecuteNonQuery(query, parameters);
            }

            return true;
        }

        public bool InsertBiometricLogsOneBatch(List<BiometricLogDTO> logs)
        {
            if (logs == null || logs.Count == 0)
                return false;

            List<string> valuesList = new List<string>();

            foreach (var log in logs)
            {
                string values = $"({log.BMEmployeeId}, '{log.PunchTime:yyyy-MM-dd HH:mm:ss}', {log.DeviceId}, {log.PunchTypeFlag}, " +
                                $"{log.VerificationMode}, {log.StatusCode}, '{log.CreatedAt:yyyy-MM-dd HH:mm:ss}', " +
                                $"'{log.RecordType}', '{log.BatchCode}', '{log.StartDate:yyyy-MM-dd}', '{log.EndDate:yyyy-MM-dd}', " +
                                $"'{log.InOut}', '{log.ManualEntryRemark}')";
                valuesList.Add(values);
            }

            string query = "INSERT INTO BiometricLogs (BMEmployeeId, PunchTime, DeviceId, PunchTypeFlag, VerificationMode, " +
                           "StatusCode, CreatedAt, RecordType, BatchCode, StartDate, EndDate, InOut, ManualEntryRemark) VALUES " +
                           string.Join(", ", valuesList);

            return _dbHelper.ExecuteNonQuery(query, null) > 0;
        }

        private bool InsertBiometricLogBulkCopy(DataTable biometricData)
        {
            using (SqlConnection conn = new SqlConnection(_dbHelper.ConnectionString))
            {
                conn.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                {
                    bulkCopy.DestinationTableName = "BiometricLogs";

                    // Map columns if needed
                    bulkCopy.ColumnMappings.Add("BMEmployeeId", "BMEmployeeId");
                    bulkCopy.ColumnMappings.Add("PunchTime", "PunchTime");
                    bulkCopy.ColumnMappings.Add("DeviceId", "DeviceId");
                    bulkCopy.ColumnMappings.Add("PunchTypeFlag", "PunchTypeFlag");
                    bulkCopy.ColumnMappings.Add("VerificationMode", "VerificationMode");
                    bulkCopy.ColumnMappings.Add("StatusCode", "StatusCode");
                    bulkCopy.ColumnMappings.Add("CreatedAt", "CreatedAt");
                    bulkCopy.ColumnMappings.Add("RecordType", "RecordType");
                    bulkCopy.ColumnMappings.Add("BatchCode", "BatchCode");
                    bulkCopy.ColumnMappings.Add("StartDate", "StartDate");
                    bulkCopy.ColumnMappings.Add("EndDate", "EndDate");
                    bulkCopy.ColumnMappings.Add("InOut", "InOut");
                    bulkCopy.ColumnMappings.Add("ManualEntryRemark", "ManualEntryRemark");

                    bulkCopy.WriteToServer(biometricData);
                }
            }
            return true;
        }

        public void InsertBiometricLogsSQLMerge(List<BiometricLogDTO> logs)
        {
            using (SqlConnection conn = new SqlConnection(_dbHelper.ConnectionString))
            {
                conn.Open();

                // Create a temporary table
                string createTempTableQuery = @"
                    IF OBJECT_ID('tempdb..#TempBiometricLog') IS NOT NULL
                        DROP TABLE #TempBiometricLog;
                    CREATE TABLE #TempBiometricLog (
                        EmployeeId BIGINT,
                        PunchTime DATETIME
                    );";

                using (SqlCommand cmd = new SqlCommand(createTempTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Convert List to DataTable
                DataTable biometricDataTable = ConvertToDataTable(logs);

                // Bulk insert into the temporary table
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                {
                    bulkCopy.DestinationTableName = "#TempBiometricLog";
                    bulkCopy.WriteToServer(biometricDataTable);
                }

                // Use SQL MERGE to insert only new records (Comparing only Date part of PunchTime)
                string mergeQuery = @"
                    MERGE INTO BiometricLog AS target
                    USING #TempBiometricLog AS source
                    ON target.EmployeeId = source.EmployeeId 
                    AND CAST(target.PunchTime AS DATE) = CAST(source.PunchTime AS DATE)
                    WHEN NOT MATCHED THEN 
                    INSERT (EmployeeId, PunchTime, PunchType, MachineId)
                    VALUES (source.EmployeeId, source.PunchTime, source.PunchType, source.MachineId);";

                using (SqlCommand mergeCmd = new SqlCommand(mergeQuery, conn))
                {
                    mergeCmd.ExecuteNonQuery();
                }

                // Drop temporary table
                string dropTempTableQuery = "DROP TABLE #TempBiometricLog;";
                using (SqlCommand dropCmd = new SqlCommand(dropTempTableQuery, conn))
                {
                    dropCmd.ExecuteNonQuery();
                }
            }
        }

        public void BulkInsertBiometricLogs(List<BiometricLogDTO> logs)
        {
            DataTable dtLogs = ConvertToDataTable(logs);  // Convert List to DataTable

            using (SqlConnection conn = new SqlConnection(_dbHelper.ConnectionString))
            {
                conn.Open();

                // Create Temporary Table
                string createTempTableQuery = @"
                    CREATE TABLE #TempBiometricLog (
                    BMEmployeeId INT NOT NULL,
                    PunchTime DATETIME NOT NULL,
                    DeviceId INT NOT NULL,
                    PunchTypeFlag INT NOT NULL,
                    VerificationMode INT NOT NULL,
                    StatusCode INT NOT NULL,
                    CreatedAt DATETIME NOT NULL,
                    RecordType NVARCHAR(50) NOT NULL,
                    BatchCode NVARCHAR(50) NOT NULL,
                    StartDate DATETIME NOT NULL,
                    EndDate DATETIME NOT NULL,
                    InOut NVARCHAR(10) NOT NULL,
                    ManualEntryRemark NVARCHAR(255) NULL
                );";

                using (SqlCommand cmd = new SqlCommand(createTempTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                {
                    bulkCopy.DestinationTableName = "BiometricLogs";  // Target table

                    // Map all columns except LogId (Auto-generated)
                    bulkCopy.ColumnMappings.Add("BMEmployeeId", "BMEmployeeId");
                    bulkCopy.ColumnMappings.Add("PunchTime", "PunchTime");
                    bulkCopy.ColumnMappings.Add("DeviceId", "DeviceId");
                    bulkCopy.ColumnMappings.Add("PunchTypeFlag", "PunchTypeFlag");
                    bulkCopy.ColumnMappings.Add("VerificationMode", "VerificationMode");
                    bulkCopy.ColumnMappings.Add("StatusCode", "StatusCode");
                    bulkCopy.ColumnMappings.Add("CreatedAt", "CreatedAt");
                    bulkCopy.ColumnMappings.Add("RecordType", "RecordType");
                    bulkCopy.ColumnMappings.Add("BatchCode", "BatchCode");
                    bulkCopy.ColumnMappings.Add("StartDate", "StartDate");
                    bulkCopy.ColumnMappings.Add("EndDate", "EndDate");
                    bulkCopy.ColumnMappings.Add("InOut", "InOut");
                    bulkCopy.ColumnMappings.Add("ManualEntryRemark", "ManualEntryRemark");

                    // Insert into a temp table first
                    bulkCopy.DestinationTableName = "#TempBiometricLog";
                    bulkCopy.WriteToServer(dtLogs);

                    // Merge to avoid duplicates
                    string mergeQuery = @"
                        MERGE INTO BiometricLogs AS Target
                        USING (SELECT BMEmployeeId, CAST(PunchTime AS DATE) AS PunchDate, PunchTime, DeviceId, PunchTypeFlag, VerificationMode, StatusCode, CreatedAt, RecordType, BatchCode, StartDate, EndDate, InOut, ManualEntryRemark 
                               FROM #TempBiometricLog) AS Source
                        ON Target.BMEmployeeId = Source.BMEmployeeId AND CAST(Target.PunchTime AS DATE) = Source.PunchDate
                        WHEN NOT MATCHED THEN 
                            INSERT (BMEmployeeId, PunchTime, DeviceId, PunchTypeFlag, VerificationMode, StatusCode, CreatedAt, RecordType, BatchCode, StartDate, EndDate, InOut, ManualEntryRemark)
                            VALUES (Source.BMEmployeeId, Source.PunchTime, Source.DeviceId, Source.PunchTypeFlag, Source.VerificationMode, Source.StatusCode, Source.CreatedAt, Source.RecordType, Source.BatchCode, Source.StartDate, Source.EndDate, Source.InOut, Source.ManualEntryRemark);";

                    using (SqlCommand cmd = new SqlCommand(mergeQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private DataTable ConvertToDataTable(List<BiometricLogDTO> logs)
        {
            DataTable dt = new DataTable();

            // Define columns from BiometricLogDTO
            dt.Columns.Add("LogId", typeof(long));  // Primary Key, can be auto-generated
            dt.Columns.Add("BMEmployeeId", typeof(int));
            dt.Columns.Add("PunchTime", typeof(DateTime));
            dt.Columns.Add("DeviceId", typeof(int));
            dt.Columns.Add("PunchTypeFlag", typeof(int));
            dt.Columns.Add("VerificationMode", typeof(int));
            dt.Columns.Add("StatusCode", typeof(int));
            dt.Columns.Add("CreatedAt", typeof(DateTime));
            dt.Columns.Add("RecordType", typeof(string));
            dt.Columns.Add("BatchCode", typeof(string));
            dt.Columns.Add("StartDate", typeof(DateTime));
            dt.Columns.Add("EndDate", typeof(DateTime));
            dt.Columns.Add("InOut", typeof(string));
            dt.Columns.Add("ManualEntryRemark", typeof(string));

            // Add rows from List<BiometricLogDTO>
            foreach (var log in logs)
            {
                dt.Rows.Add(log.LogId, log.BMEmployeeId, log.PunchTime, log.DeviceId, log.PunchTypeFlag, log.VerificationMode,
                    log.StatusCode, log.CreatedAt, log.RecordType, log.BatchCode, log.StartDate, log.EndDate, log.InOut, log.ManualEntryRemark);
            }

            return dt;
        }

        public bool ApplyInOut(string batchCode)
        {
            // Create Temporary Table
            string createTempTableQuery = @"WITH OrderedLogs AS(
                    SELECT B.LogId,B.BMEmployeeId,B.PunchTime,B.BatchCode,B.PunchTypeFlag,B.InOut,
                    ROW_NUMBER() OVER(PARTITION BY B.BMEmployeeId, CAST(B.PunchTime AS DATE) ORDER BY B.PunchTime) AS RowNum
                    FROM BiometricLogs B
                    WHERE B.BatchCode = @BatchCode
                )
                UPDATE BiometricLogs
                SET InOut = CASE WHEN OL.RowNum % 2 = 1 THEN 'IN' ELSE 'OUT' END,
                    PunchTypeFlag = CASE WHEN OL.RowNum % 2 = 1 THEN 1 ELSE 0 END
                FROM BiometricLogs BL
                JOIN OrderedLogs OL ON BL.LogId = OL.LogId;";

            SqlParameter[] parameters = { new SqlParameter("@BatchCode", batchCode) };
            return _dbHelper.ExecuteNonQuery(createTempTableQuery, parameters) > 0;
        }
    }
}


