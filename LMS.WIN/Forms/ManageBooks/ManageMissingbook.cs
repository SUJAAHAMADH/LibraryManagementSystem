using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class ManageMissingbook : Form
    {
        public ManageMissingbook()
        {
            InitializeComponent();
        }

        private void ManageMissingbook_Load(object sender, EventArgs e)
        {
            bindMissingBookList();
        }

        private void bindMissingBookList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<MissingBook> data = null;
            data = MissingBookBL.Get(-1, -1, searchValue);
            if (data != null)
            {
                dataGridMissingBook.AutoGenerateColumns = false;
                dataGridMissingBook.DataSource = data;
                dataGridMissingBook.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("renew book list not found");
                //dataGridMissingBook.Visible = false;
                dataGridMissingBook.DataSource = null;
                dataGridMissingBook.AutoGenerateColumns = false;
                dataGridMissingBook.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridMissingBook.ColumnHeadersHeight = 35;
            dataGridMissingBook.BorderStyle = BorderStyle.None;
            dataGridMissingBook.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridMissingBook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridMissingBook.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridMissingBook.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridMissingBook.BackgroundColor = Color.White;
            dataGridMissingBook.EnableHeadersVisualStyles = false;
            dataGridMissingBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridMissingBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridMissingBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnmissingbook_Click(object sender, EventArgs e)
        {
            frmMissingBook missingBook = new frmMissingBook();
            missingBook.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindMissingBookList(searchValue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bindMissingBookList();
        }
    }
}
