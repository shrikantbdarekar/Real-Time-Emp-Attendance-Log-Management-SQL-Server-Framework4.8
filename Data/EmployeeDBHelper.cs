using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;

namespace CSEmployeeAttendance25.Data
{
    public class EmployeeDBHelper
    {
        private DatabaseHelper _dbHelper;

        public EmployeeDBHelper()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Get All Employees
        public List<EmployeeDTO> GetEmployees()
        {
            string query = "SELECT * FROM Employees";

            DataTable dt = _dbHelper.ExecuteQuery(query, null);
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(new EmployeeDTO
                {
                    EmployeeId = Convert.ToInt64(row["EmployeeId"]),
                    EmployeeCode = row["EmployeeCode"].ToString(),
                    BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                    JoiningDate = Convert.ToDateTime(row["JoiningDate"]),
                    BirthDate = Convert.ToDateTime(row["BirthDate"]),
                    EmployeeName = row["EmployeeName"].ToString(),
                    Address = row["Address"].ToString(),
                    EmailId = row["EmailId"].ToString(),
                    ContactNumber1 = row["ContactNumber1"].ToString(),
                    ContactNumber2 = row["ContactNumber2"].ToString(),
                    Department = row["Department"].ToString(),
                    Designation = row["Designation"].ToString(),
                    MonthlySalary = Convert.ToDecimal(row["MonthlySalary"]),
                    HourlySalary = Convert.ToDecimal(row["HourlySalary"]),
                    ShiftStart = (TimeSpan)row["ShiftStart"],
                    ShiftEnd = (TimeSpan)row["ShiftEnd"],
                    IsActive = Convert.ToBoolean(row["IsActive"]),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"])
                });
            }
            return employees;
        }

