using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class ManageRenewbook : Form
    {
        public ManageRenewbook()
        {
            InitializeComponent();
        }

        private void btnrenewbook_Click(object sender, EventArgs e)
        {
            frmRenewalBook renewalBook = new frmRenewalBook();
            renewalBook.Show();
        }

        private void ManageRenewbook_Load(object sender, EventArgs e)
        {
            string startDate = dtStartDateDate.Text;
            string endDate = dtendDate.Text;
            bindRenewBookList(null, startDate, endDate);
        }

        private void bindRenewBookList(string searchValue = null, string startDate = null, string endDate = null)
        {
            List<IssueBook> data = IssueBookBL.GetRenewalBook(-1, -1, -1, searchValue, startDate, endDate);
            if (data != null)
            {
                dataGridRenewBook.AutoGenerateColumns = false;
                dataGridRenewBook.DataSource = data;
                dataGridRenewBook.Refresh();
              //  getGridviewByDefaultDesign();
            }
            else
            {
                //MessageBox.Show("renew book list not found");
                //dataGridRenewBook.Visible = false;
                dataGridRenewBook.DataSource = null;
                dataGridRenewBook.AutoGenerateColumns = false;
                dataGridRenewBook.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridRenewBook.ColumnHeadersHeight = 35;
            dataGridRenewBook.BorderStyle = BorderStyle.None;
            dataGridRenewBook.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridRenewBook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridRenewBook.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridRenewBook.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridRenewBook.BackgroundColor = Color.White;
            dataGridRenewBook.EnableHeadersVisualStyles = false;
            dataGridRenewBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridRenewBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridRenewBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindRenewBookList(searchValue);
        }

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            string startDate = dtStartDateDate.Text;
            string endDate = dtendDate.Text;
            bindRenewBookList(null, startDate, endDate);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string startDate = dtStartDateDate.Text;
            string endDate = dtendDate.Text;
            bindRenewBookList(null, startDate, endDate);
        }
    }
}
