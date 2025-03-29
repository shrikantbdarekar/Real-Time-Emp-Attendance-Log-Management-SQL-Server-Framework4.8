using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSEmployeeAttendance25.Data;

namespace CSEmployeeAttendance25
{
    public partial class FormCompanyInfo : Form
    {
        private CompanyInfoDBHelper _companyHelper;
        public FormCompanyInfo()
        {
            InitializeComponent();

            _companyHelper = new CompanyInfoDBHelper();
            LoadCompanyInfo();
        }

        private void LoadCompanyInfo()
        {
            CompanyInfoDTO company = _companyHelper.GetCompanyInfo();
            if (company != null)
            {
                textBoxCompanyName.Text = company.CompanyName;
                textBoxAddress.Text = company.CompanyAddress;
                textBoxEmail.Text = company.EmailId;
                textBoxContactNo.Text = company.ContactNo;
                textBoxWebsite.Text = company.Website;
                dtpShiftStart.Value = DateTime.Today.Add(company.ShiftStart); // Convert TimeSpan to DateTime
                dtpShiftEnd.Value = DateTime.Today.Add(company.ShiftEnd);
            }
        }

        private void FormCompanyInfo_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(textBoxCompanyName.Text) || string.IsNullOrWhiteSpace(textBoxContactNo.Text))
            {
                MessageBox.Show("Company Name and Contact No. are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create DTO object
            CompanyInfoDTO company = new CompanyInfoDTO
            {
                CompanyName = textBoxCompanyName.Text.Trim(),
                CompanyAddress = textBoxAddress.Text.Trim(),
                EmailId = textBoxEmail.Text.Trim(),
                ContactNo = textBoxContactNo.Text.Trim(),
                Website = textBoxWebsite.Text.Trim(),
                ShiftStart = dtpShiftStart.Value.TimeOfDay, // Convert DateTime to TimeSpan
                ShiftEnd = dtpShiftEnd.Value.TimeOfDay // Convert DateTime to TimeSpan
            };

            // Save Data
            bool success = _companyHelper.SaveCompanyInfo(company);
            if (success)
            {
                MessageBox.Show("Company info saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Failed to save company info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
