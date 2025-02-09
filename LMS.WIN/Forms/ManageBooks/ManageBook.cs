using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class ManageBook : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);

        public ManageBook()
        {
            InitializeComponent();
        }

        private void ManageBook_Load(object sender, EventArgs e)
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

        private void btnAddbook_Click(object sender, EventArgs e)
        {
            frmAddbook addbook = new frmAddbook();
            addbook.Show();
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

            else if (dataGridBook.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Do you want to Delete the  Author ?", " Author / Master ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataGridViewRow dgvRow = dataGridBook.CurrentRow;
                    Book book = new Book
                    {
                        BookID = Convert.ToInt32(dgvRow.Cells["BookID"].Value.ToString()),
                        UserID = userID,
                    };
                    book = BookBL.Deactive(book);

                    MessageBox.Show("Book Delete successfully.");
                    bindBookList();
                }
            }

            else if (dataGridBook.Columns[e.ColumnIndex].Name == "Edit")
            {
                Book book = new Book();
                book = (Book)dataGridBook.CurrentRow.DataBoundItem;
                frmEditbook frmeditbook = new frmEditbook(book);
                frmeditbook.Show();
            }
        }

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            bindBookList();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                MOD.Language language = null;
                Publisher publisher = null;
                Author author = null;
                Category category = null;

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files(.xls)|*.xls| Excel Files(.xlsx)| *.xlsx";
                openFileDialog.ShowDialog();
                string fileName = openFileDialog.FileName;

                System.Data.DataTable dt = Utill.ImportExcel.ImportExcelData(fileName);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Book book = new Book();
                    bool isRestricted = false;
                    if (dt.Rows[i]["Type"].ToString() == "Restricted")
                    {
                        isRestricted = true;
                    }

                    //For Publisher
                    if (dt.Rows[i]["Publisher"].ToString() != null && dt.Rows[i]["Publisher"].ToString() != "")
                    {
                        publisher = PublisherBL.GetByName(dt.Rows[i]["Publisher"].ToString(), userID);
                    }
                    else
                    {
                        publisher.PublisherID = -1;
                    }

                    //For Language
                    if (dt.Rows[i]["Language"].ToString() != null && dt.Rows[i]["Language"].ToString() != "")
                    {
                        language = LanguageBL.GetByName(dt.Rows[i]["Language"].ToString(), userID);
                    }
                    else
                    {
                        language.LanguageID = -1;
                    }

                    //For Author
                    if (dt.Rows[i]["Author"].ToString() != null && dt.Rows[i]["Author"].ToString() != "")
                    {
                        author = AuthorBL.GetByName(dt.Rows[i]["Author"].ToString(), userID);
                    }
                    else
                    {
                        author.AuthorID = -1;
                    }

                    //For Category
                    if (dt.Rows[i]["Category"].ToString() != null && dt.Rows[i]["Category"].ToString() != "")
                    {
                        category = CategoryBL.GetByName(dt.Rows[i]["Category"].ToString(), userID);
                    }
                    else
                    {
                        category.CategoryID = -1;
                    }

                    #region Start Barcode Generating Code 
                    string barcode = null;
                    List<BookBarcode> bookBarcodes = new List<BookBarcode>();
                    if (!string.IsNullOrEmpty(dt.Rows[i]["Total Quantity"].ToString()))
                    {
                        int totalBookCopies = Convert.ToInt32(dt.Rows[i]["Total Quantity"].ToString());
                        if (isRestricted == true)
                        {
                            barcode = BookBL.GetBarcode(true);
                        }
                        else
                        {
                            barcode = BookBL.GetBarcode(false);
                        }

                        BookBarcode b = new BookBarcode();
                        b.BookBarcodeID = -1;
                        b.Barcode = barcode;
                        bookBarcodes.Add(b);

                        string[] row = null;
                        for (int j = 1; j < totalBookCopies; j++)
                        {
                            row = new string[] { j.ToString(), barcode };
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

                            BookBarcode bookBarcode = new BookBarcode();
                            bookBarcode.BookBarcodeID = -1;
                            bookBarcode.Barcode = barcode;
                            bookBarcodes.Add(bookBarcode);
                        }
                    }
                    #endregion

                    book.BookID = -1;
                    book.Name = dt.Rows[i]["Name"].ToString();
                    book.Edition = dt.Rows[i]["Edition"].ToString();
                    book.Funds = dt.Rows[i]["Funds"].ToString();
                    book.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                    book.Isbn = dt.Rows[i]["ISBN"].ToString();
                    book.IsRestricted = isRestricted;
                    book.TotalQuantity = Convert.ToInt32(dt.Rows[i]["Total Quantity"].ToString());
                    book.PublisherID = publisher.PublisherID;
                    book.AuthorID = author.AuthorID;
                    book.LanguageID = language.LanguageID;
                    book.CategoryID = category.CategoryID;
                    book.UserID = userID;
                    book.BookBarcodes = bookBarcodes;

                    BookBL.Save(book);
                }
                MessageBox.Show("Book Details Saved successfully...!");
                bindBookList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //try
            //{
            //    OpenFileDialog openFileDialog = new OpenFileDialog();
            //    openFileDialog.Filter = "Excel Files(.xls)|*.xls| Excel Files(.xlsx)| *.xlsx";
            //    openFileDialog.ShowDialog();
            //    string fileName = openFileDialog.FileName;
            //    System.Data.DataTable dt = Utill.ImportExcel.ImportExcelData(fileName);

            //    MOD.Language language = null;
            //    Publisher publisher = null;
            //    Author author = null;
            //    Category category = null;


            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        bool isRestricted = false;
            //        if (dt.Rows[i]["Is Restricted"].ToString() == "Restricted")
            //        {
            //            isRestricted = true;
            //        }

            //        //For Publisher
            //        if (dt.Rows[i]["Publisher                    "].ToString() != null && dt.Rows[i]["Publisher                    "].ToString() != "")
            //        {
            //            publisher = PublisherBL.GetByName(dt.Rows[i]["Publisher                    "].ToString(), userID);
            //        }
            //        else
            //        {
            //            publisher.PublisherID = -1;
            //        }

            //        //For Language
            //        if (dt.Rows[i]["Language          "].ToString() != null && dt.Rows[i]["Language          "].ToString() != "")
            //        {
            //            language = LanguageBL.GetByName(dt.Rows[i]["Language          "].ToString(), userID);
            //        }
            //        else
            //        {
            //            language.LanguageID = -1;
            //        }

            //        //For Author
            //        if (dt.Rows[i]["Author                     "].ToString() != null && dt.Rows[i]["Author                     "].ToString() != "")
            //        {
            //            author = AuthorBL.GetByName(dt.Rows[i]["Author                     "].ToString(), userID);
            //        }
            //        else
            //        {
            //            author.AuthorID = -1;
            //        }

            //        //For Category
            //        if (dt.Rows[i]["Category                                        "].ToString() != null && dt.Rows[i]["Category                                        "].ToString() != "")
            //        {
            //            category = CategoryBL.GetByName(dt.Rows[i]["Category                                        "].ToString(), userID);
            //        }
            //        else
            //        {
            //            category.CategoryID = -1;
            //        }

            //        Book book = new Book();
            //        book.BookID = -1;
            //        book.Name = dt.Rows[i]["Book Name                                        "].ToString();
            //        book.AuthorID = author.AuthorID;
            //        book.PublisherID = publisher.PublisherID;
            //        book.LanguageID = language.LanguageID;
            //        book.CategoryID = category.CategoryID;
            //        book.Edition = dt.Rows[i]["Edition          "].ToString();
            //        book.Funds = dt.Rows[i]["Funds"].ToString();
            //        book.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
            //        book.Isbn = dt.Rows[i]["ISBN          "].ToString();
            //        book.IsRestricted = isRestricted;
            //        book.TotalQuantity = Convert.ToInt32(dt.Rows[i]["Total Quantity"].ToString());
            //        book.UserID = userID;

            //        #region Start Barcode Generating Code 
            //        List<BookBarcode> bookBarcodes = new List<BookBarcode>();
            //        BookBarcode bookBarcode = new BookBarcode();
            //        if (!string.IsNullOrEmpty(dt.Rows[i]["Total Quantity"].ToString()))
            //        {
            //            int totalBookCopies = Convert.ToInt32(dt.Rows[i]["Total Quantity"].ToString());
            //            if (isRestricted == true)
            //            {
            //                bookBarcode.Barcode = BookBL.GetBarcode(true);
            //                bookBarcode.BookBarcodeID = -1;
            //            }
            //            else
            //            {
            //                bookBarcode.Barcode = BookBL.GetBarcode(false);
            //                bookBarcode.BookBarcodeID = -1;
            //            }

            //            string[] row = null;
            //            for (int j = 1; j <= totalBookCopies; j++)
            //            {
            //                row = new string[] { j.ToString(), bookBarcode.Barcode.ToString() };


            //                string prefix = bookBarcode.Barcode.Substring(0, 2);
            //                bookBarcode.Barcode = bookBarcode.Barcode.Substring(2);

            //                int code = Convert.ToInt32(bookBarcode.Barcode);
            //                code += 1;

            //                int length = GetIntegerDigitCountString(code);
            //                if (length == 1)
            //                {
            //                    bookBarcode.Barcode = prefix + "00000" + code.ToString();
            //                }
            //                else if (length == 2)
            //                {
            //                    bookBarcode.Barcode = prefix + "0000" + code.ToString();
            //                }
            //                else if (length == 3)
            //                {
            //                    bookBarcode.Barcode = prefix + "000" + code.ToString();
            //                }
            //                else if (length == 4)
            //                {
            //                    bookBarcode.Barcode = prefix + "00" + code.ToString();
            //                }
            //                else if (length == 5)
            //                {
            //                    bookBarcode.Barcode = prefix + "0" + code.ToString();
            //                }
            //                bookBarcodes.Add(bookBarcode);
            //            }
            //            book.BookBarcodes = bookBarcodes;
            //        }

            //        #endregion
            //        BookBL.Save(book);
            //    }

            //    MessageBox.Show("Book Detail Import Successfully...!");
            //    bindBookList();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        static int GetIntegerDigitCountString(int value)
        {
            return value.ToString().Length;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bindBookList();
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            frmAddbook addbook = new frmAddbook();
            addbook.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MOD.Language language = null;
                Publisher publisher = null;
                Author author = null;
                Category category = null;

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files(.xls)|*.xls| Excel Files(.xlsx)| *.xlsx";
                openFileDialog.ShowDialog();
                string fileName = openFileDialog.FileName;

                System.Data.DataTable dt = Utill.ImportExcel.ImportExcelData(fileName);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Book book = new Book();
                    bool isRestricted = false;
                    if (dt.Rows[i]["Type"].ToString() == "Restricted")
                    {
                        isRestricted = true;
                    }

                    //For Publisher
                    if (dt.Rows[i]["Publisher"].ToString() != null && dt.Rows[i]["Publisher"].ToString() != "")
                    {
                        publisher = PublisherBL.GetByName(dt.Rows[i]["Publisher"].ToString(), userID);
                    }
                    else
                    {
                        publisher.PublisherID = -1;
                    }

                    //For Language
                    if (dt.Rows[i]["Language"].ToString() != null && dt.Rows[i]["Language"].ToString() != "")
                    {
                        language = LanguageBL.GetByName(dt.Rows[i]["Language"].ToString(), userID);
                    }
                    else
                    {
                        language.LanguageID = -1;
                    }

                    //For Author
                    if (dt.Rows[i]["Author"].ToString() != null && dt.Rows[i]["Author"].ToString() != "")
                    {
                        author = AuthorBL.GetByName(dt.Rows[i]["Author"].ToString(), userID);
                    }
                    else
                    {
                        author.AuthorID = -1;
                    }

                    //For Category
                    if (dt.Rows[i]["Category"].ToString() != null && dt.Rows[i]["Category"].ToString() != "")
                    {
                        category = CategoryBL.GetByName(dt.Rows[i]["Category"].ToString(), userID);
                    }
                    else
                    {
                        category.CategoryID = -1;
                    }

                    #region Start Barcode Generating Code 
                    string barcode = null;
                    List<BookBarcode> bookBarcodes = new List<BookBarcode>();
                    if (!string.IsNullOrEmpty(dt.Rows[i]["Total Quantity"].ToString()))
                    {
                        int totalBookCopies = Convert.ToInt32(dt.Rows[i]["Total Quantity"].ToString());
                        if (isRestricted == true)
                        {
                            barcode = BookBL.GetBarcode(true);
                        }
                        else
                        {
                            barcode = BookBL.GetBarcode(false);
                        }

                        BookBarcode b = new BookBarcode();
                        b.BookBarcodeID = -1;
                        b.Barcode = barcode;
                        bookBarcodes.Add(b);

                        string[] row = null;
                        for (int j = 1; j < totalBookCopies; j++)
                        {
                            row = new string[] { j.ToString(), barcode };
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

                            BookBarcode bookBarcode = new BookBarcode();
                            bookBarcode.BookBarcodeID = -1;
                            bookBarcode.Barcode = barcode;
                            bookBarcodes.Add(bookBarcode);
                        }
                    }
                    #endregion

                    book.BookID = -1;
                    book.Name = dt.Rows[i]["Name"].ToString();
                    book.Edition = dt.Rows[i]["Edition"].ToString();
                    book.Funds = dt.Rows[i]["Funds"].ToString();
                    book.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                    book.Isbn = dt.Rows[i]["ISBN"].ToString();
                    book.IsRestricted = isRestricted;
                    book.TotalQuantity = Convert.ToInt32(dt.Rows[i]["Total Quantity"].ToString());
                    book.PublisherID = publisher.PublisherID;
                    book.AuthorID = author.AuthorID;
                    book.LanguageID = language.LanguageID;
                    book.CategoryID = category.CategoryID;
                    book.UserID = userID;
                    book.BookBarcodes = bookBarcodes;

                    BookBL.Save(book);
                }
                MessageBox.Show("Book Details Saved successfully...!");
                bindBookList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
