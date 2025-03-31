using CSEmployeeAttendance25.Data;
using CSEmployeeAttendance25.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSEmployeeAttendance25
{
    public partial class FormMonthHours : Form
    {
        private BiometricLogDBHelper _biometricLogHelper;
        private EmployeeDBHelper _employeeHelper;

        List<BiometricLogDTOEmployeeMonthHour> BiometricLogMonthHourData;
        List<BiometricLogDTOWithEmployee> BiometricLogEmployeeData;

        public FormMonthHours()
        {
            InitializeComponent();

            _biometricLogHelper = new BiometricLogDBHelper();
            _employeeHelper = new EmployeeDBHelper();

            DateTime now = DateTime.Now;

            // Get the first day of the previous month
            DateTime firstDayOfPreviousMonth = new DateTime(now.Year, now.Month, 1).AddMonths(-1);
            // Get the last day of the previous month
            DateTime lastDayOfPreviousMonth = firstDayOfPreviousMonth.AddMonths(1).AddDays(-1);

            dtpStartDate.Value = firstDayOfPreviousMonth;
            dtpEndDate.Value = lastDayOfPreviousMonth;

            dgvBiometricLogs.AutoGenerateColumns = false;
            dgvMonthHours.AutoGenerateColumns = false;

           
        }

        private void FormCompanyInfo_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            DateTime SD = dtpStartDate.Value;
            DateTime ED = dtpEndDate.Value;

            //int.TryParse(comboBoxEmployee.SelectedValue.ToString(), out int empId);
            DateTime startDate = new DateTime(SD.Year, SD.Month, SD.Day, 0, 1, 0);
            DateTime endDate = new DateTime(ED.Year, ED.Month, ED.Day, 23, 59, 0);

            comboBoxEmployee.DataSource = _employeeHelper.GetEmployeesDropdown(startDate, endDate);
            comboBoxEmployee.DisplayMember = "EmployeeName";
            comboBoxEmployee.ValueMember = "BMEmployeeId";

            BiometricLogMonthHourData = _biometricLogHelper.GetBiometricLogsForEmployeeMonthHour(startDate, endDate);
            dgvMonthHours.DataSource = BiometricLogMonthHourData;
            tabPageDailyHours.Text = "#Month Hours (" + dgvMonthHours.RowCount + ")";

            BiometricLogEmployeeData = _biometricLogHelper.GetBiometricLogsForEmployeeMonthLog(startDate, endDate);
            dgvBiometricLogs.DataSource = BiometricLogEmployeeData;
            tabPageMonthLog.Text = "#Month Log (" + dgvBiometricLogs.RowCount + ")";
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Value = dtpStartDate.Value.AddMonths(1).AddDays(-1);
        }

        private void comboBoxEmployee_Enter(object sender, EventArgs e)
        {
            comboBoxEmployee.Height = 100;
        }

        private void comboBoxEmployee_Leave(object sender, EventArgs e)
        {
            comboBoxEmployee.Height = 26;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFilterEmployee_Click(object sender, EventArgs e)
        {
            if (BiometricLogEmployeeData != null && BiometricLogMonthHourData != null)
            {
                if (comboBoxEmployee.SelectedValue == null)
                {
                    MessageBox.Show("Select employee!");
                    return;
                }

                int.TryParse(comboBoxEmployee.SelectedValue.ToString(), out int bmEmployeeId);

                dgvMonthHours.DataSource = BiometricLogMonthHourData
                    .Where(x => x.BMEmployeeId == bmEmployeeId)
                    .ToList();
                tabPageDailyHours.Text = "#Month Hours (" + dgvMonthHours.RowCount + ")";

                dgvBiometricLogs.DataSource = BiometricLogEmployeeData
                    .Where(x => x.BMEmployeeId == bmEmployeeId)
                    .ToList();
                tabPageMonthLog.Text = "#Month Log (" + dgvBiometricLogs.RowCount + ")";
            }
            else
            {
                MessageBox.Show("First LOAD data for selected month!");
                buttonLoadData.Focus();
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            FormReportViewer formReportViewer = new FormReportViewer((List<BiometricLogDTOEmployeeMonthHour>)dgvMonthHours.DataSource);
            formReportViewer.ShowDialog();
        }
    }
}
