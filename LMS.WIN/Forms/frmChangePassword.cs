using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LMS.WIN.Forms
{
    public partial class frmChangePassword : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);

        public frmChangePassword()
        {
            InitializeComponent();
            cmboxDriveList.DataSource = Environment.GetLogicalDrives();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            bindUserList();
        }

        private void bindUserList()
        {
            //List<User> data = null;
            User data = new User();
            data = UserBL.GetByID(userID);
            if (data != null)
            {
                lableFullName.Text = data.Name;
                labelUserName.Text = data.UserName;
                labelPasssword.Text = data.Password;
                lblEmail.Text = data.Email;
                txtCurrentPassword.Text = data.Password;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtConfirmPassword.Text)
            {
                if (MessageBox.Show("Do you want to change the password ?", "Done ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        ChangePassword changePassword = new ChangePassword
                        {
                            CurrentPassword = txtCurrentPassword.Text,
                            NewPassword = txtNewPassword.Text,
                            UserID = userID,
                        };
                        bool reponse;
                        reponse = AuthBL.ChangePassword(changePassword);
                        if (reponse == true)
                        {
                            MessageBox.Show("Password changed sucsesfully...!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCurrentPassword.Text = string.Empty;
                            txtNewPassword.Text = string.Empty;
                            txtConfirmPassword.Text = string.Empty;
                            bindUserList();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password...!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Check New Password & Confirm Password...!");
            }
        }

        private void cmboxDriveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = cmboxDriveList.SelectedItem.ToString();
            string[] folders = Directory.GetDirectories(path);
            cmboxFolderList.DataSource = folders;
        }

        private void btnSaveBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = DateTime.Now.ToString("yyyyMMddHHmmssfff".ToString());
                string path = cmboxFolderList.SelectedItem.ToString() + "\\";
                AuthBL.SaveBackFileToComputer(path, fileName);
                MessageBox.Show("Backup save in " + path + " with name :" + fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
