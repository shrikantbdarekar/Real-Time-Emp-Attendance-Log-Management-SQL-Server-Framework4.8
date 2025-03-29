using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEmployeeAttendance25.Data
{
    public class BiometricMachineDBHelper
    {
        private DatabaseHelper _dbHelper;

        public BiometricMachineDBHelper()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Get All Machines
        public List<BiometricMachineDTO> GetBiometricMachines()
        {
            string query = "SELECT * FROM BiometricMachines";
            DataTable dt = _dbHelper.ExecuteQuery(query, null);
            List<BiometricMachineDTO> machines = new List<BiometricMachineDTO>();

            foreach (DataRow row in dt.Rows)
            {
                machines.Add(new BiometricMachineDTO
                {
                    MachineId = Convert.ToInt64(row["MachineId"]),
                    BMMachineId = Convert.ToInt32(row["BMMachineId"]),
                    MachineName = row["MachineName"].ToString(),
                    MachineDescription = row["MachineDescription"].ToString(),
                    IsActive = Convert.ToBoolean(row["IsActive"]),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"])
                });
            }
            return machines;
        }

        // Get Machine by ID
        public BiometricMachineDTO GetBiometricMachineById(long machineId)
        {
            string query = "SELECT * FROM BiometricMachines WHERE MachineId = @MachineId";
            SqlParameter[] parameters = { new SqlParameter("@MachineId", machineId) };
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            return new BiometricMachineDTO
            {
                MachineId = Convert.ToInt64(row["MachineId"]),
                BMMachineId = Convert.ToInt32(row["BMMachineId"]),
                MachineName = row["MachineName"].ToString(),
                MachineDescription = row["MachineDescription"].ToString(),
                IsActive = Convert.ToBoolean(row["IsActive"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"])
            };
        }

        // Add Machine
        public bool AddBiometricMachine(BiometricMachineDTO machine)
        {
            string query = @"INSERT INTO BiometricMachines (BMMachineId, MachineName, MachineDescription, IsActive, CreatedAt) 
                        VALUES (@BMMachineId, @MachineName, @MachineDescription, @IsActive, GETDATE())";

            SqlParameter[] parameters =
            {
            new SqlParameter("@BMMachineId", machine.BMMachineId),
            new SqlParameter("@MachineName", machine.MachineName),
            new SqlParameter("@MachineDescription", machine.MachineDescription),
            new SqlParameter("@IsActive", machine.IsActive)
        };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Update Machine
        public bool UpdateBiometricMachine(BiometricMachineDTO machine)
        {
            string query = @"UPDATE BiometricMachines SET BMMachineId = @BMMachineId, MachineName = @MachineName, 
                        MachineDescription = @MachineDescription, IsActive = @IsActive 
                        WHERE MachineId = @MachineId";

            SqlParameter[] parameters =
            {
            new SqlParameter("@MachineId", machine.MachineId),
            new SqlParameter("@BMMachineId", machine.BMMachineId),
            new SqlParameter("@MachineName", machine.MachineName),
            new SqlParameter("@MachineDescription", machine.MachineDescription),
            new SqlParameter("@IsActive", machine.IsActive)
        };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete Machine
        public bool DeleteBiometricMachine(long machineId)
        {
            string query = "DELETE FROM BiometricMachines WHERE MachineId = @MachineId";
            SqlParameter[] parameters = { new SqlParameter("@MachineId", machineId) };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }

}
