using CrystalDecisions.CrystalReports.Engine;
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

namespace CSEmployeeAttendance25.Reports
{
    public partial class FormReportViewer: Form
    {
        public FormReportViewer()
        {
            InitializeComponent();
        }

        public FormReportViewer(List<BiometricLogDTOEmployeeMonthHour> rptSource)
        {
            InitializeComponent();

            ReportDocument rptDoc = new CrystalReportTest();
            rptDoc.SetDataSource(DataTableHelper.ConvertToDataTable(rptSource));

            rptDoc.SetParameterValue("CompanyName", Program.companyInfo.CompanyName);
            rptDoc.SetParameterValue("CompanyAddress", Program.companyInfo.CompanyAddress);
            rptDoc.SetParameterValue("Email", Program.companyInfo.EmailId);
            rptDoc.SetParameterValue("ContactNo", Program.companyInfo.ContactNo);
            rptDoc.SetParameterValue("Website", Program.companyInfo.Website);

            crystalReportViewer1.ReportSource = rptDoc;

            Application.DoEvents();
        }

        private void FormReportViewer_Load(object sender, EventArgs e)
        {
        }
    }
}
