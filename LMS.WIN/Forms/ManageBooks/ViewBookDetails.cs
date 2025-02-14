using LMS.BL;
using LMS.MOD;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class ViewBookDetails : Form
    {
        Book book = new Book();
        public ViewBookDetails(Book bookOBJ)
        {
            InitializeComponent();
            book = bookOBJ;
        }

        private void ViewBookDetails_Load(object sender, EventArgs e)
        {
            if (book != null)
            {
                bindBookBarcodeList();
                lblbokname.Text = string.Empty;
                lblbokname.Text = book.Name;
            }
        }

        private void bindBookBarcodeList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<BookBarcode> data = null;
            data = BookBL.GetBookBarcodeByBookID(book.BookID, searchValue);
            if (data != null)
            {
                dataGridBookHistory.AutoGenerateColumns = false;
                dataGridBookHistory.DataSource = data;
                dataGridBookHistory.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Candidate details not found....!");
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
            dataGridBookHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridBookHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindBookBarcodeList(searchValue);
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            List<BookBarcode> barcodes = BookBL.GetBookBarcodeByBookID(book.BookID, txtSearch.Text);
            if (barcodes == null)
            {
                MessageBox.Show("Barcodes not found.");
                return;
            }
            List<BookBarcode> list = new List<BookBarcode>();
            ReportDataSource rs = new ReportDataSource();
            
            for (int i = 0; i < barcodes.Count; i++)
            {
                string prefix = "*";
                BookBarcode barcode = new BookBarcode
                {
                    Barcode = string.Concat(prefix, barcodes[i].Barcode, prefix)
                };
                list.Add(barcode);
            }
            rs.Name = "DataSet1";
            rs.Value = list;
            frmBarcodePrint frmBarcodePrint = new frmBarcodePrint();
            frmBarcodePrint.reportViewer1.LocalReport.DataSources.Clear();
            frmBarcodePrint.reportViewer1.LocalReport.DataSources.Add(rs);
            string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\"));
            frmBarcodePrint.reportViewer1.LocalReport.ReportPath = projectRoot + @"Forms\ManageBooks\RptBarcode.rdlc";

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
    }
}
