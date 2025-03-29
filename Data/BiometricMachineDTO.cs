using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEmployeeAttendance25.Data
{
    // DTO for BiometricMachines
    public class BiometricMachineDTO
    {
        public long MachineId { get; set; }
        public int BMMachineId { get; set; }
        public string MachineName { get; set; }
        public string MachineDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
