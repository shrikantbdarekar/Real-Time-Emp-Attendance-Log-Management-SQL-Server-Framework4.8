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
    public partial class FormEmployeeList : Form
    {
        private EmployeeDBHelper _employeeHelper;
        public FormEmployeeList()
        {
            InitializeComponent();

            dgvMain.AutoGenerateColumns = false;

            _employeeHelper = new EmployeeDBHelper();
            LoadEmployees();
        }

        private void LoadEmployees(string searchQuery = "")
        {
            List<EmployeeDTO> employees = _employeeHelper.GetEmployees();

            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                employees = employees.FindAll(e => e.EmployeeName.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            dgvMain.DataSource = employees;
        }
        private void FormEmployeeList_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadEmployees(textBoxSearch.Text.Trim());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormSplachFullScreen formSplachFullScreen = new FormSplachFullScreen();
            formSplachFullScreen.Show();

            FormEmployee formEmployee = new FormEmployee();

            if (formEmployee.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees(); // Refresh list
            }

            formSplachFullScreen.Close();
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            long employeeId = Convert.ToInt64(dgvMain.Rows[e.RowIndex].Cells[dgcEmployeeId.Name].Value);

            if (e.ColumnIndex == dgcEdit.Index)
            {
                FormSplachFullScreen formSplachFullScreen = new FormSplachFullScreen();
                formSplachFullScreen.Show();

                FormEmployee formEmployee = new FormEmployee(employeeId);

                if (formEmployee.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployees(); // Refresh list
                }

                formSplachFullScreen.Close();
            }
            else if (e.ColumnIndex == dgcDelete.Index)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    if (_employeeHelper.DeleteEmployee(employeeId))
                    {
                        MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployees();
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
