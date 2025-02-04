using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageCandidate
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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

        private void Clear()
        {
            tbStudentId.Text = "";
            tbStudentName.Text = "";
            dtpDOB.Value = DateTime.Now;
            cbStream.Text = "";
            tbPreAddress.Text = "";
            tbPerAddress.Text = "";
            tbPContact.Text = "";
            tbSContact.Text = "";
            tbEmail.Text = "";
            tbYear.Text = "";
            pbPhoto.Image = null;
            tbStudentId.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStudentId.Text = "";
            tbStudentName.Text = "";
            dtpDOB.Value = DateTime.Now;
            cbStream.Text = "";
            tbPreAddress.Text = "";
            tbPerAddress.Text = "";
            tbPContact.Text = "";
            tbSContact.Text = "";
            tbEmail.Text = "";
            tbYear.Text = "";
            pbPhoto.Image = null;
            tbStudentId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbStudentId.Text != string.Empty && tbStudentName.Text != string.Empty)
            {
                if (MessageBox.Show("Do you want to save the student?", "Done?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Student student = new Student();
                    byte[] photoData = null;


                    if (pbPhoto.Image != null)
                    {
                        using (var ms = new System.IO.MemoryStream())
                        {
                            pbPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);  // Or the image format you're using
                            photoData = ms.ToArray();
                        }
                    }

     
                    student.StudentID = tbStudentId.Text;
                    student.NameOfStudent = tbStudentName.Text;
                    student.DOB = dtpDOB.Value;
                    student.Stream = cbStream.Text;
                    student.AcademicYear = Convert.ToInt32(tbYear.Text);
                    student.PermanentAddress = tbPerAddress.Text;
                    student.PresentAddress = tbPreAddress.Text;
                    student.Email = tbEmail.Text;
                    student.ParentsContact = tbPContact.Text;
                    student.StudentContact = tbSContact.Text;
                    student.Photo = photoData;

                    try
                    {
                        // Save or update the student
                        student = StudentBL.Save(student, -1);  // Use student ID for update, -1 for new record
                        MessageBox.Show("Student saved successfully.", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
