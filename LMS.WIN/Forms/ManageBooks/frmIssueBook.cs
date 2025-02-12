using LMS.BL;
using LMS.MOD;
using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using MANTRA;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class frmIssueBook : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        Candidate candidateDetail = null;
        BookDetail bookDetail = null;

        SqlConnection con = new SqlConnection();
        SqlDataAdapter tempadp;
        DataSet tempds = new DataSet();

        MFS100 mfs100 = null;
        int quality = 60;
        int timeout = 10000;
        string datapath = Application.StartupPath + "\\FingerData";
        byte[] ISOTemplate = null;
        byte[] ANSITemplate = null;
        byte[] Temp = null;
        DeviceInfo deviceInfo = null;
        string key = "";

        public frmIssueBook()
        {
            InitializeComponent();
        }

        public void clearBookRecord()
        {
            txtbookname.Text = string.Empty;
            txtType.Text = string.Empty;
            txtSubCategory.Text = string.Empty;
            txtPublisher.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtLanguage.Text = string.Empty;
        }

        private void frmIssueBook_Load(object sender, EventArgs e)
        {
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["LMS"].ToString();
            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //}

            dtReturnDate.Format = DateTimePickerFormat.Custom;
            dtReturnDate.CustomFormat = "dd-MM-yyyy";
            dtReturnDate.Value = DateTime.Today.AddDays(7);

            dtIssuedDate.Format = DateTimePickerFormat.Custom;
            dtIssuedDate.CustomFormat = "dd-MM-yyyy";

            //Control.CheckForIllegalCrossThreadCalls = false;
            //resetControl();
            //mfs100 = new MFS100(key);
            //mfs100.OnCaptureCompleted += OnCaptureCompleted;
            //try
            //{
            //    if (!Directory.Exists(datapath))
            //    {
            //        Directory.CreateDirectory(datapath);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //try
            //{
            //    int ret = mfs100.Init();
            //    if (ret != 0)
            //    {
            //        // MessageBox.Show(mfs100.GetErrorMsg(ret));
            //    }
            //    else
            //    {
            //        deviceInfo = mfs100.GetDeviceInfo();
            //        if (deviceInfo != null)
            //        {
            //            string scannerInfo = "SERIAL NO.: " + deviceInfo.SerialNo + "     MAKE: " + deviceInfo.Make + "     MODEL: " + deviceInfo.Model + "\nWIDTH: " + deviceInfo.Width.ToString() + "     HEIGHT: " + deviceInfo.Height.ToString() + "     CERT: " + mfs100.GetCertification();
            //            //lblSerial.Text = scannerInfo;
            //        }
            //        else
            //        {
            //            //lblSerial.Text = "";
            //        }
            //        //MessageBox.Show(mfs100.GetErrorMsg(ret));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    GC.Collect();
            //}
        }

        private void txtCandidate_KeyDown(object sender, KeyEventArgs e)
        {
            picThumb.Image = null;
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCandidate.Text == null || txtCandidate.Text == "")
                {
                    candidateDetail = null;
                    GlobalVariable.GlobalCandidateObj = null;
                    Search_Control.frmSearchCandidate searchCandidate = new Search_Control.frmSearchCandidate();
                    searchCandidate.ShowDialog();
                    candidateDetail = GlobalVariable.GlobalCandidateObj;
                    if (candidateDetail != null)
                    {
                        groupBoxCandidateDetails.Visible = true;
                        txtCandidate.Text = candidateDetail.Name;
                        txtSerialNo.Text = candidateDetail.RoleID;
                        lblContactNo.Text = string.Empty;
                       // lblRank.Text = string.Empty;
                        lblRole.Text = string.Empty;
                       // lblUnit.Text = string.Empty;
                        lblName.Text = candidateDetail.Name;
                        lblContactNo.Text = candidateDetail.ContactNumber;
                      //  lblRank.Text = candidateDetail.Rank;
                        lblRole.Text = candidateDetail.Role;
                      //  lblUnit.Text = candidateDetail.Unit;
                        //txtCountry.Text = candidateDetail.CountryName;
                        txtBarcodeSearch.Text = candidateDetail.Barcode;
                    }
                    else
                    {
                        txtBarcodeSearch.Text = string.Empty;
                        picThumb.Image = null;
                        groupBoxCandidateDetails.Visible = false;
                    }
                }
            }
        }

        private void txtUID_KeyDown(object sender, KeyEventArgs e)
        {
            picThumb.Image = null;
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSerialNo.Text == null || txtSerialNo.Text == string.Empty)
                {
                    candidateDetail = null;
                    GlobalVariable.GlobalCandidateObj = null;
                    Search_Control.frmSearchByUID searchCandidate = new Search_Control.frmSearchByUID();
                    searchCandidate.ShowDialog();
                    candidateDetail = GlobalVariable.GlobalCandidateObj;
                    if (candidateDetail != null)
                    {
                        groupBoxCandidateDetails.Visible = true;
                        txtCandidate.Text = candidateDetail.Name;
                        txtSerialNo.Text = candidateDetail.RoleID;
                        lblContactNo.Text = string.Empty;
                       // lblRank.Text = string.Empty;
                        lblRole.Text = string.Empty;
                        //lblUnit.Text = string.Empty;
                        lblName.Text = candidateDetail.Name;
                        lblContactNo.Text = candidateDetail.ContactNumber;
                       // lblRank.Text = candidateDetail.Rank;
                        lblRole.Text = candidateDetail.Role;
                       // lblUnit.Text = candidateDetail.Unit;
                       // txtCountry.Text = candidateDetail.CountryName;
                        txtBarcodeSearch.Text = candidateDetail.Barcode;
                    }
                    else
                    {
                        txtBarcodeSearch.Text = string.Empty;
                        picThumb.Image = null;
                        groupBoxCandidateDetails.Visible = false;
                    }
                }
            }
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
                    bool status;
                    string isRestrict;
                    status = BookBL.CheckAvailableBookBarcode(bookDetail.BookBarcodeID);
                    if (status == true)
                    {
                        if (bookDetail != null)
                        {
                            if (bookDetail.IsRestricted == true)
                            {
                                isRestrict = "Restricted";

                            }
                            else
                            {
                                isRestrict = "Non - Restricted";
                            }
                            groupBoxbookDetails.Visible = true;
                            txtAuthor.Text = bookDetail.Author;
                            txtPublisher.Text = bookDetail.Publisher;
                            txtSubCategory.Text = bookDetail.Category;
                            txtLanguage.Text = bookDetail.Language;
                            txtbookname.Text = bookDetail.Name;
                            txtType.Text = isRestrict;
                        }
                        else
                        {
                            groupBoxbookDetails.Visible = false;
                            clearBookRecord();
                        }
                    }
                    else
                    {
                        clearBookRecord();
                        MessageBox.Show("Book of this barcode is alrady given to some one.");
                    }
                }
                else
                {
                    clearBookRecord();
                    MessageBox.Show("Book details not found.");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bookDetail.IsRestricted == true /*&& txtCountry.Text != "INDIA"*/)
            {
                MessageBox.Show("This book is restricted so you can not issue this book...!");
                return;
            }

            DateTime dt = DateTime.ParseExact(dtIssuedDate.Text, "dd-MM-yyyy", null);

            if (txtBarcode.Text != string.Empty && txtCandidate.Text != string.Empty || txtSerialNo.Text != string.Empty)
            {
                if (MessageBox.Show("Do you want to Issue the Book ?", "Done ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        IssueBook issueBook = new IssueBook
                        {
                            IssueBookID = -1,
                            BookBarcodeID = bookDetail.BookBarcodeID,
                            CandidateID = candidateDetail.CandidateID,
                            IssuedOn = DateTime.ParseExact(dtIssuedDate.Text, "dd-MM-yyyy", null),
                            ReturnDate = DateTime.ParseExact(dtReturnDate.Text, "dd-MM-yyyy", null),
                            Remark = richtextRemark.Text,
                            UserID = userID,
                        };
                        var daysDifference = (issueBook?.ReturnDate - issueBook?.IssuedOn)?.Days;
                        List<IssueBook> issuedBooksForCandidate = IssueBookBL.GetIssueBook(-1, -1, candidateDetail.CandidateID, null, null, null, null);



                        if (candidateDetail.Role == "STUDENT")
                        {
                            if (candidateDetail.Stream == "UG" && (daysDifference == null || daysDifference > 10) && (issuedBooksForCandidate == null || issuedBooksForCandidate.Count <= 2 ))
                            {
                                MessageBox.Show("Cannot Issue books for More than 10 Days and Maximum 3 Books can be issued for UG Students", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Close();
                                return;
                            }
                            if (candidateDetail.Stream == "PG" && (daysDifference == null || daysDifference > 20) && (issuedBooksForCandidate == null || issuedBooksForCandidate.Count <= 3))
                            {
                                MessageBox.Show("Cannot Issue books for More than 20 Days and Maximum 3 Books can be issued for PG Students", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Close();
                                return;
                            }
                        }
                        else if (candidateDetail.Role == "NON-TEACHER")
                        {
                            if (daysDifference == null || daysDifference > 10 && (issuedBooksForCandidate == null || issuedBooksForCandidate.Count <= 2))
                            {
                                MessageBox.Show("Cannot Issue books for More than 10 Days and Maximum 3 Books can be issued for Non Teachers", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Close();
                                return;
                            }
                        }
              
                        issueBook = IssueBookBL.SaveIssueBook(issueBook);
                        MessageBox.Show("Book Issued successfully.", "Issued Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                       

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Issued Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }

        void OnCaptureCompleted(bool status, int errorCode, string errorMsg, FingerData fingerprintData)
        {
            try
            {
                if (status)
                {
                    groupBoxCandidateDetails.Visible = true;
                    picThumb.Image = fingerprintData.FingerImage;
                    picThumb.Refresh();
                    File.WriteAllBytes(datapath + "//ISOTemplate.iso", fingerprintData.ISOTemplate);
                    Temp = fingerprintData.ISOTemplate;
                    FigMatch();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        void FigMatch()
        {
            try
            {
                groupBoxbookDetails.Visible = true;
                tempadp = new SqlDataAdapter("SELECT * FROM Candidate", con);
                tempadp.Fill(tempds);
                int score = 0;
                int MatchThreshold = 1400;
                if (tempds.Tables[0].Rows.Count > 0)
                {
                    Convert.ToBase64String(Temp);
                    for (int i = 0; i < tempds.Tables[0].Rows.Count; i++)
                    {
                        byte[] bytes = new byte[Convert.FromBase64String(tempds.Tables[0].Rows[i]["ThumbImpression"].ToString()).Length];
                        bytes = Convert.FromBase64String(tempds.Tables[0].Rows[i]["ThumbImpression"].ToString());
                        int candidateID = Convert.ToInt32(tempds.Tables[0].Rows[i]["CandidateID"].ToString());

                        int rets = mfs100.MatchISO(bytes, Temp, ref score);
                        if (score >= MatchThreshold)
                        {
                            candidateDetail = CandidateBL.GetByID(candidateID);
                            if (candidateDetail != null)
                            {
                                txtCandidate.Text = candidateDetail.Name;
                                txtSerialNo.Text = candidateDetail.RoleID;
                                lblContactNo.Text = string.Empty;
                                //lblRank.Text = string.Empty;
                                //txtCountry.Text = string.Empty;
                                lblName.Text = candidateDetail.Name;
                                lblContactNo.Text = candidateDetail.ContactNumber;
                                //lblRank.Text = candidateDetail.Rank;
                                //lblUnit.Text = candidateDetail.Unit;
                                lblRole.Text = candidateDetail.Role;
                               // txtCountry.Text = candidateDetail.CountryName;
                                txtBarcodeSearch.Text = candidateDetail.Barcode;

                            }
                            //MessageBox.Show("Finger matched with score: " + score.ToString());
                            return;
                        }
                    }
                    //MessageBox.Show("Finger not matched, score: " + score.ToString() + " is too low");
                    MessageBox.Show("Finger not matched");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        bool setQuality()
        {
            try
            {
                quality = Convert.ToInt32(55);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Quality Value");
            }
            finally
            {
                GC.Collect();
            }
            return false;
        }

        bool setTimeout()
        {
            try
            {
                timeout = Convert.ToInt32(10000);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Timeout Value");
            }
            finally
            {
                GC.Collect();
            }
            return false;
        }

        void resetControl()
        {
            picThumb.Image = null;
        }

        private void BtnCapture_Click_1(object sender, EventArgs e)
        {
            ClearCandidateDetails();
            try
            {
                resetControl();
                ISOTemplate = null;
                ANSITemplate = null;
                if (setQuality() == false)
                {
                    return;
                }
                if (setTimeout() == false)
                {
                    return;
                }
                int ret = mfs100.StartCapture(quality, timeout, true);
                if (ret != 0)
                {
                    MessageBox.Show(mfs100.GetErrorMsg(ret));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ClearCandidateDetails()
        {
            lblName.Text = string.Empty;
            lblContactNo.Text = string.Empty;
            //lblRank.Text = string.Empty;
            lblRole.Text = string.Empty;
            //lblUnit.Text = string.Empty;
            //txtCountry.Text = string.Empty;
            txtCandidate.Text = string.Empty;
            txtSerialNo.Text = string.Empty;
            txtBarcodeSearch.Text = string.Empty;
        }

        private void txtBarcodeSearch_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtBarcodeSearch_KeyDown(object sender, KeyEventArgs e)
        {
            picThumb.Image = null;
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBarcodeSearch.Text != null && txtBarcodeSearch.Text != "" && txtBarcodeSearch.Text != string.Empty)
                {
                    candidateDetail = null;
                    candidateDetail = CandidateBL.GetCandidateByBarcode(txtBarcodeSearch.Text);
                    if (candidateDetail != null)
                    {
                        groupBoxCandidateDetails.Visible = true;
                        txtCandidate.Text = candidateDetail.Name;
                        txtSerialNo.Text = candidateDetail.RoleID;
                        lblContactNo.Text = string.Empty;
                        //lblRank.Text = string.Empty;
                        lblRole.Text = string.Empty;
                      //  lblUnit.Text = string.Empty;
                        txtBarcodeSearch.Text = string.Empty;
                        lblName.Text = candidateDetail.Name;
                        lblContactNo.Text = candidateDetail.ContactNumber;
                        //lblRank.Text = candidateDetail.Rank;
                        lblRole.Text = candidateDetail.Role;
                        //lblUnit.Text = candidateDetail.Unit;
                       // txtCountry.Text = candidateDetail.CountryName;
                        txtBarcodeSearch.Text = candidateDetail.Barcode;
                    }
                    else
                    {
                        txtCandidate.Text = string.Empty;
                        txtSerialNo.Text = string.Empty;
                        lblName.Text = string.Empty;
                        lblContactNo.Text = string.Empty;
                       // lblRank.Text = string.Empty;
                        lblRole.Text = string.Empty;
                       // lblUnit.Text = string.Empty;
                       // txtCountry.Text = string.Empty;
                        picThumb.Image = null;
                        MessageBox.Show("Details not found.");
                        //groupBoxCandidateDetails.Visible = false;
                    }
                }
            }
        }
    }
}
