using LMS.BL;
using LMS.MOD;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageCandidate
{
    public partial class ViewCandidateDetails : Form
    {
        Candidate candidate = new Candidate();
        ReportDataSource rs = new ReportDataSource();
        public ViewCandidateDetails(Candidate candidateOBJ)
        {
            InitializeComponent();
            candidate = candidateOBJ;
        }

        private void ViewCandidateDetails_Load(object sender, EventArgs e)
        {
            if (candidate != null)
            {
                lblcandidateName.Text = string.Empty;
                lblunit.Text = string.Empty;
                lblrank.Text = string.Empty;
                lblContactNo.Text = string.Empty;
                lblcandidateName.Text = candidate.Name;
                lblContactNo.Text = candidate.ContactNumber;
                //lblrank.Text = candidate.Rank;
                //lblunit.Text = candidate.Unit;
                lblServiceNo.Text = candidate.ServiceNo;
               // lblCountry.Text = candidate.CountryName;
                lblrole.Text = candidate.Role;
                lblCandidateBarcode.Text = candidate.Barcode;
                //txtBarcode.Text = string.Concat("*",candidate.Barcode, candidate.Name,"*"); 
                //txtBarcode.Text = string.Concat("*", candidate.Barcode, "*");
                txtBarcode.Text = candidate.Barcode;
                txtBarcode.Font = new Font("IDAHC39M Code 39 Barcode", 12, FontStyle.Regular);

                if (candidate.Role == "Student")
                {
                    lblType.Text = "Course Name:";
                    lblFormDate.Text = "    From Date:";
                    lbltoDate.Text = "        To Date:";
                    lbltypebinding.Text = candidate.CourseName;
                    lblFromDateBind.Text = candidate.FromDate;
                    lblToDateBinding.Text = candidate.ToDate;
                }
                else
                {
                 //   lblType.Text = "       Battalion:";
                    lblFormDate.Text = "    TOS Date:";
                    lbltoDate.Text = "     SOS Date:";
                   // lbltypebinding.Text = candidate.Battalion;
                    lblFromDateBind.Text = candidate.TOSDate;
                    lblToDateBinding.Text = candidate.SOSDate;
                }
                bindBookHistoryList();
            }
        }

        private void bindBookHistoryList(string searchValue = null)
        {
            List<BookHistory> data = null;
            data = IssueBookBL.GetBookHistory(-1, -1, candidate.CandidateID, null, searchValue);
            if (data != null)
            {
                dataGridBookHistory.Visible = true;
                dataGridBookHistory.AutoGenerateColumns = false;
                dataGridBookHistory.DataSource = data;
                dataGridBookHistory.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                //MessageBox.Show("Candidate details not found....!");
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

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindBookHistoryList(searchValue);
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBarcode.Text) && !string.IsNullOrEmpty(lblCandidateBarcode.Text))
            {
                //List<Candidate> barcodes = new List<Candidate>();
                List<BookBarcode> barcodes = new List<BookBarcode>();
                barcodes.Clear();

                string barcodeText = null;
                if (!string.IsNullOrEmpty(candidate.Barcode))
                {
                    barcodeText = candidate.Barcode;
                }
                else
                {
                    barcodeText = lblCandidateBarcode.Text;
                }

                string prefix = "*";
                BookBarcode barcode = new BookBarcode
                {
                    Barcode = string.Concat(prefix, barcodeText.ToString(), prefix)
                };
                barcodes.Add(barcode);

                rs.Name = "DataSet1";
                rs.Value = barcodes;

                LMS.WIN.Forms.ManageBooks.frmBarcodePrint frmBarcodePrint = new LMS.WIN.Forms.ManageBooks.frmBarcodePrint();
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
        }
    }
}