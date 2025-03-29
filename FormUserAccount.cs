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
    public partial class FormUserAccount : Form
    {
        private LoginUserDBHelper _userHelper;
        private readonly long? _loginId;
        public FormUserAccount(long? loginId=null)
        {
            InitializeComponent();

            comboBoxRole.DataSource = new BindingSource(dictUserRoles.myUserRoles, null);
            comboBoxRole.DisplayMember = "Value";
            comboBoxRole.ValueMember = "Key";

            _userHelper = new LoginUserDBHelper();
            _loginId = loginId;

            if (_loginId.HasValue)
            {
                LoadMachineData();
            }
        }

        private void LoadMachineData()
        {
            LoginUserDTO loginUser = _userHelper.GetUserById(_loginId.Value);

            if (loginUser != null)
            {
                textBoxUserName.Text = loginUser.UserName;
                comboBoxRole.SelectedValue = loginUser.Role;
                textBoxPassword.Text = loginUser.PasswordHash;
                checkBoxIsActive.Checked = loginUser.IsActive;
            }
        }
        private void FormCompanyInfo_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //int.TryParse(comboBoxRole.SelectedValue.ToString(), out int selectedRole);
            int selectedRole = ((KeyValuePair<int, string>)comboBoxRole.SelectedItem).Key;

            ValidateData();

            LoginUserDTO loginUser = new LoginUserDTO
            {
                UserName = textBoxUserName.Text.Trim(),
                Role = selectedRole,
                PasswordHash = textBoxPassword.Text.Trim(),
                IsActive = checkBoxIsActive.Checked
            };

            bool success;
            if (_loginId.HasValue)
            {
                loginUser.UserId = _loginId.Value;
                success = _userHelper.UpdateUser(loginUser);
            }
            else
            {
                success = _userHelper.AddUser(loginUser);
            }

            if (success)
            {
                MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error saving user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateData()
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(textBoxUserName.Text))
            {
                MessageBox.Show("User Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUserName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPassword.Focus();
                return;
            }
            if (comboBoxRole.SelectedItem==null)
            {
                MessageBox.Show("Role is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxRole.Focus();
                return;
            }
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
