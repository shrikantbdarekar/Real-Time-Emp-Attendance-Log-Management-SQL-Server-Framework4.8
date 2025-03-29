using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEmployeeAttendance25.Data
{
    public enum enumMyUserRoles
    {
        SuperAdmin = 1,
        Admin = 2,
        User = 3
    }


    public class dictUserRoles
    {
        public static Dictionary<int, string> myUserRoles
        {
            get
            {
                return new Dictionary<int, string>
                {
                    { 1, "SystemAdmin" },
                    { 2, "Admin" },
                    { 3, "User" }
                };
            }
        }
    }
}
