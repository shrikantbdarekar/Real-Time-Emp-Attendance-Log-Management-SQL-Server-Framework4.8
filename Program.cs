using CSEmployeeAttendance25.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSEmployeeAttendance25
{
    static class Program
    {
        public static LoginUserDTO loginUser;
        public static CompanyInfoDTO companyInfo;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseHelper databaseHelper = new DatabaseHelper();
            if (!databaseHelper.IsValidConnection())
            {
                MessageBox.Show("Check database connection string!");
                return;
            }

            CompanyInfoDBHelper companyInfoHelper = new CompanyInfoDBHelper();
            companyInfo = companyInfoHelper.GetCompanyInfo();
            if (companyInfo==null)
            {
                MessageBox.Show("Check compnay setting in database!");
                return;
            }

            FormSplachFullScreen formSplachFullScreen = new FormSplachFullScreen();
            formSplachFullScreen.Show();

            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (formLogin.DialogResult == DialogResult.OK)
            {
                formSplachFullScreen.Close();

                FormMDI formMDI = new FormMDI();
                formMDI.ShowDialog();
                
            }
        }
    }
}
