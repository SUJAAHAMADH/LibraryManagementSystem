using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageAuthor
{
    public partial class ManageAuthor : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        public ManageAuthor()
        {
            InitializeComponent();
        }

        private void ManageAuthor_Load(object sender, EventArgs e)
        {
            bindAuthorList();
        }

        private void bindAuthorList(string searchValue = null)
        {
            List<Author> data = null;
            data = AuthorBL.Get(-1, searchValue);
            if (data != null)
            {
                dataGridAuthor.AutoGenerateColumns = false;
                dataGridAuthor.Refresh();
                dataGridAuthor.DataSource = data;
               // getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Author list not found");
                dataGridAuthor.DataSource = null;
                dataGridAuthor.AutoGenerateColumns = false;
                dataGridAuthor.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridAuthor.ColumnHeadersHeight = 35;
            dataGridAuthor.BorderStyle = BorderStyle.None;
            dataGridAuthor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridAuthor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridAuthor.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridAuthor.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridAuthor.BackgroundColor = Color.White;
            dataGridAuthor.EnableHeadersVisualStyles = false;
            dataGridAuthor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridAuthor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 56, 129);
            dataGridAuthor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindAuthorList(searchValue);
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Author author1 = new Author();
            frmAddAuthor addAuthor = new frmAddAuthor(author1);
            addAuthor.Show();
        }

        private void dataGridAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int col = dataGridAuthor.CurrentCell.ColumnIndex;
                int row = dataGridAuthor.CurrentCell.RowIndex;
                if (col < dataGridAuthor.ColumnCount - 1)
                {
                    col++;
                    Author author = new Author();
                    author = (Author)dataGridAuthor.CurrentRow.DataBoundItem;
                    frmAddAuthor frm = new frmAddAuthor(author);
                    frm.Show();
                }
                else
                {
                    col = 0;
                    row++;
                }
                e.Handled = true;
            }
        }

        private void dataGridAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridAuthor.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Do you want to delete the Author ?", " Author / Master ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        DataGridViewRow dgvRow = dataGridAuthor.CurrentRow;
                        Author author = new Author
                        {
                            AuthorID = Convert.ToInt32(dgvRow.Cells["AuthorID"].Value.ToString()),
                            UserID = userID,
                        };
                        author = AuthorBL.Deactive(author);
                        MessageBox.Show("Author delete successfully.");
                        bindAuthorList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (dataGridAuthor.Columns[e.ColumnIndex].Name == "Edit")
            {
                Author author = new Author();
                author = (Author)dataGridAuthor.CurrentRow.DataBoundItem;
                frmAddAuthor frm = new frmAddAuthor(author);
                frm.Show();
            }
        }

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            bindAuthorList();
        }
    }
}