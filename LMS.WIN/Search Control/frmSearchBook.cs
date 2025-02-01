using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Search_Control
{
    public partial class frmSearchBook : Form
    {
        int userID;
        public frmSearchBook()
        {
            InitializeComponent();
        }

        private void frmSearchBook_Load(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
            txtSearch.Focus();
            bindBookList();
        }
        private void bindBookList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<Book> data = null;
            data = BookBL.Get(-1,-1, -1, searchValue);

            if (data != null)
            {
                gridbookList.AutoGenerateColumns = false;
                gridbookList.Refresh();
                gridbookList.DataSource = data;
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Book list not found");
                gridbookList.DataSource = null;
                gridbookList.AutoGenerateColumns = false;
                gridbookList.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            gridbookList.ColumnHeadersHeight = 35;
            gridbookList.BorderStyle = BorderStyle.None;
            gridbookList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridbookList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridbookList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridbookList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridbookList.BackgroundColor = Color.White;
           
            gridbookList.EnableHeadersVisualStyles = false;
            gridbookList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridbookList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridbookList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindBookList(searchValue);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                GlobalVariable.GlobalBookObj = null;
            }
            if (e.KeyCode == Keys.Down)
            {
                gridbookList.Focus();
            }
        }

        private void gridbookList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Book book = new Book();
                book = (Book)gridbookList.CurrentRow.DataBoundItem;
                if (book != null)
                {
                    GlobalVariable.GlobalBookObj = book;
                    Close();
                }
                else
                {
                    MessageBox.Show(" No Publisher list found", "book list", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gridbookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridbookList.Columns[e.ColumnIndex].Name == "Name")
            {
                Book book = new Book();
                book = (Book)gridbookList.CurrentRow.DataBoundItem;
                if (book != null)
                {
                    GlobalVariable.GlobalBookObj = book;
                    Close();
                }
            }
            if (gridbookList.Columns[e.ColumnIndex].Name == "Select")
            {
                Book book = new Book();
                book = (Book)gridbookList.CurrentRow.DataBoundItem;
                if (book != null)
                {
                    GlobalVariable.GlobalBookObj = book;
                    Close();
                }
            }
        }
    }
}
