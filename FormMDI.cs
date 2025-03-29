using CSEmployeeAttendance25.Reports;
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
    public partial class FormMDI: Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {

        }

        private void mnuCompanyInfo_Click(object sender, EventArgs e)
        {
            FormCompanyInfo formCompanyInfo = new FormCompanyInfo();
            formCompanyInfo.ShowDialog();
        }

        private void mnuBiometricMachine_Click(object sender, EventArgs e)
        {
            FormBiometricMachineList formBiometricMachineList = new FormBiometricMachineList();
            formBiometricMachineList.ShowDialog();
        }

        private void mnuUserAccount_Click(object sender, EventArgs e)
        {
            FormUserAccount formUserAccount = new FormUserAccount();
            formUserAccount.ShowDialog();
        }

        private void mnuChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword formChangePassword = new FormChangePassword();
            formChangePassword.ShowDialog();
        }

        private void mnuEmployee_Click(object sender, EventArgs e)
        {
            FormEmployeeList formEmployeeList = new FormEmployeeList();
            formEmployeeList.ShowDialog();
        }

        private void mnuImportAttendanceLog_Click(object sender, EventArgs e)
        {
            FormImportAttendanceLog formImportAttendanceLog = new FormImportAttendanceLog();
            formImportAttendanceLog.ShowDialog();
        }

        private void mnuManageMissingLog_Click(object sender, EventArgs e)
        {
            FormManageMissingLog formManageMissingLog = new FormManageMissingLog();
            formManageMissingLog.ShowDialog();
        }

        private void mnuCalculateSalary_Click(object sender, EventArgs e)
        {
            FormCalculateSalary formCalculateSalary = new FormCalculateSalary();
            formCalculateSalary.ShowDialog();
        }

        private void mnuReport_Click(object sender, EventArgs e)
        {
            FormReportViewer formReportViewer = new FormReportViewer();
            formReportViewer.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
