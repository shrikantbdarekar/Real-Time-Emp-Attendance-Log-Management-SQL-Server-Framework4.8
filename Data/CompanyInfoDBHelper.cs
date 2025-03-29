using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSEmployeeAttendance25.Data;

namespace CSEmployeeAttendance25.Data
{
    public class CompanyInfoDBHelper
    {
        private DatabaseHelper _dbHelper;

        public CompanyInfoDBHelper()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Get the single CompanyInfo record
        public CompanyInfoDTO GetCompanyInfo()
        {
            string query = "SELECT TOP 1 * FROM CompanyInfo";
            DataTable dt = _dbHelper.ExecuteQuery(query, null);

            if (dt.Rows.Count == 0)
                return null; // No record found

            DataRow row = dt.Rows[0];
            return new CompanyInfoDTO
            {
                CompanyId = Convert.ToInt32(row["CompanyId"]),
                CompanyName = row["CompanyName"].ToString(),
                CompanyAddress = row["CompanyAddress"].ToString(),
                EmailId = row["EmailId"].ToString(),
                ContactNo = row["ContactNo"].ToString(),
                Website = row["Website"].ToString(),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                ShiftStart = (TimeSpan)row["ShiftStart"],
                ShiftEnd = (TimeSpan)row["ShiftEnd"]
            };
        }

        // Save or Update CompanyInfo
        public bool SaveCompanyInfo(CompanyInfoDTO company)
        {
            // Check if record exists
            CompanyInfoDTO existingCompany = GetCompanyInfo();
            if (existingCompany == null)
            {
                // INSERT if no record exists
                string insertQuery = @"INSERT INTO CompanyInfo (CompanyName, CompanyAddress, EmailId, ContactNo, Website, CreatedAt, ShiftStart, ShiftEnd) 
                                   VALUES (@CompanyName, @CompanyAddress, @EmailId, @ContactNo, @Website, GETDATE(), @ShiftStart, @ShiftEnd)";
                SqlParameter[] parameters =
                {
                new SqlParameter("@CompanyName", company.CompanyName),
                new SqlParameter("@CompanyAddress", company.CompanyAddress),
                new SqlParameter("@EmailId", company.EmailId),
                new SqlParameter("@ContactNo", company.ContactNo),
                new SqlParameter("@Website", company.Website),
                new SqlParameter("@ShiftStart", company.ShiftStart),
                new SqlParameter("@ShiftEnd", company.ShiftEnd)
            };

                return _dbHelper.ExecuteNonQuery(insertQuery, parameters) > 0;
            }
            else
            {
                // UPDATE if record exists
                string updateQuery = @"UPDATE CompanyInfo 
                                   SET CompanyName = @CompanyName, CompanyAddress = @CompanyAddress, EmailId = @EmailId, 
                                       ContactNo = @ContactNo, Website = @Website, ShiftStart = @ShiftStart, ShiftEnd = @ShiftEnd 
                                   WHERE CompanyId = @CompanyId";
                SqlParameter[] parameters =
                {
                new SqlParameter("@CompanyId", existingCompany.CompanyId),
                new SqlParameter("@CompanyName", company.CompanyName),
                new SqlParameter("@CompanyAddress", company.CompanyAddress),
                new SqlParameter("@EmailId", company.EmailId),
                new SqlParameter("@ContactNo", company.ContactNo),
                new SqlParameter("@Website", company.Website),
                new SqlParameter("@ShiftStart", company.ShiftStart),
                new SqlParameter("@ShiftEnd", company.ShiftEnd)
            };

                return _dbHelper.ExecuteNonQuery(updateQuery, parameters) > 0;
            }
        }
    }

}
