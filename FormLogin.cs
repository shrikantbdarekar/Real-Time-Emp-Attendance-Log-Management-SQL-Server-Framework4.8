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
    public partial class FormLogin: Form
    {
        private LoginUserDBHelper _loginHelper;
        public FormLogin()
        {
            InitializeComponent();

            _loginHelper = new LoginUserDBHelper();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the login check method
            LoginUserDTO user = _loginHelper.AuthenticateUser(username, password);

            if (user != null)
            {
                if (!user.IsActive)
                {
                    MessageBox.Show("Your account is inactive. Contact admin.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Program.loginUser = user;

                //MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
