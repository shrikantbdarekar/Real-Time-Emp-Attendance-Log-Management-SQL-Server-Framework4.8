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

namespace CSEmployeeAttendance25
{
    public partial class FormBiometricMachineList : Form
    {
        private BiometricMachineDBHelper _biometricMachineHelper;
        public FormBiometricMachineList()
        {
            InitializeComponent();

            dgvMain.AutoGenerateColumns = false;

            _biometricMachineHelper = new BiometricMachineDBHelper();
            LoadMachines();
        }

        private void LoadMachines(string searchText = "")
        {
            List<BiometricMachineDTO> machines = _biometricMachineHelper.GetBiometricMachines();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                machines = machines.Where(m => m.MachineName.Contains(searchText)).ToList();
            }
            dgvMain.DataSource = machines;
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadMachines(textBoxSearch.Text.Trim());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormSplachFullScreen formSplachFullScreen = new FormSplachFullScreen();
            formSplachFullScreen.Show();

            FormBiometricMachine formBiometricMachine = new FormBiometricMachine();

            if (formBiometricMachine.ShowDialog() == DialogResult.OK)
            {
                LoadMachines(); // Refresh list
            }

            formSplachFullScreen.Close();
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            long machineId = Convert.ToInt64(dgvMain.Rows[e.RowIndex].Cells[dgcMachineId.Name].Value);

            if (e.ColumnIndex == dgcEdit.Index)
            {
                FormSplachFullScreen formSplachFullScreen = new FormSplachFullScreen();
                formSplachFullScreen.Show();

                FormBiometricMachine formBiometricMachine = new FormBiometricMachine(machineId);

                if (formBiometricMachine.ShowDialog() == DialogResult.OK)
                {
                    LoadMachines(); // Refresh list
                }

                formSplachFullScreen.Close();
            }
            else if (e.ColumnIndex == dgcDelete.Index)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    if (_biometricMachineHelper.DeleteBiometricMachine(machineId))
                    {
                        MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMachines();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
