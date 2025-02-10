using LMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageSubject
{
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbSubject.Text != string.Empty)
            {
                if (MessageBox.Show("Do You Want To Save the Subject ?", "Done ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        MOD.Subject subject = new MOD.Subject
                        {
                            Name = tbSubject.Text,
                        };
                        subject = SubjectBL.Save(subject);
                        MessageBox.Show("Subject Save successfully.", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbSubject.Text = string.Empty;
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
                if (tbSubject.Text == string.Empty)
                {
                    tbSubject.BackColor = Color.Red;
                    tbSubject.ForeColor = Color.White;
                    tbSubject.Focus();
                }
            }
        }
    }
}
