using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEmployeeAttendance25.Data
{
    public class CompanyInfoDTO
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string Website { get; set; }
        public DateTime CreatedAt { get; set; }
        public TimeSpan ShiftStart { get; set; }
        public TimeSpan ShiftEnd { get; set; }

        // Expected in minutes
        public int PunchTimeSpan { get; set; }

        public bool ApplyTimeAdjustment { get; set; }
        public decimal FromHour { get; set; }
        public decimal ToHour { get; set; }
        public decimal DeductMinutes { get; set; }
    }

}
