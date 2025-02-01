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

namespace LMS.WIN.Forms.ManagePublisher
{
    public partial class frmAddPublisher : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        int publisherID = 0;
        Publisher publisher = new Publisher();
        public frmAddPublisher(Publisher publisherOBJ)
        {
            InitializeComponent();
            publisher = publisherOBJ;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPublisherName.Text != string.Empty)
            {
                if (MessageBox.Show("Do you want to Save the Publisher data ?", "Done ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        Publisher publisher = new Publisher
                        {
                            Name = txtPublisherName.Text,
                            EmailID = txtEmail.Text,
                            ContactNumber = txtContactNumber.Text,
                            AlternateContactNumber = txtAlternatecontact.Text,
                            Address = richtextAddress.Text,
                            UserID = userID
                        };
                        if (publisherID != 0)
                        {
                            publisher = PublisherBL.Save(publisher, publisherID);
                            MessageBox.Show("Publisher update successfully.", "Publisher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            publisher = PublisherBL.Save(publisher);
                            MessageBox.Show("Publisher save successfully.", "Publisher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Publisher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (txtPublisherName.Text == string.Empty)
                {
                    txtPublisherName.BackColor = Color.Red;
                    txtPublisherName.ForeColor = Color.White;
                    txtPublisherName.Focus();
                }
            }
        }

        private void frmAddPublisher_Load(object sender, EventArgs e)
        {
            if (publisher != null)
            {
                txtPublisherName.Text = publisher.Name;
                txtEmail.Text = publisher.EmailID;
                richtextAddress.Text = publisher.Address;
                txtContactNumber.Text = publisher.ContactNumber;
                txtAlternatecontact.Text = publisher.AlternateContactNumber;
                publisherID = publisher.PublisherID;
            }
        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPublisherName_Leave(object sender, EventArgs e)
        {
            txtPublisherName.BackColor = Color.White;
            txtPublisherName.ForeColor = Color.Black;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
            txtEmail.ForeColor = Color.Black;
        }

        private void txtContactNumber_Leave(object sender, EventArgs e)
        {
            txtContactNumber.BackColor = Color.White;
            txtContactNumber.ForeColor = Color.Black;
        }
    }
}
