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

namespace LMS.WIN.Forms.ManageSubject
{
    public partial class AddSubject : Form
    {
  
        private Subject _subject;
        public AddSubject(Subject subject)
        {
            InitializeComponent();
            _subject = subject;
        }
        private void Clear()
        {
           tbSubject.Text = "";
           tbSubject.Focus();

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
            if (string.IsNullOrWhiteSpace(tbSubject.Text))
            {
                tbSubject.BackColor = Color.Red;
                tbSubject.ForeColor = Color.White;
                tbSubject.Focus();
                return;
            }

            if (MessageBox.Show("Do You Want To Save the Subject?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    Subject subject = new Subject
                    {
                        SubjectID = _subject?.SubjectID ?? 0, // Use 0 for new subjects
                        Name = tbSubject.Text.Trim(),
                        IsActive = true
                    };

                    if (_subject == null)
                    {
                        subject = SubjectBL.Save(subject);
                        MessageBox.Show("Subject Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        subject = SubjectBL.Update(subject);
                        MessageBox.Show("Subject Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
            if (_subject != null)
            {
                tbSubject.Text = _subject.Name;
            }
        }


    }
}
