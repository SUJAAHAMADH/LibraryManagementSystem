using DocumentFormat.OpenXml.Bibliography;
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

namespace LMS.WIN.Forms.ManageJournal
{
    public partial class AddJournal : Form
    {
        public AddJournal()
        {
            InitializeComponent();
        }

        Journal journal = null;

        private void Clear()
        {
            tbJName.Text = "";
            tbFrequency.Text = "";
            tbPrice.Text = "";
            tbInvoiceNo.Text = "";
            dtpIDATE.Value = DateTime.Now;
            tbOrderNo.Text = "";
            tbLanguage.Text = "";
            tbVolume.Text = "";
            tbIssue.Text = "";
            tbMonth.Text = "";
            tbRemark.Text = "";
            tbJName.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
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

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate Journal Name
            if (string.IsNullOrEmpty(tbJName.Text))
            {
                MessageBox.Show("Journal Name cannot be empty. Please fill in the Journal Name.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm Save Action
            DialogResult result = MessageBox.Show("Do you want to save the journal?",
                                                  "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                // Create Journal Object
                Journal journal = new Journal
                {
                    JournalName = tbJName.Text,
                    Frequency = int.TryParse(tbFrequency.Text, out int frequency) ? frequency : 0,
                    Price = decimal.TryParse(tbPrice.Text, out decimal price) ? price : 0,
                    InvoiceNo = tbInvoiceNo.Text,
                    OrderDate = dtpIDATE.Value,
                    OrderNo = tbOrderNo.Text,
                    LanguageID = int.TryParse(tbLanguage.Text, out int languageID) ? languageID : 0,
                    VolumeNo = tbVolume.Text,
                    IssueNo = tbIssue.Text,
                    Month = tbMonth.Text,
                    Remark = tbRemark.Text,
                    IsActive = true
                };

                // Save Journal
                journal = JournalBL.Save(journal, -1);

                MessageBox.Show($"Journal saved successfully. Journal ID: {journal.ID}",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear Fields and Close Form
                Clear();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Journal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
