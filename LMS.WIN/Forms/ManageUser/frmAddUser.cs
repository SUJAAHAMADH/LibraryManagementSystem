using LMS.BL;
using LMS.MOD;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageUser
{
    public partial class frmAddUser : Form
    {
        User user = new User();
        int userid = -1;
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        public frmAddUser(User userOBJ)
        {
            InitializeComponent();
            user = userOBJ;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                txtFullName.Text = user.Name;
                txtEmail.Text = user.Email;
                txtContactNumber.Text = user.ContactNumber;
                txtUID.Text = user.UID;
                txtUserName.Text = user.UserName;
                txtPassword.Text = user.Password;
                userid = user.UserID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text != string.Empty && txtContactNumber.Text != string.Empty && txtEmail.Text != string.Empty && txtUserName.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                if (MessageBox.Show("Do you want to save the Librarian ?", "Done ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        User user = new User
                        {
                            Name = txtFullName.Text,
                            Email = txtEmail.Text,
                            ContactNumber = txtContactNumber.Text,
                            UID = txtUID.Text,
                            UserName = txtUserName.Text,
                            Password = txtPassword.Text,
                            Role = "LIBRARIAN",
                            UserID = userID,
                        };
                        if (userid > 0)
                        {
                            user = AuthBL.Register(user, userid);
                            MessageBox.Show("Librarian update successfully.", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            user = AuthBL.Register(user);
                            MessageBox.Show("Librarian save successfully.", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtFullName.Text = string.Empty;
                            txtEmail.Text = string.Empty;
                            txtContactNumber.Text = string.Empty;
                            txtUID.Text = string.Empty;
                            txtUserName.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (txtPassword.Text == string.Empty)
                {
                    txtPassword.BackColor = Color.Red;
                    txtPassword.ForeColor = Color.White;
                    txtPassword.Focus();
                }
                if (txtUserName.Text == string.Empty)
                {
                    txtUserName.BackColor = Color.Red;
                    txtUserName.ForeColor = Color.White;
                    txtUserName.Focus();
                }
                if (txtEmail.Text == string.Empty)
                {
                    txtEmail.BackColor = Color.Red;
                    txtEmail.ForeColor = Color.White;
                    txtEmail.Focus();
                }
                if (txtContactNumber.Text == string.Empty)
                {
                    txtContactNumber.BackColor = Color.Red;
                    txtContactNumber.ForeColor = Color.White;
                    txtContactNumber.Focus();
                }
                if (txtFullName.Text == string.Empty)
                {
                    txtFullName.BackColor = Color.Red;
                    txtFullName.ForeColor = Color.White;
                    txtFullName.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            txtFullName.BackColor = Color.White;
            txtFullName.ForeColor = Color.Black;
        }

        private void txtContactNumber_Leave(object sender, EventArgs e)
        {
            txtContactNumber.BackColor = Color.White;
            txtContactNumber.ForeColor = Color.Black;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
            txtEmail.ForeColor = Color.Black;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            txtUserName.BackColor = Color.White;
            txtUserName.ForeColor = Color.Black;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.Black;
        }
    }
}
