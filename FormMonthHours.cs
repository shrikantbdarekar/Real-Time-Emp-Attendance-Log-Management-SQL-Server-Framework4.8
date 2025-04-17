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

        List<EmployeeMonthSalaryDTO> EmployeeMonthSalaryData;
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
            dgvMonthSalary.AutoGenerateColumns = false;
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            DateTime SD = dtpStartDate.Value;
            DateTime ED = dtpEndDate.Value;

            DateTime startDate = new DateTime(SD.Year, SD.Month, SD.Day, 0, 1, 0);
            DateTime endDate = new DateTime(ED.Year, ED.Month, ED.Day, 23, 59, 0);

            EmployeeMonthSalaryData = _biometricLogHelper.GetEmployeeMonthSalary(startDate, endDate);
            dgvMonthSalary.DataSource = EmployeeMonthSalaryData;

            BiometricLogMonthHourData = _biometricLogHelper.GetBiometricLogsForEmployeeMonthHour(startDate, endDate);

            BiometricLogEmployeeData = _biometricLogHelper.GetBiometricLogsForEmployeeMonthLog(startDate, endDate);
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Value = dtpStartDate.Value.AddMonths(1).AddDays(-1);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMonthSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcViewSalaryDetails.Index || e.ColumnIndex == dgcSalaryPrint.Index)
            {
                LoadSelectedEmployeeData();

                if (e.ColumnIndex == dgcViewSalaryDetails.Index)
                {
                    tabControlMain.SelectedTab = tabPageDailyHours; // Ensure the tab is selected
                    tabPageDailyHours.Focus(); // Set focus on the tab
                }

                if (e.ColumnIndex == dgcSalaryPrint.Index)
                {
                    FormReportViewer formReportViewer = new FormReportViewer((List<BiometricLogDTOEmployeeMonthHour>)dgvMonthHours.DataSource);
                    formReportViewer.ShowDialog();
                }
            }
        }

        private void LoadSelectedEmployeeData()
        {
            if (BiometricLogEmployeeData != null && BiometricLogMonthHourData != null)
            {
                int.TryParse(dgvMonthSalary.CurrentRow.Cells[dgcSalaryBMEmployeeId.Name].Value.ToString(), out int salaryBMEmployeeId);

                dgvMonthHours.DataSource = BiometricLogMonthHourData
                    .Where(x => x.BMEmployeeId == salaryBMEmployeeId)
                    .ToList();
                tabPageDailyHours.Text = "#Month Hours (" + dgvMonthHours.RowCount + ")";

                dgvBiometricLogs.DataSource = BiometricLogEmployeeData
                    .Where(x => x.BMEmployeeId == salaryBMEmployeeId)
                    .ToList();
                tabPageMonthLog.Text = "#Month Log (" + dgvBiometricLogs.RowCount + ")";
            }
            else
            {
                MessageBox.Show("First LOAD data for selected month!");
                buttonLoadData.Focus();
            }
        }

        private void buttonPrintAll_Click(object sender, EventArgs e)
        {
            if (dgvMonthSalary.RowCount > 0 && BiometricLogMonthHourData.Count > 0)
            {
                FormReportViewer formReportViewer = new FormReportViewer((List<BiometricLogDTOEmployeeMonthHour>)BiometricLogMonthHourData
                        .ToList());
                formReportViewer.ShowDialog();
            }
        }
    }
}
