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
    public partial class FormBiometricMachine : Form
    {
        private BiometricMachineDBHelper _machineHelper;
        private readonly long? _machineId;
        public FormBiometricMachine(long? machineId = null)
        {
            InitializeComponent();

            _machineHelper = new BiometricMachineDBHelper();
            _machineId = machineId;

            if (_machineId.HasValue)
            {
                LoadMachineData();
            }
        }

        private void LoadMachineData()
        {
            BiometricMachineDTO biometricMachine = _machineHelper.GetBiometricMachineById(_machineId.Value);

            if (biometricMachine != null)
            {
                textBoxMachineName.Text = biometricMachine.MachineName;
                textBoxBMMachineId.Text = biometricMachine.BMMachineId.ToString();
                textBoxDescription.Text = biometricMachine.MachineDescription;
            }
        }

        private void FormBiometricMachine_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ValidateData();

            int.TryParse(textBoxBMMachineId.Text.Trim(), out int bmMachineId);

            BiometricMachineDTO biometricMachine = new BiometricMachineDTO
            {
                MachineName = textBoxMachineName.Text.Trim(),
                BMMachineId = bmMachineId,
                MachineDescription = textBoxDescription.Text.Trim()
            };

            bool success;
            if (_machineId.HasValue)
            {
                biometricMachine.MachineId = _machineId.Value;
                success = _machineHelper.UpdateBiometricMachine(biometricMachine);
            }
            else
            {
                success = _machineHelper.AddBiometricMachine(biometricMachine);
            }

            if (success)
            {
                MessageBox.Show("Machine saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error saving employee data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateData()
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(textBoxMachineName.Text))
            {
                MessageBox.Show("Machine Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMachineName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxBMMachineId.Text))
            {
                MessageBox.Show("BM Machine Id is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxBMMachineId.Focus();
                return;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
