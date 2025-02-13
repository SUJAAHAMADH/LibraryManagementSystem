using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class SearchBooks: Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        public SearchBooks()
        {
            InitializeComponent();
        }

        private void SearchBooks_Load(object sender, EventArgs e)
        {
            bindBookList();
        }
        private void bindBookList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<Book> data = null;
            data = BookBL.Get(-1, -1, -1, searchValue);
            if (data != null)
            {
                dataGridBook.AutoGenerateColumns = false;
                dataGridBook.DataSource = data;
                dataGridBook.Refresh();
                //getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("book list not found");
                dataGridBook.DataSource = null;
                dataGridBook.AutoGenerateColumns = false;
                dataGridBook.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridBook.ColumnHeadersHeight = 35;
            dataGridBook.BorderStyle = BorderStyle.None;
            dataGridBook.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridBook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridBook.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridBook.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridBook.BackgroundColor = Color.White;
            dataGridBook.EnableHeadersVisualStyles = false;
            dataGridBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindBookList(searchValue);
        }

        private void dataGridBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridBook.Columns[e.ColumnIndex].Name == "View")
            {
                DataGridViewRow dgvRow = dataGridBook.CurrentRow;
                Book user = new Book
                {
                    BookID = Convert.ToInt32(dgvRow.Cells["BookID"].Value.ToString()),
                    Name = dgvRow.Cells["Name"].Value.ToString(),
                };
                ViewBookDetails candidateDetails = new ViewBookDetails(user);
                candidateDetails.Show();
            }
            else
            {
                MessageBox.Show("No data found");

            }

        }

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            bindBookList();
        }
    }
}
