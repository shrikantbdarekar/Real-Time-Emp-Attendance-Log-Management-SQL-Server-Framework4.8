using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEmployeeAttendance25.Data
{
    public static class DataTableHelper
    {
        public static DataTable ConvertToDataTable(List<BiometricLogDTOEmployeeMonthHour> list)
        {
            DataTable table = new DataTable("BiometricLogs");

            // Define DataTable columns based on BiometricLogDTOEmployeeMonthHour properties
            table.Columns.Add("EmployeeId", typeof(long));
            table.Columns.Add("EmployeeCode", typeof(string));
            table.Columns.Add("EmployeeName", typeof(string));
            table.Columns.Add("BMEmployeeId", typeof(int));
            table.Columns.Add("PunchDate", typeof(DateTime));
            table.Columns.Add("InTime", typeof(TimeSpan));
            table.Columns.Add("OutTime", typeof(TimeSpan));
            table.Columns.Add("InTime12Hr", typeof(string));
            table.Columns.Add("OutTime12Hr", typeof(string));
            table.Columns.Add("DayHours", typeof(string));
            table.Columns.Add("HourSalary", typeof(decimal));
            table.Columns.Add("DaySalary", typeof(decimal));
            table.Columns.Add("ActualDayHours", typeof(string));

            // Add rows from list to DataTable
            foreach (var item in list)
            {
                DataRow row = table.NewRow();
                row["EmployeeId"] = item.EmployeeId;
                row["EmployeeCode"] = item.EmployeeCode;
                row["EmployeeName"] = item.EmployeeName;
                row["BMEmployeeId"] = item.BMEmployeeId;
                row["PunchDate"] = item.PunchDate;
                row["InTime"] = item.InTime ?? (object)DBNull.Value; // Handle nullable TimeSpan
                row["OutTime"] = item.OutTime ?? (object)DBNull.Value; // Handle nullable TimeSpan
                row["InTime12Hr"] = item.InTime12Hr ?? (object)DBNull.Value;
                row["OutTime12Hr"] = item.OutTime12Hr ?? (object)DBNull.Value;
                row["DayHours"] = item.DayHours ?? (object)DBNull.Value;
                row["HourSalary"] = item.HourSalary;
                row["DaySalary"] = item.DaySalary;
                row["ActualDayHours"] = item.ActualDayHours ?? (object)DBNull.Value;

                table.Rows.Add(row);
            }

            return table;
        }
    }
}
