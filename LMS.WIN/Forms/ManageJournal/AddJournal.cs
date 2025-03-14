﻿using LMS.BL;
using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageJournal
{
    public partial class AddJournal : Form
    {
        private Journal _journal;
        public AddJournal(Journal journal)
        {
            InitializeComponent();
            _journal = journal;
        }


        private void Clear()
        {
            tbJName.Text = "";
            tbFrequency.Text = "";
            tbPrice.Text = "";
            tbInvoiceNo.Text = "";
            dtpIDATE.Value = DateTime.Now;
            tbOrderNo.Text = "";
            cbSubjects.Text = "";
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
            if (string.IsNullOrEmpty(tbJName.Text))
            {
                MessageBox.Show("Journal Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to save the journal?",
                                                  "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                Journal journal = new Journal
                {
                    ID = _journal?.ID ?? -1,  // Keep ID for updates
                    JournalName = tbJName.Text,
                    Frequency = int.TryParse(tbFrequency.Text, out int frequency) ? frequency : 0,
                    Price = decimal.TryParse(tbPrice.Text, out decimal price) ? price : 0,
                    InvoiceNo = tbInvoiceNo.Text,
                    InvoiceDate = dtpIDATE.Value,
                    OrderNo = tbOrderNo.Text,
                    SubjectID = int.TryParse(cbSubjects.SelectedValue.ToString(), out int subjectID) ? subjectID : -1,
                    IsActive = true
                };

                if (_journal == null || _journal.ID == -1)
                    journal = JournalBL.Save(journal, -1);  // Add new journal
                else
                    journal = JournalBL.Update(journal);  // Update existing journal

                MessageBox.Show($"Journal {(journal.ID == -1 ? "saved" : "updated")} successfully.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Journal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubjects()
        {
            try
            {
                using (SqlConnection con = SqlConnectionHelper.GetConnectionSync())
                {
                    string query = "SELECT SubjectID, Name FROM Subjects ORDER BY Name";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adp.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                cbSubjects.DataSource = dt;
                                cbSubjects.DisplayMember = "Name"; 
                                cbSubjects.ValueMember = "SubjectID"; 
                                cbSubjects.SelectedIndex = -1; 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Subjects: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void AddJournal_Load(object sender, EventArgs e)
        {
            LoadSubjects();

            if (_journal != null)
            {
                tbJName.Text = _journal.JournalName;
                tbFrequency.Text = _journal.Frequency.ToString();
                tbPrice.Text = _journal.Price.ToString();
                tbInvoiceNo.Text = _journal.InvoiceNo;
                dtpIDATE.Value = _journal.InvoiceDate == DateTime.MinValue ? DateTime.Now : _journal.InvoiceDate;
                tbOrderNo.Text = _journal.OrderNo;
                cbSubjects.SelectedValue = _journal.SubjectID;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManageSubject.AddSubject frm = new ManageSubject.AddSubject(null);
            frm.ShowDialog();
            LoadSubjects();


        }
    }
}
