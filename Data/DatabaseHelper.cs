using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEmployeeAttendance25.Data
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;
        public string ConnectionString { get { return _connectionString; } } 

        public DatabaseHelper()
        {
            _connectionString = Properties.Settings.Default.ConnectionString;
        }

        // Execute a command (INSERT, UPDATE, DELETE) - Returns rows affected
        public int ExecuteNonQuery(string storedProcedure, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedure, con))
                {
                    cmd.CommandType = CommandType.Text;
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Execute a command that returns a single value (COUNT, SUM, etc.)
        public object ExecuteScalar(string storedProcedure, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedure, con))
                {
                    cmd.CommandType = CommandType.Text;
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        // Retrieve data as DataTable (for SELECT queries)
        public DataTable ExecuteQuery(string storedProcedure, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedure, con))
                {
                    cmd.CommandType = CommandType.Text;
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
