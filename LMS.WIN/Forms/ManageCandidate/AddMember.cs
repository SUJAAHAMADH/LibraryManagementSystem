using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using LMS.BL;
using LMS.MOD;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageCandidate
{
    public partial class AddMember : Form
    {
        Candidate candidate = null;
        int candidateid = -1;
        bool isEdit = false;
        public AddMember(Candidate candidateOBJ)
        {
            InitializeComponent();
            candidate = candidateOBJ;
        }

        
        private void Clear()
        {
            tbRoleId.Text = "";
            tbName.Text = "";
            dtpDOB.Value = DateTime.Now;
            cbStream.Text = "";
            cbPersonType.Text = "";
            tbPreAddress.Text = "";
            tbPerAddress.Text = "";
            tbPContact.Text = "";
            tbSContact.Text = "";
            tbEmail.Text = "";
            tbYear.Text = "";
            pbPhoto.Image = null;
            cbPersonType.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbPersonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isStudent = cbPersonType.SelectedItem.ToString() == "STUDENT";

            lblRoleID.Text = isStudent ? "Student ID" : "Teacher ID";
            lblDOB.Visible = isStudent;
            dtpDOB.Visible = isStudent;
            lblYear.Visible = isStudent;
            tbYear.Visible = isStudent;
            lblPerAddress.Visible = isStudent;
            tbPerAddress.Visible = isStudent;
            lblPresentAddress.Visible = isStudent;
            tbPreAddress.Visible = isStudent;
            lblEmail.Visible = isStudent;
            tbEmail.Visible = isStudent;
            lblPContact.Visible = isStudent;
            tbPContact.Visible = isStudent;

            // Populate cbStream based on selection
            cbStream.Items.Clear();
            if (isStudent)
            {
                cbStream.Items.Add("UG");
                cbStream.Items.Add("PG");
                lblContactNo.Location = new Point(38, 774);
                tbSContact.Location = new Point(294, 771);

            }
            else // Teacher selected
            {
                cbStream.Items.Add("Anatomy");
                cbStream.Items.Add("Physiology");
                cbStream.Items.Add("Ortho");
                cbStream.Items.Add("Biochemistry");
                cbStream.Items.Add("Pharmacology");

                lblContactNo.Location = new Point(38, 356);
                tbSContact.Location = new Point(294, 353);
            }

            cbStream.SelectedIndex = 0; 
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            String imagelocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagelocation = dialog.FileName;
                pbPhoto.ImageLocation = imagelocation;
            }
            else
            {
                MessageBox.Show("No Image Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.White;
            btnSave.ForeColor = Color.FromArgb(2, 56, 129);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(2, 56, 129);
            btnSave.FlatAppearance.BorderSize = 3;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.FromArgb(2, 56, 129);
            btnSave.ForeColor = Color.White;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(2, 56, 129);
            btnClear.ForeColor = Color.White;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.FromArgb(2, 56, 129);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(2, 56, 129);
            btnSave.FlatAppearance.BorderSize = 3;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbPersonType_Validating(object sender, CancelEventArgs e)
        {
            if (cbPersonType.SelectedIndex == -1)
            {

                errorProvider1.SetError(cbPersonType, "Please select a person type");
            }
            else
            {

                errorProvider1.SetError(cbPersonType, null);
            }
        }

        private void tbRoleId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRoleId.Text))
            {

                errorProvider1.SetError(tbRoleId, "Please Enter a Role ID");
            }
            else
            {

                errorProvider1.SetError(tbRoleId, null);
            }
        }

        private void tbRoleId_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tbRoleId, "Enter the Role ID");
        }

        private void cbPersonType_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(cbPersonType, "Select the Person Type");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbRoleId.Text))
            {
                MessageBox.Show("Role ID cannot be empty. Please fill in the Role ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isMemberExist = CandidateBL.ValidateMemberId(tbRoleId.Text);
            if (isMemberExist && !isEdit)
            {
                MessageBox.Show("Role ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbName.Text != string.Empty)
            {
                if (MessageBox.Show("Do you want to save the candidate?", "Done?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Candidate candidates = new Candidate();
                    byte[] photoData = null;

                    if (pbPhoto.Image != null)
                    {
                        using (var ms = new System.IO.MemoryStream())
                        {
                            pbPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); 
                            photoData = ms.ToArray();
                        }
                    }

                    if (cbPersonType.Text == "STUDENT")
                    {
                        int academicYear;
                        candidates = new Candidate
                        {
                            Name = tbName.Text,
                            ContactNumber = tbSContact.Text,
                            RoleID = tbRoleId.Text,
                            Role = cbPersonType.Text,
                            DOB = dtpDOB.Checked ? dtpDOB.Value : (DateTime?)null,
                            Stream = string.IsNullOrEmpty(cbStream.Text) ? null : cbStream.Text,
                            AcademicYear = !string.IsNullOrEmpty(tbYear.Text) && int.TryParse(tbYear.Text, out academicYear) ? academicYear : (int?)null, // Nullable int
                            PermanentAddress = string.IsNullOrEmpty(tbPerAddress.Text) ? null : tbPerAddress.Text,
                            PresentAddress = string.IsNullOrEmpty(tbPreAddress.Text) ? null : tbPreAddress.Text,
                            Email = string.IsNullOrEmpty(tbEmail.Text) ? null : tbEmail.Text,
                            ParentsContact = string.IsNullOrEmpty(tbPContact.Text) ? null : tbPContact.Text,
                            Photo = photoData,
                            CandidateID = candidateid
                        };
                    }
                    else if (cbPersonType.Text == "TEACHER")
                    {
                        candidates = new Candidate
                        {
                            Name = tbName.Text,
                            ContactNumber = tbSContact.Text,
                            RoleID = tbRoleId.Text, 
                            Stream = cbStream.Text,
                            Role = cbPersonType.Text,
                            Photo = photoData, 
                        };
                    }

                    try
                    {
                        candidate = CandidateBL.Save(candidates, candidateid);

                        MessageBox.Show($"Member saved successfully. Member ID: {candidate.RoleID}", "Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            if (candidate.CandidateID != 0)
            {
                tbName.Text = candidate.Name;
                tbSContact.Text = candidate.ContactNumber;
                tbRoleId.Text = candidate.RoleID;
                cbPersonType.Text = candidate.Role;
                if(candidate.DOB != null)  dtpDOB.Value = (DateTime)candidate.DOB;
                cbStream.Text = candidate.Stream;
                tbYear.Text = candidate.AcademicYear.ToString();
                tbPerAddress.Text = candidate.PermanentAddress;
                tbPreAddress.Text = candidate.PresentAddress;
                tbEmail.Text = candidate.Email;
                tbPContact.Text = candidate.ParentsContact;
                tbRoleId.ReadOnly = true;
                tbRoleId.Enabled = false;
                cbPersonType.Enabled = false;
                candidateid = candidate.CandidateID;
                var data = CandidateBL.GetByID(candidateid);
                if (data.Photo != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream(data.Photo))
                    {
                        // Convert MemoryStream to Image
                        Image image = Image.FromStream(memoryStream);

                        // Display the image in the PictureBox
                        pbPhoto.Image = image;
                    }
                }

                isEdit = true;

            }
        }
    }
}
