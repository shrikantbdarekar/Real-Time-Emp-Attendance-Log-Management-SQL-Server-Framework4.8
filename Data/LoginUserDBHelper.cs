using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEmployeeAttendance25.Data
{
    public class LoginUsersDBHelper
    {
        private DatabaseHelper _dbHelper;

        public LoginUsersDBHelper()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Get All Users
        public List<LoginUserDTO> GetUsers()
        {
            string query = "SELECT * FROM LoginUsers";
            DataTable dt = _dbHelper.ExecuteQuery(query, null);
            List<LoginUserDTO> users = new List<LoginUserDTO>();

            foreach (DataRow row in dt.Rows)
            {
                users.Add(new LoginUserDTO
                {
                    UserId = Convert.ToInt64(row["UserId"]),
                    UserName = row["UserName"].ToString(),
                    PasswordHash = row["PasswordHash"].ToString(),
                    Role = Convert.ToInt32(row["Role"]),
                    IsActive = Convert.ToBoolean(row["IsActive"]),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"])
                });
            }
            return users;
        }

        // Get User by ID
        public LoginUserDTO GetUserById(long userId)
        {
            string query = "SELECT * FROM LoginUsers WHERE UserId = @UserId";
            SqlParameter[] parameters = { new SqlParameter("@UserId", userId) };
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            return new LoginUserDTO
            {
                UserId = Convert.ToInt64(row["UserId"]),
                UserName = row["UserName"].ToString(),
                PasswordHash = row["PasswordHash"].ToString(),
                Role = Convert.ToInt32(row["Role"]),
                IsActive = Convert.ToBoolean(row["IsActive"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"])
            };
        }

        // Add User
        public bool AddUser(LoginUserDTO user)
        {
            string query = "INSERT INTO LoginUsers (UserName, PasswordHash, Role, IsActive, CreatedAt) " +
                           "VALUES (@UserName, @PasswordHash, @Role, @IsActive, GETDATE())";

            SqlParameter[] parameters =
            {
            new SqlParameter("@UserName", user.UserName),
            new SqlParameter("@PasswordHash", user.PasswordHash),
            new SqlParameter("@Role", user.Role),
            new SqlParameter("@IsActive", user.IsActive)
        };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Update User
        public bool UpdateUser(LoginUserDTO user)
        {
            string query = "UPDATE LoginUsers SET UserName = @UserName, PasswordHash = @PasswordHash, " +
                           "Role = @Role, IsActive = @IsActive WHERE UserId = @UserId";

            SqlParameter[] parameters =
            {
            new SqlParameter("@UserId", user.UserId),
            new SqlParameter("@UserName", user.UserName),
            new SqlParameter("@PasswordHash", user.PasswordHash),
            new SqlParameter("@Role", user.Role),
            new SqlParameter("@IsActive", user.IsActive)
        };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete User
        public bool DeleteUser(long userId)
        {
            string query = "DELETE FROM LoginUsers WHERE UserId = @UserId";
            SqlParameter[] parameters = { new SqlParameter("@UserId", userId) };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }

}
