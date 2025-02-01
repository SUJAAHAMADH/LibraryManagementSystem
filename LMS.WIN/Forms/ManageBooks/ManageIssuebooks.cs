using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class ManageIssuebooks : Form
    {
        public ManageIssuebooks()
        {
            InitializeComponent();
        }

        private void btnissuebook_Click(object sender, EventArgs e)
        {
            frmIssueBook issueBook = new frmIssueBook();
            issueBook.Show();
        }

        private void ManageIssuebooks_Load(object sender, EventArgs e)
        {
            string startDate = dtStartDateDate.Text;
            string endDate = dtendDate.Text;
            bindIssueBookList(null, startDate, endDate);
        }

        private void bindIssueBookList(string searchValue = null, string startDate = null, string endDate = null)
        {
            List<IssueBook> data = IssueBookBL.GetIssueBook(-1, -1, -1, null, searchValue, startDate, endDate);
            if (data != null)
            {
                dataGridissueBook.AutoGenerateColumns = false;
                dataGridissueBook.DataSource = data;
                dataGridissueBook.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                //MessageBox.Show("Issue book list not found");
                //dataGridissueBook.Visible = false;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindIssueBookList(searchValue);
        }

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            string startDate = dtStartDateDate.Text;
            string endDate = dtendDate.Text;
            bindIssueBookList(null, startDate, endDate);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string startDate = dtStartDateDate.Text;
            string endDate = dtendDate.Text;
            bindIssueBookList(null, startDate, endDate);
        }
    }
}
