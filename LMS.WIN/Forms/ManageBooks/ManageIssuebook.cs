using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms
{
    public partial class ManageIssuebook : Form
    {
        public ManageIssuebook()
        {
            InitializeComponent();
        }

        private void btnissuebook_Click(object sender, EventArgs e)
        {

        }

        private void ManageIssuebook_Load(object sender, EventArgs e)
        {
            bindAvilableBookList();
        }

        private void bindAvilableBookList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<AvailableBook> data = null;
            data = BookBL.GetBookAvailableQty(-1, searchValue);
            if (data != null)
            {
                dataGridissueBook.AutoGenerateColumns = false;
                dataGridissueBook.DataSource = data;
                dataGridissueBook.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Issue book list not found");
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
            bindAvilableBookList(searchValue);
        }

        private void btnrenewbook_Click(object sender, EventArgs e)
        {
            pnlManageBook.Controls.Clear();
            ManageBooks.ManageRenewbook manageRenewbook = new ManageBooks.ManageRenewbook();
            manageRenewbook.TopLevel = false;
            pnlManageBook.Controls.Add(manageRenewbook);
            manageRenewbook.Show();
        }

        private void btnManageReturnbook_Click(object sender, EventArgs e)
        {
            pnlManageBook.Controls.Clear();
            ManageBooks.ManageReturnbook manageReturnbook = new ManageBooks.ManageReturnbook();
            manageReturnbook.TopLevel = false;
            pnlManageBook.Controls.Add(manageReturnbook);
            manageReturnbook.Show();
        }

        private void btnMissingbook_Click(object sender, EventArgs e)
        {
            pnlManageBook.Controls.Clear();
            ManageBooks.ManageMissingbook manageMissingbook = new ManageBooks.ManageMissingbook();
            manageMissingbook.TopLevel = false;
            pnlManageBook.Controls.Add(manageMissingbook);
            manageMissingbook.Show();
        }

        private void btnissue_Click(object sender, EventArgs e)
        {
            pnlManageBook.Controls.Clear();
            ManageBooks.ManageIssuebooks manageIssuebooks = new ManageBooks.ManageIssuebooks();
            manageIssuebooks.TopLevel = false;
            pnlManageBook.Controls.Add(manageIssuebooks);
            manageIssuebooks.Show();
        }

        private void dataGridissueBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridissueBook.Columns[e.ColumnIndex].Name == "View")
            {
                DataGridViewRow dgvRow = dataGridissueBook.CurrentRow;
                AvailableBook book = new AvailableBook
                {
                    BookID = Convert.ToInt32(dgvRow.Cells["BookID"].Value.ToString()),
                };
                ManageBooks.ViewAvailableBookDetails viewAvailableBook = new ManageBooks.ViewAvailableBookDetails(book);
                viewAvailableBook.Show();
            }
        }

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            bindAvilableBookList();
        }
    }
}
