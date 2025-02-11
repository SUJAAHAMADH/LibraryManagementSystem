using LMS.BL;
using LMS.MOD;
using LMS.WIN.Forms.ManageBooks;
using LMS.WIN.Forms.ManageCandidate;
using LMS.WIN.Forms.ManageVolume;
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
    public partial class ManageJournal : Form
    {

        public ManageJournal()
        {
            InitializeComponent();
        }

        private void ManageJournal_Load(object sender, EventArgs e)
        {
            bindJournalList();
        }

        private void bindJournalList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<Journal> data = null;
            data = JournalBL.Get(-1,name, -1);
            if (data != null)
            {
                dataGridBook.AutoGenerateColumns = false;
                dataGridBook.DataSource = data;
                dataGridBook.Refresh();
                //getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Journals not found");
                dataGridBook.DataSource = null;
                dataGridBook.AutoGenerateColumns = false;
                dataGridBook.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridBook.ColumnHeadersHeight = 35;
            dataGridBook.BorderStyle = BorderStyle.None;
            dataGridBook.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridBook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridBook.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridBook.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridBook.BackgroundColor = Color.White;
            dataGridBook.EnableHeadersVisualStyles = false;
            dataGridBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnAddNewJournal_Click(object sender, EventArgs e)
        {
            AddJournal addJournal = new AddJournal(null);
            addJournal.ShowDialog();
            bindJournalList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindJournalList(searchValue);
        }

        private void dataGridBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a row is selected
            DataGridViewRow dgvRow = dataGridBook.CurrentRow;
            if (dgvRow == null)
            {
                MessageBox.Show("No row selected.");
                return;
            }

            // Handle "View" column click
            if (dataGridBook.Columns[e.ColumnIndex].Name == "View")
            {
                int id = dgvRow.Cells["ID"].Value == DBNull.Value ? -1 : Convert.ToInt32(dgvRow.Cells["ID"].Value);
                string name = dgvRow.Cells["Name"].Value?.ToString() ?? string.Empty;
                int frequency = dgvRow.Cells["Frequency"].Value == DBNull.Value ? 0 : Convert.ToInt32(dgvRow.Cells["Frequency"].Value);
                decimal price = dgvRow.Cells["Price"].Value == DBNull.Value ? 0.0m : Convert.ToDecimal(dgvRow.Cells["Price"].Value);
                string invoiceNo = dgvRow.Cells["InvoiceNo"].Value?.ToString() ?? string.Empty;
                DateTime invoiceDate = dgvRow.Cells["InvoiceDate"].Value == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dgvRow.Cells["InvoiceDate"].Value);
                string orderNo = dgvRow.Cells["OrderNo"].Value?.ToString() ?? string.Empty;
                int subjectId = dgvRow.Cells["SubjectID"].Value == DBNull.Value ? -1 : Convert.ToInt32(dgvRow.Cells["SubjectID"].Value);

                Journal journal = new Journal
                {
                    ID = id,
                    JournalName = name,
                    Frequency = frequency,
                    Price = price,
                    InvoiceNo = invoiceNo,
                    InvoiceDate = invoiceDate,
                    OrderNo = orderNo,
                    SubjectID = subjectId,
                };

                ViewJournalWithVolume journalDetails = new ViewJournalWithVolume(journal);
                journalDetails.Show();
            }

            // Handle "Delete" column click
            else if (dataGridBook.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Do you want to Delete the Journal?", "Journal?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // Ensure the row is selected before deleting
                    if (dgvRow != null)
                    {
                        Journal journal = new Journal
                        {
                            ID = Convert.ToInt32(dgvRow.Cells["ID"].Value)
                        };
                        journal = JournalBL.Deactive(journal);

                        MessageBox.Show("Journal deleted successfully.");
                        bindJournalList();
                    }
                }
            }

            else if (dataGridBook.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (dgvRow != null)
                {
                    int id = dgvRow.Cells["ID"].Value == DBNull.Value ? -1 : Convert.ToInt32(dgvRow.Cells["ID"].Value);
                    string name = dgvRow.Cells["Name"].Value?.ToString() ?? string.Empty;
                    int frequency = dgvRow.Cells["Frequency"].Value == DBNull.Value ? 0 : Convert.ToInt32(dgvRow.Cells["Frequency"].Value);
                    decimal price = dgvRow.Cells["Price"].Value == DBNull.Value ? 0.0m : Convert.ToDecimal(dgvRow.Cells["Price"].Value);
                    string invoiceNo = dgvRow.Cells["InvoiceNo"].Value?.ToString() ?? string.Empty;
                    DateTime invoiceDate = dgvRow.Cells["InvoiceDate"].Value == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dgvRow.Cells["InvoiceDate"].Value);
                    string orderNo = dgvRow.Cells["OrderNo"].Value?.ToString() ?? string.Empty;
                    int subjectId = dgvRow.Cells["SubjectID"].Value == DBNull.Value ? -1 : Convert.ToInt32(dgvRow.Cells["SubjectID"].Value);

                    Journal journal = new Journal
                    {
                        ID = id,
                        JournalName = name,
                        Frequency = frequency,
                        Price = price,
                        InvoiceNo = invoiceNo,
                        InvoiceDate = invoiceDate,
                        OrderNo = orderNo,
                        SubjectID = subjectId,
                    };
                    AddJournal addJournal = new AddJournal(journal);
                    addJournal.ShowDialog();
                    bindJournalList();
                }
            }

            // Handle "Volume" column click
            else if (dataGridBook.Columns[e.ColumnIndex].Name == "Volume")
            {
                if (dgvRow != null)
                {
                    Journal journal = new Journal
                    {
                        ID = Convert.ToInt32(dgvRow.Cells["ID"].Value),
                        JournalName = dgvRow.Cells["Name"].Value?.ToString() ?? string.Empty,
                    };

                    // Open the AddVolume form and pass the Journal data
                    AddVolume addVolume = new AddVolume(journal);
                    addVolume.ShowDialog();
                }
            }


        }

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            bindJournalList();
        }

    }
}
