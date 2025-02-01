using LMS.BL;
using LMS.MOD;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageAuthor
{
    public partial class frmAddAuthor : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        int authorID = 0;
        Author author = new Author();
        public frmAddAuthor(Author authorOBJ)
        {
            InitializeComponent();
            author = authorOBJ;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAuthorName.Text != string.Empty)
            {
                if (MessageBox.Show("Do you want to save the Author ?", "Done ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        Author author = new Author
                        {
                            Name = txtAuthorName.Text,
                            Description = richtextDescription.Text,
                            UserID = userID,
                        };
                        if (authorID != 0)
                        {
                            author = AuthorBL.Save(author, authorID);
                            MessageBox.Show("Author update successfully.", "Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //PnlControl.Controls.Clear();
                            //frmDashboard frmDashboard = new frmDashboard();
                            //frmDashboard.TopLevel = false;
                            //PnlControl.Controls.Add(frmDashboard);
                            //frmDashboard.Show();
                            Close();
                        }
                        else
                        {
                            author = AuthorBL.Save(author);
                            MessageBox.Show("Author save successfully.", "Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtAuthorName.Text = string.Empty;
                            richtextDescription.Text = string.Empty;
                            Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Author", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (txtAuthorName.Text == string.Empty)
                {
                    txtAuthorName.BackColor = Color.Red;
                    txtAuthorName.ForeColor = Color.White;
                    txtAuthorName.Focus();
                }
            }
        }

        private void frmAddAuthor_Load(object sender, EventArgs e)
        {
            if (author != null)
            {
                txtAuthorName.Text = author.Name;
                richtextDescription.Text = author.Description;
                authorID = author.AuthorID;
            }
        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAuthorName_Leave(object sender, EventArgs e)
        {
            txtAuthorName.BackColor = Color.White;
            txtAuthorName.ForeColor = Color.Black;
        }
    }
}
