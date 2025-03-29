using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<BiometricLogDTO> GetBiometricLogs()
        {
            string query = "SELECT * FROM BiometricLogs";
            DataTable dt = _dbHelper.ExecuteQuery(query, null);
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
    }

}
