using LMS.BL;
using LMS.MOD;
using System;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageVolume
{
    public partial class AddVolume : Form
    {
        private Journal _journal;
        public AddVolume(Journal journal)
        {
            InitializeComponent();
            _journal = journal;
        }
        private void Clear()
        {
            tbVolumeNo.Text = "";
            tbIssueNo.Text = "";
            tbRemark.Text = "";
            cbMonths.SelectedIndex = -1;
            tbVolumeNo.Focus();
        }
        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(tbVolumeNo.Text))
            {
                MessageBox.Show("Please enter Volume No.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbVolumeNo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbIssueNo.Text))
            {
                MessageBox.Show("Please enter Issue No.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbIssueNo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbMonths.Text))
            {
                MessageBox.Show("Please select a Month.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMonths.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbRemark.Text))
            {
                MessageBox.Show("Please enter a Remark.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRemark.Focus();
                return false;
            }

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            var result = MessageBox.Show("Do you want to save the Volume?",
                                          "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                Volume volume = new Volume
                {
                    VolumeNo = tbVolumeNo.Text.Trim(),
                    IssueNo = tbIssueNo.Text.Trim(),
                    Month = cbMonths.SelectedItem.ToString(),
                    Remark = tbRemark.Text.Trim(),
                    JournalID = _journal.ID
                };

                volume = VolumeBL.Save(volume, -1);

                MessageBox.Show($"Volume saved successfully. Volume No: {volume.VolumeNo}",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the Volume. Error: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddVolume_Load(object sender, EventArgs e)
        {
            if (_journal != null)
            {
                lblJName.Text = _journal.JournalName;
            }
        }
    }
}
