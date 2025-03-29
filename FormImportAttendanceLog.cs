using CSEmployeeAttendance25.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSEmployeeAttendance25
{
    public partial class FormImportAttendanceLog : Form
    {
        private BiometricLogDBHelper _biometricLogHelper;
        public FormImportAttendanceLog()
        {
            InitializeComponent();

            _biometricLogHelper = new BiometricLogDBHelper();

            // Visible for super admin only
            if (Program.loginUser.Role == (int)enumMyUserRoles.SuperAdmin)
            {
                //dgcHistoryDelete.Visible = true;
            }

            DateTime now = DateTime.Now;

            // Get the first day of the previous month
            DateTime firstDayOfPreviousMonth = new DateTime(now.Year, now.Month, 1).AddMonths(-1);
            // Get the last day of the previous month
            DateTime lastDayOfPreviousMonth = firstDayOfPreviousMonth.AddMonths(1).AddDays(-1);

            dtpStartDate.Value = firstDayOfPreviousMonth;
            dtpEndDate.Value = lastDayOfPreviousMonth;

            dgvBiometricLogs.AutoGenerateColumns = false;
            dgvBatchHistory.AutoGenerateColumns = false;

            LoadBatchHistory();
        }

        private void LoadBatchHistory()
        {
            DataTable batchCodesTable = _biometricLogHelper.GetDistinctBatchCodes();

            dgvBatchHistory.DataSource = batchCodesTable;
            dgvBiometricLogs.DataSource = null;

            tabPageBatchHistory.Text = "#Batch History (" + dgvBatchHistory.RowCount + ")     ";
            tabPageRawLogs.Text = "#Raw Log Data (0)     ";
        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Backup File | *.dat";
            fileDialog.ShowDialog();
            string fileName = fileDialog.FileName;
            textBoxFileName.Text = fileName;
        }

        private void buttonImportData_Click(object sender, EventArgs e)
        {
            if (textBoxFileName.Text == string.Empty)
            {
                MessageBox.Show("Select file to import data!", "Alert");
                return;
            }
            try
            {
                string fileName = textBoxFileName.Text;

                DateTime FD = dtpStartDate.Value;
                DateTime TD = dtpEndDate.Value;

                DateTime fromDate = new DateTime(FD.Year, FD.Month, FD.Day, 0, 1, 0);
                DateTime toDate = new DateTime(TD.Year, TD.Month, TD.Day, 23, 59, 0);

                if (File.Exists(fileName))
                {
                    FormSplash formSplash = new FormSplash();
                    formSplash.Show();
                    Application.DoEvents();

                    string batchCode = _biometricLogHelper.ImportCSVToDatabaseSimple(fileName, fromDate, toDate);

                    formSplash.Close();

                    LoadBatchHistory();
                    LoadBatchData(batchCode);
                }
                else
                {
                    MessageBox.Show("Data import canceld!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data import failed!\n" + ex.Message);
            }
        }

        private void LoadBatchData(string batchCode)
        {
            dgvBiometricLogs.DataSource = _biometricLogHelper.GetBiometricLogsWithEmployee(batchCode);

            labelBatchCode.Text = "Batch Code\n" + batchCode;
            tabPageRawLogs.Text = "#Raw Log Data (" + dgvBiometricLogs.RowCount + ")    ";

            tabControlMain.SelectedTab = tabPageRawLogs; // Ensure the tab is selected
            tabPageRawLogs.Focus(); // Set focus on the tab
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Value = dtpStartDate.Value.AddMonths(1).AddDays(-1);
        }

        private void dgvBatchHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string batchCode = dgvBatchHistory.Rows[e.RowIndex].Cells[dgcHistoryBatchCode.Name].Value.ToString();

            if (e.ColumnIndex == dgcHistoryViewDetails.Index)
            {
                if (batchCode != null && batchCode != string.Empty)
                {
                    LoadBatchData(batchCode);

                }
            }
            else if (e.ColumnIndex == dgcHistoryDeleteDetails.Index)
            {
                if (MessageBox.Show("Do you want to delete log data for selected Batch?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                if (_biometricLogHelper.DeleteBatchHistory(batchCode))
                {
                    MessageBox.Show("Batch data deleted successfully!", "Process Complete");
                    LoadBatchHistory();
                }
                else
                {
                    MessageBox.Show("Error deleting employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
