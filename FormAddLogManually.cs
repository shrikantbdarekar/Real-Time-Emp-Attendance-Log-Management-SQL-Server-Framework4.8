using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSEmployeeAttendance25.Data;

namespace CSEmployeeAttendance25
{
    public partial class FormAddLogManually : Form
    {
        BiometricLogDBHelper _biometricLogHelper;
        private readonly EmployeeDTO employee;
        private readonly BiometricLogDTO existingBiometricLog;
        public FormAddLogManually(EmployeeDTO employee, BiometricLogDTO existingBiometricLog)
        {
            InitializeComponent();

            _biometricLogHelper = new BiometricLogDBHelper();
            this.employee = employee;
            this.existingBiometricLog = existingBiometricLog;

            // Read existing data 
            if (employee != null)
            {
                textBoxEmployeeName.Text = employee.EmployeeName;
                textBoxBMEmployeeId.Text = employee.BMEmployeeId.ToString();
                textBoxEmployeeCode.Text = employee.EmployeeCode;
            }

            if (existingBiometricLog != null)
            {
                textBoxPunchDate.Text = existingBiometricLog.PunchTime.ToString("dd/MM/yyyy hh:mm tt");
                labelPunchDateToAdd.Text = existingBiometricLog.PunchTime.ToString("dd/MM/yyyy");

                if (textBoxPunchDate.Text.Trim().EndsWith("AM", StringComparison.OrdinalIgnoreCase))
                {
                    dtpPunchTimeToAdd.Value = DateTime.Today.AddHours(18).AddMinutes(0); // 6:00 PM
                }
                else if (textBoxPunchDate.Text.Trim().EndsWith("PM", StringComparison.OrdinalIgnoreCase))
                {
                    dtpPunchTimeToAdd.Value = DateTime.Today.AddHours(8).AddMinutes(30); // 8:30 AM
                }

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime punchTimeToAdd = new DateTime(
                 existingBiometricLog.PunchTime.Year,
                 existingBiometricLog.PunchTime.Month,
                 existingBiometricLog.PunchTime.Day,
                 dtpPunchTimeToAdd.Value.Hour,
                 dtpPunchTimeToAdd.Value.Minute,
                 0);


            // Add record to BiometricLogs | MANL
            var manualEntry = new BiometricLogDTO
            {
                BMEmployeeId = existingBiometricLog.BMEmployeeId,
                PunchTime = punchTimeToAdd,
                DeviceId = existingBiometricLog.DeviceId,
                PunchTypeFlag = existingBiometricLog.PunchTypeFlag, // Admin selects IN or OUT
                VerificationMode = existingBiometricLog.VerificationMode, // Manual Entry Code
                StatusCode = existingBiometricLog.StatusCode,
                CreatedAt = DateTime.UtcNow,
                RecordType = "MANL",
                BatchCode = existingBiometricLog.BatchCode,
                StartDate = existingBiometricLog.StartDate,
                EndDate = existingBiometricLog.EndDate,
                InOut = existingBiometricLog.InOut,
                ManualEntryRemark = textBoxRemark.Text
            };

            _biometricLogHelper.AddBiometricLog(manualEntry);

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
