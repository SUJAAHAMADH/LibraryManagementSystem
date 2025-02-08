using LMS.BL;
using LMS.MOD;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.Language
{
    public partial class frmAddLanguage : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        public frmAddLanguage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLanguage.Text != string.Empty)
            {
                if (MessageBox.Show("Do You Want To Save the Subject ?", "Done ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        MOD.Language language = new MOD.Language
                        {
                            Name = txtLanguage.Text,
                            UserID = userID,
                        };
                        language = LanguageBL.Save(language);
                        MessageBox.Show("Subject Save successfully.", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLanguage.Text = string.Empty;
                        Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (txtLanguage.Text == string.Empty)
                {
                    txtLanguage.BackColor = Color.Red;
                    txtLanguage.ForeColor = Color.White;
                    txtLanguage.Focus();
                }
            }
        }
    }
}
