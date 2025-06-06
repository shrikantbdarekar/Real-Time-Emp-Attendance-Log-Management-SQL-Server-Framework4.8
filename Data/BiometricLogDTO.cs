﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEmployeeAttendance25.Data
{
    public class BiometricLogDTO
    {
        public long LogId { get; set; }
        public int BMEmployeeId { get; set; }
        public DateTime PunchTime { get; set; }
        public int DeviceId { get; set; }
        public int PunchTypeFlag { get; set; }
        public int VerificationMode { get; set; }
        public int StatusCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public string RecordType { get; set; }
        public string BatchCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InOut { get; set; }
        public string ManualEntryRemark { get; set; }
    }

    public class BiometricLogDTOWithEmployee
    {
        public long LogId { get; set; }
        public int BMEmployeeId { get; set; }
        public DateTime PunchTime { get; set; }
        public int DeviceId { get; set; }
        public int PunchTypeFlag { get; set; }
        public int VerificationMode { get; set; }
        public int StatusCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public string RecordType { get; set; }
        public string BatchCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InOut { get; set; }
        public string ManualEntryRemark { get; set; }

        public long EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
    }


    public class BiometricLogDTOEmployeeMonthHour
    {
        public long EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public int BMEmployeeId { get; set; }
        public DateTime PunchDate { get; set; }
        public TimeSpan? InTime { get; set; }
        public TimeSpan? OutTime { get; set; }
        public string InTime12Hr { get; set; }
        public string OutTime12Hr { get; set; }
        public string DayHours { get; set; }
        public string ActualDayHours { get; set; }        
        public decimal HourSalary { get; set; }
        public decimal DaySalary { get; set; }
    }

    public class EmployeeMonthSalaryDTO
    {
        public long EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public int BMEmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal MonthSalary { get; set; }
    }

}
