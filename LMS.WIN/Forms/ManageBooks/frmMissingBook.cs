using LMS.BL;
using LMS.MOD;
using System;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class frmMissingBook : Form
    {
        public frmMissingBook()
        {
            InitializeComponent();
        }

        int userID = 1;
        BookDetail bookDetail = null;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
                    txtName.Text = bookDetail.Name;
                    txtAuthor.Text = bookDetail.Author;
                    txtPublisher.Text = bookDetail.Publisher;
                    txtEdition.Text = bookDetail.Edition;
                    txtLanguage.Text = bookDetail.Language;
                    txtPrice.Text = bookDetail.Price.ToString();
                    txtIsbn.Text = bookDetail.Isbn;
                    txtDescription.Text = bookDetail.Description;
                }
                else
                {
                    txtName.Text = string.Empty;
                    txtAuthor.Text = string.Empty;
                    txtPublisher.Text = string.Empty;
                    txtEdition.Text = string.Empty;
                    txtLanguage.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txtPrice.Text = string.Empty;
                    txtIsbn.Text = string.Empty;
                    txtDescription.Text = string.Empty;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text != string.Empty)
            {
                if (MessageBox.Show("Do you want to Save the missing Book ?", "Done ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        MissingBook missingBook = new MissingBook
                        {
                            BookBarcodeID = bookDetail.BookBarcodeID,
                            Remark = txtRemark.Text,
                            UserID = userID,
                        };
                        missingBook = MissingBookBL.Save(missingBook);
                        MessageBox.Show("Missing Book Details successfully.", "Missing Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Missing Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
