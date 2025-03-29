using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEmployeeAttendance25.Data
{
    public class EmployeeDTO
    {
        public long EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public int BMEmployeeId { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string ContactNumber1 { get; set; }
        public string ContactNumber2 { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal HourlySalary { get; set; }
        public TimeSpan ShiftStart { get; set; }
        public TimeSpan ShiftEnd { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