        public List<EmployeeDTO> GetEmployees(DateTime startDate,DateTime endDate)
        {
            string query = @"select * from Employees where BMEmployeeId in 
                (select distinct bmemployeeid from BiometricLogs B where
                B.PunchTime>=@StartDate AND B.PunchTime<=@EndDate)";

            DataTable dt = _dbHelper.ExecuteQuery(query, null);
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(new EmployeeDTO
                {
                    EmployeeId = Convert.ToInt64(row["EmployeeId"]),
                    EmployeeCode = row["EmployeeCode"].ToString(),
                    BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                    JoiningDate = Convert.ToDateTime(row["JoiningDate"]),
                    BirthDate = Convert.ToDateTime(row["BirthDate"]),
                    EmployeeName = row["EmployeeName"].ToString(),
                    Address = row["Address"].ToString(),
                    EmailId = row["EmailId"].ToString(),
                    ContactNumber1 = row["ContactNumber1"].ToString(),
                    ContactNumber2 = row["ContactNumber2"].ToString(),
                    Department = row["Department"].ToString(),
                    Designation = row["Designation"].ToString(),
                    MonthlySalary = Convert.ToDecimal(row["MonthlySalary"]),
                    HourlySalary = Convert.ToDecimal(row["HourlySalary"]),
                    ShiftStart = (TimeSpan)row["ShiftStart"],
                    ShiftEnd = (TimeSpan)row["ShiftEnd"],
                    IsActive = Convert.ToBoolean(row["IsActive"]),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"])
                });
            }
            return employees;
        }

        // Get All Employees
        public List<EmployeeDTO> GetEmployeesDropdown()
        {
            string query = "SELECT * FROM Employees Order By BMEmployeeId;";
            DataTable dt = _dbHelper.ExecuteQuery(query, null);
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(new EmployeeDTO
                {
                    EmployeeId = Convert.ToInt64(row["EmployeeId"]),
                    EmployeeCode = row["EmployeeCode"].ToString(),
                    BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                    EmployeeName = Convert.ToInt32(row["BMEmployeeId"]) + " | " + row["EmployeeCode"].ToString() + " " + row["EmployeeName"].ToString() ,
                });
            }
            return employees;
        }

        // Get All Employees
        public List<EmployeeDTO> GetEmployeesDropdown(DateTime startDate,DateTime endDate)
        {
            string query = @"select * from Employees where BMEmployeeId in 
                (select distinct bmemployeeid from BiometricLogs B where
                B.PunchTime>=@StartDate AND B.PunchTime<=@EndDate)
                Order By BMEmployeeId";


            SqlParameter[] parameters =
            {
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate),
            };

            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(new EmployeeDTO
                {
                    EmployeeId = Convert.ToInt64(row["EmployeeId"]),
                    EmployeeCode = row["EmployeeCode"].ToString(),
                    BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                    EmployeeName = Convert.ToInt32(row["BMEmployeeId"]) + " | " + row["EmployeeCode"].ToString() + " " + row["EmployeeName"].ToString(),
                });
            }
            return employees;
        }


        // Get Employee by ID
        public EmployeeDTO GetEmployeeById(long employeeId)
        {
            string query = "SELECT * FROM Employees WHERE EmployeeId = @EmployeeId";
            SqlParameter[] parameters = { new SqlParameter("@EmployeeId", employeeId) };
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0)
                return null; // No employee found

            DataRow row = dt.Rows[0];
            return new EmployeeDTO
            {
                EmployeeId = Convert.ToInt64(row["EmployeeId"]),
                EmployeeCode = row["EmployeeCode"].ToString(),
                BMEmployeeId = Convert.ToInt32(row["BMEmployeeId"]),
                JoiningDate = Convert.ToDateTime(row["JoiningDate"]),
                BirthDate = Convert.ToDateTime(row["BirthDate"]),
                EmployeeName = row["EmployeeName"].ToString(),
                Address = row["Address"].ToString(),
                EmailId = row["EmailId"].ToString(),
                ContactNumber1 = row["ContactNumber1"].ToString(),
                ContactNumber2 = row["ContactNumber2"].ToString(),
                Department = row["Department"].ToString(),
                Designation = row["Designation"].ToString(),
                MonthlySalary = Convert.ToDecimal(row["MonthlySalary"]),
                HourlySalary = Convert.ToDecimal(row["HourlySalary"]),
                ShiftStart = (TimeSpan)row["ShiftStart"],
                ShiftEnd = (TimeSpan)row["ShiftEnd"],
                IsActive = Convert.ToBoolean(row["IsActive"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"])
            };
        }


        // Add Employee
        public bool AddEmployee(EmployeeDTO emp)
        {
            string query = @"INSERT INTO Employees (EmployeeCode, BMEmployeeId, JoiningDate, BirthDate, EmployeeName, 
                     Address, EmailId, ContactNumber1, ContactNumber2, Department, Designation, MonthlySalary, 
                     HourlySalary, ShiftStart, ShiftEnd, IsActive, CreatedAt) 
                     VALUES (@EmployeeCode, @BMEmployeeId, @JoiningDate, @BirthDate, @EmployeeName, @Address, 
                     @EmailId, @ContactNumber1, @ContactNumber2, @Department, @Designation, @MonthlySalary, 
                     @HourlySalary, @ShiftStart, @ShiftEnd, @IsActive, GETDATE())";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@EmployeeCode", emp.EmployeeCode),
                new SqlParameter("@BMEmployeeId", emp.BMEmployeeId),
                new SqlParameter("@JoiningDate", emp.JoiningDate),
                new SqlParameter("@BirthDate", emp.BirthDate),
                new SqlParameter("@EmployeeName", emp.EmployeeName),
                new SqlParameter("@Address", emp.Address),
                new SqlParameter("@EmailId", emp.EmailId),
                new SqlParameter("@ContactNumber1", emp.ContactNumber1),
                new SqlParameter("@ContactNumber2", emp.ContactNumber2),
                new SqlParameter("@Department", emp.Department),
                new SqlParameter("@Designation", emp.Designation),
                new SqlParameter("@MonthlySalary", emp.MonthlySalary),
                new SqlParameter("@HourlySalary", emp.HourlySalary),
                new SqlParameter("@ShiftStart", emp.ShiftStart),
                new SqlParameter("@ShiftEnd", emp.ShiftEnd),
                new SqlParameter("@IsActive", emp.IsActive)
            };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        // Update Employee
        public bool UpdateEmployee(EmployeeDTO emp)
        {
            string query = @"UPDATE Employees SET EmployeeCode = @EmployeeCode, BMEmployeeId = @BMEmployeeId, 
                     JoiningDate = @JoiningDate, BirthDate = @BirthDate, EmployeeName = @EmployeeName, 
                     Address = @Address, EmailId = @EmailId, ContactNumber1 = @ContactNumber1, 
                     ContactNumber2 = @ContactNumber2, Department = @Department, Designation = @Designation, 
                     MonthlySalary = @MonthlySalary, HourlySalary = @HourlySalary, ShiftStart = @ShiftStart, 
                     ShiftEnd = @ShiftEnd, IsActive = @IsActive WHERE EmployeeId = @EmployeeId";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@EmployeeId", emp.EmployeeId),
                new SqlParameter("@EmployeeCode", emp.EmployeeCode),
                new SqlParameter("@BMEmployeeId", emp.BMEmployeeId),
                new SqlParameter("@JoiningDate", emp.JoiningDate),
                new SqlParameter("@BirthDate", emp.BirthDate),
                new SqlParameter("@EmployeeName", emp.EmployeeName),
                new SqlParameter("@Address", emp.Address),
                new SqlParameter("@EmailId", emp.EmailId),
                new SqlParameter("@ContactNumber1", emp.ContactNumber1),
                new SqlParameter("@ContactNumber2", emp.ContactNumber2),
                new SqlParameter("@Department", emp.Department),
                new SqlParameter("@Designation", emp.Designation),
                new SqlParameter("@MonthlySalary", emp.MonthlySalary),
                new SqlParameter("@HourlySalary", emp.HourlySalary),
                new SqlParameter("@ShiftStart", emp.ShiftStart),
                new SqlParameter("@ShiftEnd", emp.ShiftEnd),
                new SqlParameter("@IsActive", emp.IsActive)
            };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        // Delete Employee
        public bool DeleteEmployee(long employeeId)
        {
            string query = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";
            SqlParameter[] parameters = { new SqlParameter("@EmployeeId", employeeId) };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
