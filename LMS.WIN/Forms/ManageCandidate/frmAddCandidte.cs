using LMS.BL;
using LMS.MOD;
using MANTRA;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageCandidate
{
    public partial class frmAddCandidte : Form
    {
        MFS100 mfs100 = null;
        int quality = 60;
        int timeout = 10000;
        string datapath = Application.StartupPath + "\\FingerData";
        byte[] ISOTemplate = null;
        byte[] ANSITemplate = null;
        DeviceInfo deviceInfo = null;
        string key = "";

        int candidateid = -1;
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        User user = new User();

        Candidate candidate = null;
        Course courseObj = null;
        Country countryObj = null;
        string fig;

        public frmAddCandidte(Candidate candidateOBJ)
        {
            InitializeComponent();
            candidate = candidateOBJ;
        }

        private void frmAddCandidte_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            resetControl();
            mfs100 = new MFS100(key);
            mfs100.OnCaptureCompleted += OnCaptureCompleted;
            try
            {
                if (!Directory.Exists(datapath))
                {
                    Directory.CreateDirectory(datapath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                int ret = mfs100.Init();
                if (ret != 0)
                {
                    //MessageBox.Show(mfs100.GetErrorMsg(ret));
                }
                else
                {
                    deviceInfo = mfs100.GetDeviceInfo();
                    if (deviceInfo != null)
                    {
                        string scannerInfo = "SERIAL NO.: " + deviceInfo.SerialNo + "     MAKE: " + deviceInfo.Make + "     MODEL: " + deviceInfo.Model + "\nWIDTH: " + deviceInfo.Width.ToString() + "     HEIGHT: " + deviceInfo.Height.ToString() + "     CERT: " + mfs100.GetCertification();
                        //lblSerial.Text = scannerInfo;
                    }
                    else
                    {
                        //lblSerial.Text = "";
                    }
                    //MessageBox.Show(mfs100.GetErrorMsg(ret));
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

            if (candidate.CandidateID != 0)
            {
                txtServiceNo.Text = candidate.RoleID;
                txtName.Text = candidate.Name;
                txtContactNumber.Text = candidate.ContactNumber;
                txtCourse.Text = candidate.CourseName;
                cmboxCandidateType.Text = candidate.Role;

               // txtBattalion.Text = candidate.Battalion;
                dtEndDate.Text = candidate.ToDate.ToString();
                dtFormDate.Text = candidate.FromDate.ToString();
                dtTosDate.Text = candidate.TOSDate;
                dtSosDate.Text = candidate.SOSDate;

                candidateid = candidate.CandidateID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (txtServiceNo.Text != string.Empty && txtContactNumber.Text != string.Empty && txtCountry.Text != string.Empty && txtRank.Text != string.Empty && txtUnit.Text != string.Empty)
            if (txtServiceNo.Text != string.Empty && txtContactNumber.Text != string.Empty)
            {
                if (MessageBox.Show("Do you want to save the candidate ?", "Done ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Candidate candidates = new Candidate();
                    int countryID = -1;
                    int courseID = -1;
                    if (candidateid > 0)
                    {
                        if (cmboxCandidateType.Text == "Student")
                        {
                            if (candidate.CourseName == txtCourse.Text)
                            {
                                courseID = candidate.CourseID;
                            }
                            else
                            {
                                courseID = courseObj.CourseID;
                            }

                            candidates = new Candidate
                            {
                                Name = txtName.Text,
                                ContactNumber = txtContactNumber.Text,
                                RoleID = txtServiceNo.Text,
                                Role = cmboxCandidateType.Text,
                                CourseID = courseID,
                                FromDate = dtFormDate.Text,
                                ToDate = dtEndDate.Text,
                                TOSDate = "",
                                SOSDate = "",
                                ThumbImpression = fig,
                                UserID = userID,
                            };

                        }
                        else if (cmboxCandidateType.Text == "Teacher")
                        {
                            candidates = new Candidate
                            {
                                Name = txtName.Text,
                                ContactNumber = txtContactNumber.Text,
                                RoleID = txtServiceNo.Text,
                                Role = cmboxCandidateType.Text,
                                TOSDate = dtTosDate.Text,
                                SOSDate = dtSosDate.Text,
                                FromDate = "",
                                ToDate = "",
                                ThumbImpression = fig,
                                UserID = userID,
                            };

                        }

                        
                        try
                        {
                            candidate = CandidateBL.Save(candidates, candidateid);
                            MessageBox.Show("Candidate Update successfully.", "Candidate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtServiceNo.Text = string.Empty;
                            txtName.Text = string.Empty;
                            txtContactNumber.Text = string.Empty;
                            picThumb.Image = null;
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        if (cmboxCandidateType.Text == "Student")
                        {
                            courseID = Convert.ToInt32(courseObj.CourseID);

                            candidates = new Candidate
                            {
                                Name = txtName.Text,
                                ContactNumber = txtContactNumber.Text,
                                RoleID = txtServiceNo.Text,
                                Role = cmboxCandidateType.Text,
                                CourseID = courseID,
                                FromDate = dtFormDate.Text,
                                ToDate = dtEndDate.Text,
                                ThumbImpression = fig,
                                UserID = userID,
                            };
                        }
                        else if (cmboxCandidateType.Text == "Teacher")
                        {
                            //countryID = Convert.ToInt32(countryObj.CountryID);
                            candidates = new Candidate
                            {
                                Name = txtName.Text,
                                ContactNumber = txtContactNumber.Text,
                                RoleID = txtServiceNo.Text,
                                Role = cmboxCandidateType.Text,
                                TOSDate = dtTosDate.Text,
                                SOSDate = dtSosDate.Text,
                                ThumbImpression = fig,
                                UserID = userID,
                            };
                        }
                        
                        try
                        {
                            candidate = CandidateBL.Save(candidates, -1);
                            MessageBox.Show("Candidate save successfully.", "Candidate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtServiceNo.Text = string.Empty;
                            txtName.Text = string.Empty;
                            txtContactNumber.Text = string.Empty;
                           // txtRank.Text = string.Empty;
                            picThumb.Image = null;
                            Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Candidate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                if (txtServiceNo.Text == string.Empty)
                {
                    txtServiceNo.BackColor = Color.Red;
                    txtServiceNo.ForeColor = Color.White;
                    txtServiceNo.Focus();

                }
                else if (txtName.Text == string.Empty)
                {
                    txtName.BackColor = Color.Red;
                    txtName.ForeColor = Color.White;
                    txtName.Focus();
                }
                else if (txtContactNumber.Text == string.Empty)
                {
                    txtContactNumber.BackColor = Color.Red;
                    txtContactNumber.ForeColor = Color.White;
                    txtContactNumber.Focus();
                }
                //else if (txtRank.Text == string.Empty)
                //{
                //    txtRank.BackColor = Color.Red;
                //    txtRank.ForeColor = Color.White;
                //    txtRank.Focus();
                //}
                //else if (txtUnit.Text == string.Empty)
                //{
                //    txtUnit.BackColor = Color.Red;
                //    txtUnit.ForeColor = Color.White;
                //    txtUnit.Focus();
                //}
                //else if (txtCountry.Text == string.Empty)
                //{
                //    txtCountry.BackColor = Color.Red;
                //    txtCountry.ForeColor = Color.White;
                //    txtCountry.Focus();
                //}
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
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

        void OnCaptureCompleted(bool status, int errorCode, string errorMsg, FingerData fingerprintData)
        {
            try
            {
                if (status)
                {
                    picThumb.Image = fingerprintData.FingerImage;
                    picThumb.Refresh();
                    File.WriteAllBytes(datapath + "//ISOTemplate.iso", fingerprintData.ISOTemplate);
                    fig = Convert.ToBase64String(fingerprintData.ISOTemplate);
                }
                else
                {

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

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            txtServiceNo.BackColor = Color.White;
            txtServiceNo.ForeColor = Color.Black;
        }

        private void txtContactNumber_Leave(object sender, EventArgs e)
        {
            txtContactNumber.BackColor = Color.White;
            txtContactNumber.ForeColor = Color.Black;
        }

        private void cmboxCandidateType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmboxCandidateType.Text == "Student")
            {
                pnlPosted.Visible = false;
                pnlTrainee.Visible = true;
            }
            else if (cmboxCandidateType.Text == "Teacher")
            {
                pnlTrainee.Visible = false;
                pnlPosted.Visible = true;
              //  txtCountry.Text = "INDIA";
            }

        }

        private void txtCountry_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (txtCountry.Text == null || txtCountry.Text == "")
            //    {
            //        {
            //            countryObj = null;
            //            GlobalVariable.GlobalCountryObj = null;
            //            Search_Control.frmSearchCountry frmSearchCountry = new Search_Control.frmSearchCountry();
            //            frmSearchCountry.ShowDialog();
            //            countryObj = GlobalVariable.GlobalCountryObj;
            //            if (countryObj != null)
            //            {
            //                txtCountry.Text = countryObj.Name;
            //                //candidate.CandidateID = countryObj.CountryID;
            //            }
            //        }
            //    }
            //}
        }

        private void txtCourse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCourse.Text == null || txtCourse.Text == "")
                {
                    {
                        courseObj = null;
                        GlobalVariable.GlobalCourseObj = null;
                        Search_Control.frmSearchCourse frmSearchCourse = new Search_Control.frmSearchCourse();
                        frmSearchCourse.ShowDialog();
                        courseObj = GlobalVariable.GlobalCourseObj;
                        if (courseObj != null)
                        {
                            txtCourse.Text = courseObj.Name;
                            dtFormDate.Text = courseObj.FromDate;
                            dtEndDate.Text = courseObj.ToDate;
                        }
                    }
                }
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
            txtName.ForeColor = Color.Black;
        }

        private void txtRank_Leave(object sender, EventArgs e)
        {
            //txtRank.BackColor = Color.White;
            //txtRank.ForeColor = Color.Black;
        }

        private void txtUnit_Leave(object sender, EventArgs e)
        {
            //txtUnit.BackColor = Color.White;
            //txtUnit.ForeColor = Color.Black;
        }

        private void txtCountry_Leave(object sender, EventArgs e)
        {
            //txtCountry.BackColor = Color.White;
            //txtCountry.ForeColor = Color.Black;
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            //if(txtCountry.Text == "INDIA")
            //{
            //    countryObj = null;
            //    Country country = new Country();
            //    country.Name = "INDIA";

            //    country = CountryBL.GetByName(country.Name, -1);

            //    GlobalVariable.GlobalCountryObj = country;
            //    countryObj = GlobalVariable.GlobalCountryObj;
            //    if (countryObj != null)
            //    {
            //        txtCountry.Text = countryObj.Name;
            //    }
            //}
        }
    }
}
