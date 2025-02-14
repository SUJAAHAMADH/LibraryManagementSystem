using LMS.BL;
using LMS.MOD;
using System;
using System.Windows.Forms;

namespace LMS.WIN.Forms.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public void Caps()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lblWarning.Text = "Caps Lock On";
                lblWarning.Visible = true;
                lblWarning.ForeColor = System.Drawing.Color.FromArgb(235, 175, 41);
            }
            else
            {
                lblWarning.Visible = false;

            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CenterLoginPanel()
        {
       
            panelLogin.Left = (ContentPanel.Width - panelLogin.Width) / 2;
            panelLogin.Top = (ContentPanel.Height - panelLogin.Height) / 2;
        }
        private void CenterImageAndLabel()
        {
            // Centering PictureBox
            pbLogo.Left = (ContentPanel.Width - pbLogo.Width) / 2;
            pbLogo.Top = pbLogo.Top + 50;

            // Centering Label below the PictureBox
            lblLMS.Left = (ContentPanel.Width - lblLMS.Width) / 2;
            lblLMS.Top = pbLogo.Bottom + 10; 
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CenterLoginPanel();
            CenterImageAndLabel();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == string.Empty && tbPassword.Text == string.Empty && string.IsNullOrEmpty(cbRole.Text) && cbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter login details", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MOD.Login login = new MOD.Login()
                {
                    UserName = tbUsername.Text,
                    Password = tbPassword.Text,
                    Role = cbRole.Text
                };

                User user = AuthBL.LoginValidateUser(login);
                if (user == null)
                {
                    MessageBox.Show("Invalid Login");
                }
                else
                {
                    if (cbRole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (user != null)
                        {
                            if (user.UserID > 0)
                            {
                                GlobalVariable.GlobalUserID = Convert.ToInt32(user.UserID);
                                FormMenu ds = new FormMenu();
                                ds.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login");
                            }
                        }

                    }
                    else if (cbRole.SelectedItem.ToString() == "LIBRARIAN")
                    {
                        if (user != null)
                        {
                            if (user.UserID > 0)
                            {
                                GlobalVariable.GlobalUserID = Convert.ToInt32(user.UserID);
                                FormMenu ds = new FormMenu();
                                ds.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login");
                            }
                        }
                    }
                }
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Caps();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            cbRole.SelectedIndex = -1;
            tbUsername.Focus();
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            Caps();
        }
    }
}
