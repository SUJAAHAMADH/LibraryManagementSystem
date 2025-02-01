using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class ManageReturnbook : Form
    {
        public ManageReturnbook()
        {
            InitializeComponent();
        }

        private void ManageReturnbook_Load(object sender, EventArgs e)
        {
            string startDate = dtStartDateDate.Text;
            string endDate = dtendDate.Text;
            bindReturnBookList(null, startDate, endDate);
        }

        private void bindReturnBookList(string searchValue = null, string startDate = null, string endDate = null)
        {
            List<IssueBook> data = IssueBookBL.GetReturnBook(-1, -1, -1, searchValue, startDate, endDate);
            if (data != null)
            {
                dataGridReturnBook.AutoGenerateColumns = false;
                dataGridReturnBook.DataSource = data;
                dataGridReturnBook.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                //MessageBox.Show("renew book list not found");
                dataGridReturnBook.DataSource = null;
                dataGridReturnBook.AutoGenerateColumns = false;
                dataGridReturnBook.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridReturnBook.ColumnHeadersHeight = 35;
            dataGridReturnBook.BorderStyle = BorderStyle.None;
            dataGridReturnBook.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridReturnBook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridReturnBook.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridReturnBook.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridReturnBook.BackgroundColor = Color.White;
            dataGridReturnBook.EnableHeadersVisualStyles = false;
            dataGridReturnBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridReturnBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridReturnBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnreturnbook_Click(object sender, EventArgs e)
        {
            frmReturnBook returnBook = new frmReturnBook();
            returnBook.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindReturnBookList(searchValue);
        }

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            string startDate = dtStartDateDate.Text;
            string endDate = dtendDate.Text;
            bindReturnBookList(null, startDate, endDate);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string startDate = dtStartDateDate.Text;
            string endDate = dtendDate.Text;
            bindReturnBookList(null, startDate, endDate);
        }
    }
}
