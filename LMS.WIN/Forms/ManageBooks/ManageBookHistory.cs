using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class ManageBookHistory : Form
    {
        BookDetail bookDetail = null;
        public ManageBookHistory()
        {
            InitializeComponent();
        }

        private void ManageBookHistory_Load(object sender, EventArgs e)
        {

        }

        private void bindBookHistoryList(string name = null)
        {
            string searchValue = txtBarcode.Text;
            List<BookHistory> data = null;
            data = IssueBookBL.GetBookHistory(-1, bookDetail.BookBarcodeID, -1);
            if (data != null)
            {
                dataGridBookHistory.AutoGenerateColumns = false;
                lblmessage.Visible = false;
                dataGridBookHistory.DataSource = data;
                dataGridBookHistory.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("renew book list not found");
                //dataGridBookHistory.Visible = false;
                dataGridBookHistory.DataSource = null;
                dataGridBookHistory.AutoGenerateColumns = false;
                dataGridBookHistory.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridBookHistory.ColumnHeadersHeight = 35;
            dataGridBookHistory.BorderStyle = BorderStyle.None;
            dataGridBookHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridBookHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridBookHistory.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridBookHistory.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridBookHistory.BackgroundColor = Color.White;
            dataGridBookHistory.EnableHeadersVisualStyles = false;
            dataGridBookHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridBookHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(2, 56, 129);
            dataGridBookHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBarcode.Text == string.Empty)
                {
                    MessageBox.Show("Please enter barcode");
                    return;
                }
                bookDetail = BookBL.GetBookByBarcode(txtBarcode.Text);
                if (bookDetail != null)
                {
                    string isRestrict;
                    if (bookDetail.IsRestricted == true)
                    {
                        isRestrict = "Restricted";
                    }
                    else
                    {
                        isRestrict = "Non - Restricted";
                    }
                    pnlbookDetails.Visible = true;
                    txtAuthor.Text = bookDetail.Author;
                    txtPublisher.Text = bookDetail.Publisher;
                    txtType.Text = isRestrict;
                    txtSubCategory.Text = bookDetail.Category;
                    txtLanguage.Text = bookDetail.Language;
                    txtbookname.Text = bookDetail.Name;
                    bindBookHistoryList();
                }
                else
                {
                    pnlbookDetails.Visible = false;
                    txtAuthor.Text = string.Empty;
                    txtPublisher.Text = string.Empty;
                    txtType.Text = string.Empty;
                    txtLanguage.Text = string.Empty;
                    lblmessage.Visible = true;
                }
            }
        }
    }
}
