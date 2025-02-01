using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Search_Control
{
    public partial class frmSearchAuthor : Form
    {
        int userID;
        public frmSearchAuthor()
        {
            InitializeComponent();
        }

        private void frmSearchAuthor_Load(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
            txtSearch.Focus();
            bindAuthorList();
        }

        private void bindAuthorList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<Author> data = null;
            data = AuthorBL.Get(-1, searchValue);

            if (data != null)
            {

                gridAuthorList.AutoGenerateColumns = false;
                gridAuthorList.Refresh();
                gridAuthorList.DataSource = data;
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Author list not found");
                gridAuthorList.DataSource = null;
                gridAuthorList.AutoGenerateColumns = false;
                gridAuthorList.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            gridAuthorList.ColumnHeadersHeight = 35;
            gridAuthorList.BorderStyle = BorderStyle.None;
            gridAuthorList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridAuthorList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridAuthorList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridAuthorList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridAuthorList.BackgroundColor = Color.White;

            gridAuthorList.EnableHeadersVisualStyles = false;
            gridAuthorList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridAuthorList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridAuthorList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindAuthorList(searchValue);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                GlobalVariable.GlobalAuthorObj = null;
            }
            if (e.KeyCode == Keys.Down)
            {
                gridAuthorList.Focus();
            }
        }

        private void gridAuthorList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Author author = new Author();
                author = (Author)gridAuthorList.CurrentRow.DataBoundItem;
                if (author != null)
                {
                    GlobalVariable.GlobalAuthorObj = author;
                    Close();
                }
                else
                {
                    MessageBox.Show(" No Author list found", "Author list", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gridAuthorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridAuthorList.Columns[e.ColumnIndex].Name == "Name")
            {
                Author author = new Author();
                author = (Author)gridAuthorList.CurrentRow.DataBoundItem;
                if (author != null)
                {
                    GlobalVariable.GlobalAuthorObj = author;
                    Close();
                }

            }
            if (gridAuthorList.Columns[e.ColumnIndex].Name == "Select")
            {
                Author author = new Author();
                author = (Author)gridAuthorList.CurrentRow.DataBoundItem;
                if (author != null)
                {
                    GlobalVariable.GlobalAuthorObj = author;
                    Close();
                }

            }

        }
    }
}
