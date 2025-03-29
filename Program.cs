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

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

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
