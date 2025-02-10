using LMS.BL;
using LMS.MOD;
using LMS.WIN.Forms.ManageBooks;
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
            AddJournal addJournal = new AddJournal();
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
            if (dataGridBook.Columns[e.ColumnIndex].Name == "View")
            {
                DataGridViewRow dgvRow = dataGridBook.CurrentRow;
                Journal journal = new Journal
                {
                    ID = Convert.ToInt32(dgvRow.Cells["ID"].Value.ToString()),
                    JournalName = dgvRow.Cells["JournalName"].Value.ToString(),
                };
                ViewJournalDetails journalDetails = new ViewJournalDetails(journal);
                journalDetails.Show();
            }

            else if (dataGridBook.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Do you want to Delete the Journal ?", " Journal ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataGridViewRow dgvRow = dataGridBook.CurrentRow;
                    Journal journal = new Journal
                    {
                        ID = Convert.ToInt32(dgvRow.Cells["ID"].Value.ToString()),
                    };
                    journal = JournalBL.Deactive(journal);

                    MessageBox.Show("Journal Delete successfully.");
                    bindJournalList();
                }
            }

            else if (dataGridBook.Columns[e.ColumnIndex].Name == "Edit")
            {
                Journal journal = new Journal();
                journal = (Journal)dataGridBook.CurrentRow.DataBoundItem;
                AddJournal addJournal = new AddJournal();
                addJournal.Show();
            }
        }

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            bindJournalList();
        }
    }
}
