using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageHome
{
    public partial class ManageHome : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        public ManageHome()
        {
            InitializeComponent();
        }

        private void ManageHome_Load(object sender, EventArgs e)
        {
            bindDashBordList();
            bindIssueBookList();
            bindAlertList();
        }

        private void bindDashBordList(string name = null)
        {
            Dashboard dashboard = new Dashboard();
            dashboard = DashboardBL.GetDashboard();

            if (dashboard != null)
            {
                lblCandidate.Text = dashboard.TotalCandidate.ToString();
                lbltotalbooks.Text = dashboard.TotalBook.ToString();
                lbltotalIssueBok.Text = dashboard.TotalIssueBook.ToString();
                lblPendingBook.Text = dashboard.TotalPendingBook.ToString();
            }
        }

        private void bindIssueBookList(string searchValue = null)
        {
            List<IssueBook> data = IssueBookBL.GetLatestIssueBook(-1, -1, -1, null, searchValue);
            if (data != null)
            {
                dataGridissueBook.AutoGenerateColumns = false;
                dataGridissueBook.DataSource = data;
                dataGridissueBook.Refresh();
                //getGridviewByDefaultDesign();
            }
            else
            {
                dataGridissueBook.DataSource = null;
                dataGridissueBook.AutoGenerateColumns = false;
                dataGridissueBook.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {

            dataGridissueBook.ColumnHeadersHeight = 35;
            dataGridissueBook.BorderStyle = BorderStyle.None;
            dataGridissueBook.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridissueBook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridissueBook.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridissueBook.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridissueBook.BackgroundColor = Color.White;
            dataGridissueBook.EnableHeadersVisualStyles = false;
            dataGridissueBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridissueBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridissueBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        public void bindAlertList(string searchValue = null)
        {
            List<IssueBook> data = null;
            data = AlertBL.Get(searchValue);
            if (data != null)
            {
                dataGridAlertBook.AutoGenerateColumns = false;
                dataGridAlertBook.Refresh();
                dataGridAlertBook.DataSource = data;
                //getGridviewByDefaultDesign();
            }
            else
            {
                //MessageBox.Show("Alert  list not found");
                dataGridAlertBook.DataSource = null;
                dataGridAlertBook.AutoGenerateColumns = false;
                dataGridAlertBook.Refresh();
            }
        }
    }
}