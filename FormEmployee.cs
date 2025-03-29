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
    public partial class FormEmployee : Form
    {
        private EmployeeDBHelper _employeeHelper;
        private readonly long? _employeeId;

        public FormEmployee(long? employeeId = null)
        {
            InitializeComponent();

            _employeeHelper = new EmployeeDBHelper();
            _employeeId = employeeId;

            if (_employeeId.HasValue)
            {
                LoadEmployeeData();
            }
        }

        private void LoadEmployeeData()
        {
            EmployeeDTO employee = _employeeHelper.GetEmployeeById(_employeeId.Value);

            if (employee != null)
            {
                textBoxEmployeeCode.Text = employee.EmployeeCode;
                textBoxBMEmployeId.Text = employee.BMEmployeeId.ToString();
                dtpJoiningDate.Value = employee.JoiningDate;
                dtpBirthDate.Value = employee.BirthDate;
                textBoxEmployeeName.Text = employee.EmployeeName;
                textBoxAddress.Text = employee.Address;
                textBoxEmailId.Text = employee.EmailId;
                textBoxContactNo1.Text = employee.ContactNumber1;
                textBoxContactNo2.Text = employee.ContactNumber2;
                textBoxDepartmentName.Text = employee.Department;
                textBoxDesignation.Text = employee.Designation;
                numericMonthlySalary.Value = employee.MonthlySalary;
                numericHourlySalary.Value = employee.HourlySalary;
                dtpShiftStart.Value = DateTime.Today.Add(employee.ShiftStart);
                dtpShiftEnd.Value = DateTime.Today.Add(employee.ShiftEnd);
                checkBoxIsActive.Checked = employee.IsActive;
            }
        }
        private void FormEmployee_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ValidateData();

            int.TryParse(textBoxBMEmployeId.Text.Trim(), out int bmEmployeeId);

            EmployeeDTO employee = new EmployeeDTO
            {
                EmployeeCode = textBoxEmployeeCode.Text.Trim(),
                BMEmployeeId = bmEmployeeId,
                JoiningDate = dtpJoiningDate.Value,
                BirthDate = dtpBirthDate.Value,
                EmployeeName = textBoxEmployeeName.Text.Trim(),
                Address = textBoxAddress.Text.Trim(),
                EmailId = textBoxEmailId.Text.Trim(),
                ContactNumber1 = textBoxContactNo1.Text.Trim(),
                ContactNumber2 = textBoxContactNo2.Text.Trim(),
                Department = textBoxDepartmentName.Text.Trim(),
                Designation = textBoxDesignation.Text.Trim(),
                MonthlySalary = numericMonthlySalary.Value,
                HourlySalary = numericHourlySalary.Value,
                ShiftStart = dtpShiftStart.Value.TimeOfDay,
                ShiftEnd = dtpShiftEnd.Value.TimeOfDay,
                IsActive = checkBoxIsActive.Checked
            };

            bool success;
            if (_employeeId.HasValue)
            {
                employee.EmployeeId = _employeeId.Value;
                success = _employeeHelper.UpdateEmployee(employee);
            }
            else
            {
                success = _employeeHelper.AddEmployee(employee);
            }

            if (success)
            {
                MessageBox.Show("Employee saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrWhiteSpace(textBoxEmployeeCode.Text))
            {
                MessageBox.Show("Employee Code is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmployeeName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxBMEmployeId.Text))
            {
                MessageBox.Show("BM Employe Id is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmployeeName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxEmployeeName.Text))
            {
                MessageBox.Show("Employee Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmployeeName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxContactNo1.Text))
            {
                MessageBox.Show("Contact Number(1) is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxContactNo1.Focus();
                return;
            }

            // Validate Monthly Salary (ensure it's a decimal)
            if (numericMonthlySalary.Value <= 0)
            {
                MessageBox.Show("Please enter a valid Monthly Salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericMonthlySalary.Focus();
                return;
            }
            if (numericHourlySalary.Value <= 0)
            {
                MessageBox.Show("Please enter a valid Hourly Salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericHourlySalary.Focus();
                return;
            }

            // Validate Shift Start and Shift End (ensure they are selected)
            if (dtpShiftStart.Value == null || dtpShiftEnd.Value == null)
            {
                MessageBox.Show("Shift Start and Shift End are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure Shift Start is before Shift End
            //if (dtpShiftStart.Value.TimeOfDay >= dtpShiftEnd.Value.TimeOfDay)
            //{
            //    MessageBox.Show("Shift Start must be before Shift End.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

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
