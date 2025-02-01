using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.WIN.Forms.Reports
{
    public partial class ManageReport : Form
    {
        public ManageReport()
        {
            InitializeComponent();
        }

        private void btnCandidateReport_Click(object sender, EventArgs e)
        {
            pnlManageReports.Controls.Clear();
            Reports.frmCandidatesReport  frmCandidatesReport = new Reports.frmCandidatesReport();
            frmCandidatesReport.TopLevel = false;
            pnlManageReports.Controls.Add(frmCandidatesReport);
            frmCandidatesReport.Show();
        }

        private void ManageReport_Load(object sender, EventArgs e)
        {

        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            pnlManageReports.Controls.Clear();
            Reports.frmBookWiseReport frmBookWiseReport = new Reports.frmBookWiseReport();
            frmBookWiseReport.TopLevel = false;
            pnlManageReports.Controls.Add(frmBookWiseReport);
            frmBookWiseReport.Show();
        }
    }
}
