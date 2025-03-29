using CSEmployeeAttendance25.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace CSEmployeeAttendance25
{
    public partial class FormUserAccountList : Form
    {
        private LoginUserDBHelper _userHelper;
        public FormUserAccountList()
        {
            InitializeComponent();

            dgcRole.DataSource = new BindingSource(dictUserRoles.myUserRoles, null);
            dgcRole.DisplayMember = "Value";
            dgcRole.ValueMember = "Key";

            dgvMain.AutoGenerateColumns = false;

            _userHelper = new LoginUserDBHelper();
            LoadUsers();
        }

        private void LoadUsers(string searchText = "")
        {
            List<LoginUserDTO> users = _userHelper.GetUsers();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                users = users.Where(m => m.UserName.Contains(searchText)).ToList();
            }
            dgvMain.DataSource = users;
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadUsers(textBoxSearch.Text.Trim());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormSplachFullScreen formSplachFullScreen = new FormSplachFullScreen();
            formSplachFullScreen.Show();

            FormUserAccount formUserAccount = new FormUserAccount();

            if (formUserAccount.ShowDialog() == DialogResult.OK)
            {
                LoadUsers(); // Refresh list
            }

            formSplachFullScreen.Close();
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            long userId = Convert.ToInt64(dgvMain.Rows[e.RowIndex].Cells[dgcLoginId.Name].Value);

            if (e.ColumnIndex == dgcEdit.Index)
            {
                FormSplachFullScreen formSplachFullScreen = new FormSplachFullScreen();
                formSplachFullScreen.Show();

                FormUserAccount formUserAccount = new FormUserAccount(userId);

                if (formUserAccount.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers(); // Refresh list
                }

                formSplachFullScreen.Close();
            }
            else if (e.ColumnIndex == dgcDelete.Index)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    if (_userHelper.DeleteUser(userId))
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
