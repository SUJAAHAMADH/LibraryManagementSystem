using LMS.BL;
using LMS.MOD;
using System;
using System.Windows.Forms;

namespace LMS.WIN.Forms.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty && txtpassword.Text == string.Empty && string.IsNullOrEmpty(cbrole.Text) && cbrole.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter login details", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MOD.Login login = new MOD.Login()
                {
                    UserName = txtUserName.Text,
                    Password = txtpassword.Text,
                    Role = cbrole.Text
                };

                User user = AuthBL.LoginValidateUser(login);
                if (user == null)
                {
                    MessageBox.Show("Invalid Login");
                }
                else
                {
                    if (cbrole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (user != null)
                        {
                            if (user.UserID > 0)
                            {
                                GlobalVariable.GlobalUserID = Convert.ToInt32(user.UserID);
                                frmDashboard ds = new frmDashboard();
                                ds.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login");
                            }
                        }

                    }
                    else if (cbrole.SelectedItem.ToString() == "LIBRARIAN")
                    {
                        if (user != null)
                        {
                            if (user.UserID > 0)
                            {
                                GlobalVariable.GlobalUserID = Convert.ToInt32(user.UserID);
                                frmDashboard ds = new frmDashboard();
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Caps()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lblWarning.Text = "Caps Lock On";
                lblWarning.Visible = true;
                lblWarning.ForeColor = System.Drawing.Color.GreenYellow;
            }
            else
            {
                lblWarning.Visible = false;
 
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            Caps();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtpassword.Text = string.Empty;
            cbrole.SelectedIndex = -1;
            txtUserName.Focus();

        }
    }
}
