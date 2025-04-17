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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSEmployeeAttendance25
{
    public partial class FormManageMissingLog : Form
    {
        private BiometricLogDBHelper _biometricLogHelper;
        private EmployeeDBHelper _employeeHelper;

        public FormManageMissingLog()
        {
            InitializeComponent();


            _biometricLogHelper = new BiometricLogDBHelper();
            _employeeHelper = new EmployeeDBHelper();

            // Visible for super admin only
            if (Program.loginUser.Role == (int)enumMyUserRoles.SuperAdmin)
            {
                buttonDeleteLog.Visible = true;
                //dgcHistoryDelete.Visible = true;
            }

            dgvBiometricLogs.AutoGenerateColumns = false;
            dgvOneEntry.AutoGenerateColumns = false;
            dgvTwoPlusEntry.AutoGenerateColumns = false;

            LoadBatchCode();
        }

        private void LoadBatchCode()
        {
            DataTable batchCodesTable = _biometricLogHelper.GetDistinctBatchCodesWithoutInOut();

            comboBoxBatchCode.DataSource = batchCodesTable;
            comboBoxBatchCode.DisplayMember = "BatchName";
            comboBoxBatchCode.ValueMember = "BatchCode";
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            LoadGridviewData();

            buttonApplyInOut.Enabled = false;
            if (dgvOneEntry.RowCount == 0 && dgvTwoPlusEntry.RowCount == 0)
                buttonApplyInOut.Enabled = true;
        }

        private void LoadGridviewData()
        {
            if (comboBoxBatchCode.SelectedValue != null)
            {
                string batchCode = comboBoxBatchCode.SelectedValue.ToString();
                if (batchCode == null)
                {
                    MessageBox.Show("Select batch to proceed!", "Alert");
                    return;
                }

                LoadBioMetricData(batchCode);
                LoadOneEntryData(batchCode);
                //LoadTwoPlusEntryData(batchCode);
                LoadDuplicateEntryData(batchCode);

                tabControlMain.SelectedTab = tabPageAllRecords; // Ensure the tab is selected
                tabPageAllRecords.Focus(); // Set focus on the tab
            }
            else
            {
                MessageBox.Show("Select Batch Code!", "Batch Code");
                comboBoxBatchCode.Focus();
            }
        }

        private void LoadBioMetricData(string batchCode)
        {
            dgvBiometricLogs.DataSource = _biometricLogHelper.GetBiometricLogsWithEmployee(batchCode);

            tabPageAllRecords.Text = "#All Records (" + dgvBiometricLogs.RowCount + ")    ";
        }

        private void LoadOneEntryData(string batchCode)
        {
            dgvOneEntry.DataSource = _biometricLogHelper.GetBiometricLogsWithEmployeeOneEntry(batchCode);

            tabPageOneEntry.Text = "#One Entry (" + dgvOneEntry.RowCount + ")    ";
        }

        //private void LoadTwoPlusEntryData(string batchCode)
        //{
        //    dgvTwoPlusEntry.DataSource = _biometricLogHelper.GetBiometricLogsWithEmployeeTwoPlusEntry(batchCode);

        //    tabPageDuplicateEntry.Text = "#Two Plus Entry (" + dgvTwoPlusEntry.RowCount + ")    ";
        //}

        private void LoadDuplicateEntryData(string batchCode)
        {
            dgvTwoPlusEntry.DataSource = _biometricLogHelper.GetBiometricLogsWithEmployeeTwoPlusEntry(batchCode);

            tabPageDuplicateEntry.Text = "#Duplicate Entry (" + dgvTwoPlusEntry.RowCount + ")    ";
        }

        private void buttonApplyInOut_Click(object sender, EventArgs e)
        {
            if (comboBoxBatchCode.SelectedValue == null)
            {
                MessageBox.Show("Select batch to process!");
                return;
            }
            
            if (_biometricLogHelper.ApplyInOut(comboBoxBatchCode.SelectedValue.ToString()))
            {
                MessageBox.Show("In/Out applied successfully!", "Process Complete");
                dgvBiometricLogs.DataSource = null;
                dgvOneEntry.DataSource = null;
                dgvTwoPlusEntry.DataSource = null;
                LoadBatchCode();
            }
            else
            {
                MessageBox.Show("Error appling In/Out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteLog_Click(object sender, EventArgs e)
        {
            if (comboBoxBatchCode.SelectedValue == null)
            {
                MessageBox.Show("Select batch to delete!", "Alert");
                return;
            }

            if (MessageBox.Show("Do you want to delete log data for selected Batch?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (_biometricLogHelper.DeleteBatchHistory(comboBoxBatchCode.SelectedValue.ToString()))
            {
                MessageBox.Show("Batch data deleted successfully!", "Process Complete");
                LoadBatchCode();
            }
            else
            {
                MessageBox.Show("Error deleting employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOneEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcOneAddLog.Index)
            {
                int employeeId = Convert.ToInt32(dgvOneEntry.Rows[e.RowIndex].Cells[dgcOneEmployeeId.Name].Value);
                int logId = Convert.ToInt32(dgvOneEntry.Rows[e.RowIndex].Cells[dgcOneLogId.Name].Value);
                EmployeeDTO employee = _employeeHelper.GetEmployeeById(employeeId);
                BiometricLogDTO biometricLog = _biometricLogHelper.GetBiometricLogById(logId);

                if (employee != null && biometricLog != null)
                {
                    FormAddLogManually formAddManualLogAdv = new FormAddLogManually(employee, biometricLog);
                    formAddManualLogAdv.ShowDialog();

                    LoadBioMetricData(biometricLog.BatchCode);
                    LoadOneEntryData(biometricLog.BatchCode);

                    tabControlMain.SelectedTab = tabPageOneEntry; // Ensure the tab is selected
                    tabPageOneEntry.Focus(); // Set focus on the tab
                }

            }
        }

        private void dgvTwoPlusEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string batchCode = comboBoxBatchCode.SelectedValue.ToString();

            if (e.ColumnIndex == dgcTwoDelete.Index)
            {
                if (MessageBox.Show("Do you want to delete this log?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvTwoPlusEntry.Rows[e.RowIndex].Cells[dgcTwoLogId.Name].Value);

                    _biometricLogHelper.DeleteBiometricLog(id);

                    LoadBioMetricData(batchCode);
                    //LoadTwoPlusEntryData(batchCode);
                    LoadDuplicateEntryData(batchCode);

                    tabControlMain.SelectedTab = tabPageDuplicateEntry; // Ensure the tab is selected
                    tabPageDuplicateEntry.Focus(); // Set focus on the tab
                }
            }
        }

        private void buttonAutoDeleteDuplicates_Click(object sender, EventArgs e)
        {
            if (dgvTwoPlusEntry.RowCount == 0)
            {
                buttonAutoDeleteDuplicates.Enabled = false;
                return;
            }
            if (comboBoxBatchCode.SelectedValue == null)
            {
                MessageBox.Show("Seelct Batch!");
                return;
            }
            string batchCode = comboBoxBatchCode.SelectedValue.ToString();

            if (MessageBox.Show("Do you want to delete duplucate punch times?", "Time-span 15 Minutes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _biometricLogHelper.DeleteBiometricLogDuplicateEntry(batchCode);

            LoadBioMetricData(batchCode);
            LoadDuplicateEntryData(batchCode);

            tabControlMain.SelectedTab = tabPageDuplicateEntry; // Ensure the tab is selected
            tabPageDuplicateEntry.Focus(); // Set focus on the tab
        }
    }
}
