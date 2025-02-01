using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class ViewAvailableBookDetails : Form
    {
        AvailableBook availableBook = new AvailableBook();
        public ViewAvailableBookDetails(AvailableBook availableBookOBJ)
        {
            InitializeComponent();
            availableBook = availableBookOBJ;
        }

        private void ViewAvailableBookDetails_Load(object sender, EventArgs e)
        {
            bindBookBarcodeList();
        }

        private void bindBookBarcodeList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<BookBarcode> data = null;
            data = BookBL.GetAvailableBookBarcodeByBookID(availableBook.BookID, searchValue);
            if (data != null)
            {
                dataGridAvailablebook.AutoGenerateColumns = false;
                dataGridAvailablebook.DataSource = data;
                dataGridAvailablebook.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Candidate details not found....!");
                //dataGridBookHistory.Visible = false;
                dataGridAvailablebook.DataSource = null;
                dataGridAvailablebook.AutoGenerateColumns = false;
                dataGridAvailablebook.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridAvailablebook.ColumnHeadersHeight = 35;
            dataGridAvailablebook.BorderStyle = BorderStyle.None;
            dataGridAvailablebook.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridAvailablebook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridAvailablebook.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridAvailablebook.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridAvailablebook.BackgroundColor = Color.White;
            dataGridAvailablebook.EnableHeadersVisualStyles = false;
            dataGridAvailablebook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridAvailablebook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridAvailablebook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindBookBarcodeList(searchValue);
        }
    }
}
