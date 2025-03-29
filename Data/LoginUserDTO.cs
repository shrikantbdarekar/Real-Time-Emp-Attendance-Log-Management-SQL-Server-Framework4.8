using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEmployeeAttendance25.Data
{
    public class LoginUserDTO
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; } // Store hashed password, not plaintext!
        public int Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
