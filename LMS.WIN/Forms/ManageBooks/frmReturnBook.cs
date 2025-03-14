﻿using LMS.BL;
using LMS.MOD;
using MANTRA;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageBooks
{
    public partial class frmReturnBook : Form
    {
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

        public frmReturnBook()
        {
            InitializeComponent();
        }

        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        IssueBook IssueBook = null;

        public void clearAllRecord()
        {
            dataGridissueBook.DataSource = null;

            txtbookName.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtPublisher.Text = string.Empty;
            txtLanguage.Text = string.Empty;
            txtType.Text = string.Empty;
            txtSubCategory.Text = string.Empty;

            txtName.Text = string.Empty;
            txtContactNumber.Text = string.Empty;
            //txtRank.Text = string.Empty;
            //txtUnit.Text = string.Empty;
            txtRole.Text = string.Empty;
        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["LMS"].ToString();
            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //}
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
            //        }
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
            dtReturnDate.Format = DateTimePickerFormat.Custom;
            dtReturnDate.CustomFormat = "dd-MM-yyyy";
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            picThumb.Image = null;
            clearAllRecord();
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBarcode.Text == string.Empty)
                {
                    MessageBox.Show("Please enter barcode");
                    return;
                }

                IssueBook = IssueBookBL.GetIssueBookByBarcode(txtBarcode.Text);
                if (IssueBook != null)
                {
                    Book book = BookBL.GetByID(IssueBook.BookID);
                    string isRestrict;
                    if (book.IsRestricted == true)
                    {
                        isRestrict = "Restricted";
                    }
                    else
                    {
                        isRestrict = "Non - Restricted";
                    }
                    txtbookName.Text = book.Name;
                    txtAuthor.Text = book.Author;
                    txtPublisher.Text = book.Publisher;
                    txtType.Text = isRestrict;
                    txtSubCategory.Text = book.Category;
                    txtLanguage.Text = book.Language;
                    bindIssueBookList(IssueBook.CandidateID);

                    Candidate candidate = CandidateBL.GetByID(IssueBook.CandidateID);
                    txtName.Text = candidate.Name;
                    txtContactNumber.Text = candidate.ContactNumber;
                    //txtRank.Text = candidate.Rank;
                    //txtUnit.Text = candidate.Unit;
                    txtRole.Text = candidate.Role;
                }
                else
                {
                    dataGridissueBook.DataSource = null;
                    dataGridissueBook.AutoGenerateColumns = false;
                    dataGridissueBook.Refresh();

                    clearAllRecord();
                    MessageBox.Show("You Enterd barcode its not Issued...!");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text != string.Empty)
            {
                if (MessageBox.Show("Do you want to Return the Book...?", "Done ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        IssueBook ReturnBook = new IssueBook
                        {
                            IssueBookID = IssueBook.IssueBookID,
                            BookBarcodeID = IssueBook.BookBarcodeID,
                            CandidateID = IssueBook.CandidateID,
                            //RenewalOn = DateTime.ParseExact(DateTime.Now.ToString(), "dd-mm-yyyy", null),
                            ReturnDate = DateTime.ParseExact(dtReturnDate.Text, "dd-MM-yyyy", null),
                            Remark = richtextRemark.Text,
                            UserID = userID,
                        };
                        ReturnBook = IssueBookBL.SaveReturnBook(ReturnBook, IssueBook.IssueBookID);
                        MessageBox.Show("Book Return successfully.", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindIssueBookList(int candidateID)
        {
            List<IssueBook> data = null;
            data = IssueBookBL.GetIssueBook(-1, -1, candidateID);
            if (data != null)
            {
                dataGridissueBook.AutoGenerateColumns = false;
                dataGridissueBook.DataSource = data;
                dataGridissueBook.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Issued book list not found");
                //dataGridissueBook.Visible = false;
                dataGridissueBook.DataSource = null;
                dataGridissueBook.AutoGenerateColumns = false;
                dataGridissueBook.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridissueBook.ColumnHeadersHeight = 35;
            dataGridissueBook.BorderStyle = BorderStyle.None;
            dataGridissueBook.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridissueBook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridissueBook.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridissueBook.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridissueBook.BackgroundColor = Color.White;
            dataGridissueBook.EnableHeadersVisualStyles = false;
            dataGridissueBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridissueBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridissueBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = string.Empty;
            clearAllRecord();

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

        private void dataGridissueBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridissueBook.Columns[e.ColumnIndex].Name == "Select")
            {
                IssueBook = (IssueBook)dataGridissueBook.CurrentRow.DataBoundItem;
                GetissuebookDetailsCandidateWise(IssueBook.BookID, IssueBook.CandidateID);
                txtBarcode.Text = IssueBook.BookBarcode.ToString();
            }
        }

        public void GetissuebookDetailsCandidateWise(int bookID, int candidateID)
        {
            if (IssueBook != null)
            {
                Book book = BookBL.GetByID(bookID);
                string isRestrict;
                if (book.IsRestricted == true)
                {
                    isRestrict = "Restricted";
                }
                else
                {
                    isRestrict = "Non - Restricted";
                }
                txtbookName.Text = book.Name;
                txtAuthor.Text = book.Author;
                txtPublisher.Text = book.Publisher;
                txtType.Text = isRestrict;
                txtSubCategory.Text = book.Category;
                txtLanguage.Text = book.Language;

                Candidate candidate = CandidateBL.GetByID(candidateID);
                txtName.Text = candidate.Name;
                txtContactNumber.Text = candidate.ContactNumber;
                //txtRank.Text = candidate.Rank;
                //txtUnit.Text = candidate.Unit;
                txtRole.Text = candidate.Role;
            }
            else
            {
                clearAllRecord();
            }
        }

        void OnCaptureCompleted(bool status, int errorCode, string errorMsg, FingerData fingerprintData)
        {
            try
            {
                if (status)
                {
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
                            bindIssueBookList(candidateID);
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
            catch (Exception ex)
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
            catch (Exception ex)
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
            //lblStatus.Text = "";
            picThumb.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
