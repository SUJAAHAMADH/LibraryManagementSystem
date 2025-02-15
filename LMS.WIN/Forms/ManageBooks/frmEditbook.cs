using LMS.BL;
using LMS.MOD;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class frmEditbook : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        Publisher publisherObj = null;
        Author authorObj = null;
        Book book = new Book();
        int bookID = -1;
        public frmEditbook(Book bookOBJ)
        {
            InitializeComponent();
            book = bookOBJ;
        }

        private void frmEditbook_Load(object sender, EventArgs e)
        {
            bindLanguage();
            bindCategory();
            if (book != null)
            {
                bindbookDetailsOnControls();
                gridBookList.ColumnCount = 3;
                gridBookList.Columns[0].Name = "#";
                gridBookList.Columns[0].Visible = false;
                gridBookList.Columns[1].Name = "Barcode";
                gridBookList.Columns[2].Visible = false;
                gridBookList.Columns[2].Name = "BookBarcodeID";

                List<BookBarcode> data = BookBL.GetBookBarcodeByBookID(book.BookID);
                if (data != null)
                {
                    int i = 0;
                    int count = data.Count;
                    while (count > 0)
                    {
                        gridBookList.Rows.Add(i, data[i].Barcode.ToString(), data[i].BookBarcodeID.ToString());
                        i++;
                        count--;
                    }
                }
                else
                {
                    gridBookList.DataSource = null;
                    gridBookList.AutoGenerateColumns = false;
                    gridBookList.Refresh();
                }
            }
        }

        public void bindbookDetailsOnControls()
        {
            if (book.IsRestricted == true)
            {
                comboBoxtype.SelectedText = "Restricted";
            }
            else
            {
                comboBoxtype.SelectedText = "Non-Restricted";
            }

            comboBoxSubCategry.SelectedText = book.Category;
            txtbookName.Text = book.Name;
            txtAuthor.Text = book.Author.ToString();
            txtEdition.Text = book.Edition;
            txtPublisher.Text = book.Publisher.ToString();
            txtISBN.Text = book.Isbn;
            txtISBN.ReadOnly = true;
            txtFound.Text = book.Funds;
            txtPrice.Text = book.Price.ToString();
            cmboxLanguage.Text = book.Language;
            richtextDescription.Text = book.Description.ToString();
            lblnoofcopy.Text = book.TotalQuantity.ToString();
            bookID = book.BookID;
            lblnoofcopy.Visible = true;
        }

        public void bindLanguage()
        {
            try
            {
                List<MOD.Language> languages = new List<MOD.Language>();
                languages = LanguageBL.Get(-1);
                if (languages != null)
                {
                    cmboxLanguage.DataSource = languages;
                    cmboxLanguage.ValueMember = "LanguageID";
                    cmboxLanguage.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void bindCategory()
        {
            try
            {
                List<Category> categories = new List<Category>();
                categories = CategoryBL.Get();
                if (categories != null)
                {
                    Category category = new Category();
                    category.CategoryID = 0;
                    category.Name = "Select";
                    categories.Insert(0, category);

                    comboBoxcategory.DataSource = categories;
                    comboBoxcategory.ValueMember = "CategoryID";
                    comboBoxcategory.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Author data = null;
            ManageAuthor.frmAddAuthor addAuthor = new ManageAuthor.frmAddAuthor(data);
            addAuthor.Show();
        }

        private void txtAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAuthor.Text == null || txtAuthor.Text == "")
                {
                    authorObj = null;
                    GlobalVariable.GlobalAuthorObj = null;
                    Search_Control.frmSearchAuthor frmSearchAuthor = new Search_Control.frmSearchAuthor();
                    frmSearchAuthor.ShowDialog();
                    authorObj = GlobalVariable.GlobalAuthorObj;
                    if (authorObj != null)
                    {
                        txtAuthor.Text = authorObj.Name;
                    }
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtbookName.Focus();
            }
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            Publisher data = null;
            ManagePublisher.frmAddPublisher addPublisher = new ManagePublisher.frmAddPublisher(data);
            addPublisher.Show();
        }

        private void txtPublisher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPublisher.Text == null || txtPublisher.Text == "")
                {
                    publisherObj = null;
                    GlobalVariable.GlobalPublisherObj = null;
                    Search_Control.frmSearchPublisher frmSearchPublisher = new Search_Control.frmSearchPublisher();
                    frmSearchPublisher.ShowDialog();
                    publisherObj = GlobalVariable.GlobalPublisherObj;
                    if (publisherObj != null)
                    {
                        txtPublisher.Text = publisherObj.Name;
                    }
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtEdition.Focus();
            }
        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbookName_Leave(object sender, EventArgs e)
        {
            txtbookName.BackColor = Color.White;
            txtbookName.ForeColor = Color.Black;
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtPrice.BackColor = Color.White;
            txtPrice.ForeColor = Color.Black;
        }

        private void txtAuthor_Leave(object sender, EventArgs e)
        {
            txtAuthor.BackColor = Color.White;
            txtAuthor.ForeColor = Color.Black;
        }

        private void txtPublisher_Leave(object sender, EventArgs e)
        {
            txtPublisher.BackColor = Color.White;
            txtPublisher.ForeColor = Color.Black;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addbarodecopy_Click(object sender, EventArgs e)
        {
            lblnoofcopies.Visible = true;
            txtnoofCopy.Visible = true;
            dataGridAddmorecopy.Visible = true;
        }

        private void txtnoofCopy_TextChanged(object sender, EventArgs e)
        {
            btnPrint.Visible = true;
            string isRestricted = comboBoxtype.Text;
            string barcode = string.Empty;

            if (book != null)
            {
                if (!string.IsNullOrEmpty(txtnoofCopy.Text))
                {
                    int totalBookCopies = Convert.ToInt32(txtnoofCopy.Text);
                    if (isRestricted == "Restricted")
                    {
                        barcode = BookBL.GetBarcode(true);
                    }
                    else
                    {
                        barcode = BookBL.GetBarcode(false);
                    }

                    dataGridAddmorecopy.ColumnCount = 2;
                    dataGridAddmorecopy.Columns[0].Name = "#";
                    dataGridAddmorecopy.Columns[0].Visible = false;
                    dataGridAddmorecopy.Columns[1].Name = "Barcode";
                    dataGridAddmorecopy.Columns[1].Visible = true;

                    dataGridAddmorecopy.Rows.Clear();
                    dataGridAddmorecopy.Visible = true;
                    string[] row = null;
                    for (int i = 1; i <= totalBookCopies; i++)
                    {
                        row = new string[] { i.ToString(), barcode.ToString() };
                        dataGridAddmorecopy.Rows.Add(row);

                        string prefix = barcode.Substring(0, 2);
                        barcode = barcode.Substring(2);

                        int code = Convert.ToInt32(barcode);
                        code += 1;

                        int length = GetIntegerDigitCountString(code);
                        if (length == 1)
                        {
                            barcode = prefix + "00000" + code.ToString();
                        }
                        else if (length == 2)
                        {
                            barcode = prefix + "0000" + code.ToString();
                        }
                        else if (length == 3)
                        {
                            barcode = prefix + "000" + code.ToString();
                        }
                        else if (length == 4)
                        {
                            barcode = prefix + "00" + code.ToString();
                        }
                        else if (length == 5)
                        {
                            barcode = prefix + "0" + code.ToString();
                        }
                    }


                    //int totalBookCopies = Convert.ToInt32(txtnoofCopy.Text);
                    //int barcode = 1;
                    ////int barcode = Convert.ToInt32(BookBL.GetBarcode());

                    //dataGridAddmorecopy.ColumnCount = 3;
                    //dataGridAddmorecopy.Columns[0].Name = "#";
                    //dataGridAddmorecopy.Columns[0].Visible = false;
                    //dataGridAddmorecopy.Columns[1].Name = "Barcode";
                    //dataGridAddmorecopy.Columns[2].Visible = false;
                    //dataGridAddmorecopy.Columns[2].ValueType = typeof(int);
                    //dataGridAddmorecopy.Columns[2].Name = "BookBarcodeID";

                    //dataGridAddmorecopy.Rows.Clear();
                    //string id = "-1";
                    //string[] row = null;
                    //for (int i = 1; i <= totalBookCopies; i++)
                    //{
                    //    row = new string[] { i.ToString(), barcode.ToString(), id };
                    //    dataGridAddmorecopy.Rows.Add(row);
                    //    barcode = barcode + 1;
                    //}
                }
            }
        }

        private void btnSaveBarcode_Click(object sender, EventArgs e)
        {
            if (txtbookName.Text != string.Empty && txtAuthor.Text != string.Empty && txtPublisher.Text != string.Empty && cmboxLanguage.Text != string.Empty)
            {
                saveBookBarcode();
            }
            else
            {
                if (cmboxLanguage.Text == string.Empty)
                {
                    cmboxLanguage.BackColor = Color.Red;
                    cmboxLanguage.ForeColor = Color.White;
                    cmboxLanguage.Focus();
                }
                if (txtPrice.Text == string.Empty)
                {
                    txtPrice.BackColor = Color.Red;
                    txtPrice.ForeColor = Color.White;
                    txtPrice.Focus();
                }
                if (txtPublisher.Text == string.Empty)
                {
                    txtPublisher.BackColor = Color.Red;
                    txtPublisher.ForeColor = Color.White;
                    txtPublisher.Focus();
                }
                if (txtAuthor.Text == string.Empty)
                {
                    txtAuthor.BackColor = Color.Red;
                    txtAuthor.ForeColor = Color.White;
                    txtAuthor.Focus();
                }
                if (txtbookName.Text == string.Empty)
                {
                    txtbookName.BackColor = Color.Red;
                    txtbookName.ForeColor = Color.White;
                    txtbookName.Focus();
                }
            }
        }

        private void saveBookBarcode()
        {
            if (MessageBox.Show("Do you want to save the  Book ?", "Done ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int authorID = -1;
                int publisherID = -1;
                int categoryID = -1;
                bool isRestrict;
                if (bookID != -1)
                {
                    if (book.Author == txtAuthor.Text)
                    {
                        authorID = book.AuthorID;
                    }
                    else
                    {
                        authorID = authorObj.AuthorID;
                    }
                    if (book.Publisher == txtPublisher.Text)
                    {
                        publisherID = book.PublisherID;
                    }
                    else
                    {
                        publisherID = publisherObj.PublisherID;
                    }
                    if (book.Category == comboBoxSubCategry.Text)
                    {
                        categoryID = book.CategoryID;
                    }
                    else
                    {
                        categoryID = Convert.ToInt32(comboBoxSubCategry.SelectedValue);
                    }

                    if (comboBoxtype.Text == "Restricted")
                    {
                        isRestrict = true;
                    }
                    else
                    {
                        isRestrict = false;
                    }

                    List<BookBarcode> bookBarcodes = new List<BookBarcode>();
                    for (int i = 0; i < dataGridAddmorecopy.Rows.Count - 1; i++)
                    {
                        BookBarcode bookBarcode = new BookBarcode()
                        {
                            BookBarcodeID = -1,
                            Barcode = dataGridAddmorecopy.Rows[i].Cells["Barcode"].Value.ToString()
                        };

                        bookBarcodes.Add(bookBarcode);
                    }
                    int Count = bookBarcodes.Count + Convert.ToInt32(lblnoofcopy.Text);
                    Book bookobj = new Book
                    {
                        Name = txtbookName.Text,
                        Isbn = txtISBN.Text,
                        Edition = txtEdition.Text,
                        Price = Convert.ToDecimal(txtPrice.Text),
                        TotalQuantity = Count,
                        LanguageID = Convert.ToInt32(cmboxLanguage.SelectedValue),
                        Description = richtextDescription.Text,
                        CategoryID = categoryID,
                        Funds = txtFound.Text,
                        IsRestricted = isRestrict,
                        AuthorID = authorID,
                        PublisherID = publisherID,
                        UserID = userID,
                        BookBarcodes = bookBarcodes
                    };
                    try
                    {
                        Book obj = BookBL.Save(bookobj, bookID);
                        MessageBox.Show("Book Details Update successfully.", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            Language.frmAddLanguage addLanguage = new Language.frmAddLanguage();
            addLanguage.Show();
        }

        private void comboBoxcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(comboBoxcategory.SelectedIndex.ToString());

            if (index > 0)
            {
                try
                {
                    int parentID = Convert.ToInt32(comboBoxcategory.SelectedIndex.ToString());
                    List<Category> categories = new List<Category>();
                    categories = CategoryBL.Get(-1, parentID);
                    if (categories != null)
                    {
                        comboBoxSubCategry.DataSource = categories;
                        comboBoxSubCategry.ValueMember = "CategoryID";
                        comboBoxSubCategry.DisplayMember = "Name";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                comboBoxSubCategry.DataSource = null;
            }
        }

        //Fing the integer value/charector length
        static int GetIntegerDigitCountString(int value)
        {
            return value.ToString().Length;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportDataSource rs = new ReportDataSource();
            List<BookBarcode> barcodes = new List<BookBarcode>();
            barcodes.Clear();

            for (int i = 0; i < dataGridAddmorecopy.Rows.Count-1; i++)
            {
                string prefix = "*";
                BookBarcode barcode = new BookBarcode
                {
                    Barcode = string.Concat(prefix, dataGridAddmorecopy.Rows[i].Cells[1].Value.ToString(), prefix)
                };
                barcodes.Add(barcode);
            }
            rs.Name = "DataSet1";
            rs.Value = barcodes;
            frmBarcodePrint frmBarcodePrint = new frmBarcodePrint();
            frmBarcodePrint.reportViewer1.LocalReport.DataSources.Clear();
            frmBarcodePrint.reportViewer1.LocalReport.DataSources.Add(rs);
            frmBarcodePrint.reportViewer1.LocalReport.ReportPath = Application.StartupPath + "/RptBarcode.rdlc";

            PageSettings pg = new PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;

            PaperSize size = new PaperSize("Custom", 192, 92);
            size.RawKind = (int)PaperKind.Custom;
            pg.PaperSize = size;
            pg.Landscape = false;
            frmBarcodePrint.reportViewer1.SetPageSettings(pg);
            frmBarcodePrint.ShowDialog();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
