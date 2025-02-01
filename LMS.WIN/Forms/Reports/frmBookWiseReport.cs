using LMS.BL;
using LMS.DAL.Shared;
using LMS.MOD;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace LMS.WIN.Forms.Reports
{
    public partial class frmBookWiseReport : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        Book bookObj = null;
        public frmBookWiseReport()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtBookName.Text = string.Empty;
            txtFound.Text = string.Empty;
            bindBookList(null);
        }

        private void FrmBookWiseReport_Load(object sender, EventArgs e)
        {
            bindBookList(null);
        }

        private void bindBookList(string name)
        {
            //string searchValue = txtBookName.Text;
            List<Book> data = null;
            data = BookBL.Get(-1, -1, -1, null);
            if (data != null)
            {
                dataGridBook.AutoGenerateColumns = false;
                dataGridBook.DataSource = data;
                dataGridBook.Refresh();
                getGridviewByDefaultDesign();
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

        private void TxtBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bookObj = null;
                GlobalVariable.GlobalBookObj = null;
                Search_Control.frmSearchBook frmSearchBook = new Search_Control.frmSearchBook();
                frmSearchBook.ShowDialog();
                bookObj = GlobalVariable.GlobalBookObj;
                if (bookObj != null)
                {
                    txtBookName.Text = bookObj.Name;
                    List<Book> data = ReportBL.GetBookWiseReport(-1, -1, -1, Convert.ToInt32(bookObj.BookID), txtFound.Text);
                    if (data != null)
                    {
                        dataGridBook.AutoGenerateColumns = false;
                        dataGridBook.DataSource = data;
                        dataGridBook.Refresh();
                        getGridviewByDefaultDesign();
                    }
                    else
                    {
                        MessageBox.Show("data not found");
                        dataGridBook.DataSource = null;
                        dataGridBook.AutoGenerateColumns = false;
                        dataGridBook.Refresh();
                    }
                }
            }
        }

        private void TxtFound_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bookObj = null;
                GlobalVariable.GlobalBookObj = null;
                Search_Control.frmSearchFund frmSearchFund = new Search_Control.frmSearchFund();
                frmSearchFund.ShowDialog();
                bookObj = GlobalVariable.GlobalBookObj;
                if (bookObj != null)
                {
                    txtFound.Text = bookObj.Funds;
                    List<Book> data = ReportBL.GetBookWiseReport(-1, -1, -1, Convert.ToInt32(bookObj.BookID), txtFound.Text);
                    if (data != null)
                    {
                        dataGridBook.AutoGenerateColumns = false;
                        dataGridBook.DataSource = data;
                        dataGridBook.Refresh();
                        getGridviewByDefaultDesign();
                    }
                    else
                    {
                        MessageBox.Show("data not found");
                        dataGridBook.DataSource = null;
                        dataGridBook.AutoGenerateColumns = false;
                        dataGridBook.Refresh();
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            int boookID = -1;
            if (bookObj != null)
            {
                boookID = Convert.ToInt32(bookObj.BookID);
            }
           
            SqlConnection con = null;
            #region Candidate-details
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Client-Deatils";

            #region Interacting with database
            con = SqlConnectionHelper.GetConnectionSync();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "ShowBook",
                CommandType = CommandType.StoredProcedure,
                Connection = con
            };
            cmd.Parameters.Clear();
            if (!string.IsNullOrEmpty(txtFound.Text))
            {
                cmd.Parameters.Add("@Funds", SqlDbType.VarChar).Value = txtFound.Text;
            }
            if (!string.IsNullOrEmpty(txtBookName.Text))
            {
                cmd.Parameters.Add("@SearchValue", SqlDbType.VarChar).Value = txtBookName.Text;
            }
           
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();
            adp.Fill(dt);
            #endregion


            worksheet.Cells[1, 1] = "SR";
            worksheet.Cells[1, 2] = "Book Name                                        ";
            worksheet.Cells[1, 3] = "Edition          ";
            worksheet.Cells[1, 4] = "Author                     ";
            worksheet.Cells[1, 5] = "Publisher                    ";
            worksheet.Cells[1, 6] = "Language          ";
            worksheet.Cells[1, 7] = "Category                                        ";
            worksheet.Cells[1, 8] = "ISBN          ";
            worksheet.Cells[1, 9] = "Price";
            worksheet.Cells[1, 10] = "Total Quantity";
            worksheet.Cells[1, 11] = "Funds";
            worksheet.Cells[1, 12] = "Is Restricted";
            worksheet.Cells[1, 13] = "Description                                        ";

            #region Wrap data
            if (dt.Rows.Count > 0)
            {
                int sr = 1;
                int i = 2;
                foreach (DataRow row in dt.Rows)
                {
                    bool isRestricted = Convert.ToBoolean(row["IsRestricted"].ToString());

                    string bookType = null;
                    if(isRestricted == true)
                    {
                        bookType = "Restricted";
                    }
                    else
                    {
                        bookType = "Not-Restricted";
                    }

                    worksheet.Cells[i, 1] = sr;
                    worksheet.Cells[i, 2] = row["Name"] as string ?? string.Empty;
                    worksheet.Cells[i, 3] = row["Edition"] as string ?? string.Empty;
                    worksheet.Cells[i, 4] = row["Author"] as string ?? string.Empty;
                    worksheet.Cells[i, 5] = row["Publisher"] as string ?? string.Empty;
                    worksheet.Cells[i, 6] = row["Language"] as string ?? string.Empty;
                    worksheet.Cells[i, 7] = row["Category"] as string ?? string.Empty;
                    worksheet.Cells[i, 8] = row["ISBN"] as string ?? string.Empty;
                    worksheet.Cells[i, 9] = row["Price"] as decimal? ?? 0;
                    worksheet.Cells[i, 10] = row["TotalQuantity"] as int? ?? 0;
                    worksheet.Cells[i, 11] = row["Funds"] as string ?? string.Empty;
                    worksheet.Cells[i, 12] = bookType;
                    worksheet.Cells[i, 13] = row["Description"] as string ?? string.Empty;
                    i = i + 1;
                    sr = sr + 1;
                }
            }
            #endregion
            worksheet.Columns.AutoFit();
            Range rng = worksheet.get_Range("A1:N1", Missing.Value);
            rng.Interior.Color = XlRgbColor.rgbLightBlue;

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Book-Report";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
            MessageBox.Show("Excel successfully created");
            #endregion
        }

        //private void TxtBookName_TextChanged(object sender, EventArgs e)
        //{
        //    List<Book> data = null;
        //    data = ReportBL.GetBookWiseReport(-1, -1, -1, Convert.ToInt32(bookObj.BookID), txtFound.Text);
        //    if (data != null)
        //    {
        //        dataGridBook.AutoGenerateColumns = false;
        //        dataGridBook.DataSource = data;
        //        dataGridBook.Refresh();
        //        getGridviewByDefaultDesign();
        //    }
        //    else
        //    {
        //        MessageBox.Show("data not found");
        //        dataGridBook.DataSource = null;
        //        dataGridBook.AutoGenerateColumns = false;
        //        dataGridBook.Refresh();
        //    }
        //}

        //private void TxtFound_TextChanged(object sender, EventArgs e)
        //{
        //    List<Book> data = null;
        //    data = ReportBL.GetBookWiseReport(-1, -1, -1, Convert.ToInt32(bookObj.BookID), txtFound.Text);
        //    if (data != null)
        //    {
        //        dataGridBook.AutoGenerateColumns = false;
        //        dataGridBook.DataSource = data;
        //        dataGridBook.Refresh();
        //        getGridviewByDefaultDesign();
        //    }
        //    else
        //    {
        //        MessageBox.Show("data not found");
        //        dataGridBook.DataSource = null;
        //        dataGridBook.AutoGenerateColumns = false;
        //        dataGridBook.Refresh();
        //    }
        //}
    }
}
