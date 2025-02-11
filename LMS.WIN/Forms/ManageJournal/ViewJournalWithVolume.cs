using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageJournal
{
    public partial class ViewJournalWithVolume : Form
    {
        private Journal _journal;
        public ViewJournalWithVolume(Journal journal)
        {
            InitializeComponent();
            _journal = journal;
        }

        private void bindVolumeList(string searchValue = null)
        {
            List<Volume> data = VolumeBL.GetByJournal(_journal.ID);

            if (data?.Count > 0) // Simplified null and empty check
            {
                dataGridBookHistory.Visible = true;
                dataGridBookHistory.AutoGenerateColumns = false;
                dataGridBookHistory.DataSource = data;
                dataGridBookHistory.Refresh();
                dataGridBookHistory.Invalidate();  // Ensure the grid is fully updated
                getGridviewByDefaultDesign();
            }
            else
            {
                dataGridBookHistory.DataSource = null;
                dataGridBookHistory.AutoGenerateColumns = false;
                dataGridBookHistory.Refresh();
            }
        }

        // Default GridView design setup
        public void getGridviewByDefaultDesign()
        {
            dataGridBookHistory.ColumnHeadersHeight = 35;
            dataGridBookHistory.BorderStyle = BorderStyle.None;
            dataGridBookHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridBookHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridBookHistory.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridBookHistory.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridBookHistory.BackgroundColor = Color.White;
            dataGridBookHistory.EnableHeadersVisualStyles = false;
            dataGridBookHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridBookHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridBookHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewJournalWithVolume_Load(object sender, EventArgs e)
        {
            if (_journal != null)
            {
                lblJID.Text = _journal.ID.ToString();
                lblJName.Text = _journal.JournalName;
                lblFrequency.Text = _journal.Frequency.ToString();
                lblPrice.Text = _journal.Price.ToString();
                lblInvoiceNo.Text = _journal.InvoiceNo;
                lblInvoiceDate.Text = _journal.InvoiceDate.ToString();
                lblOrderNo.Text = _journal.OrderNo;
                lblSubject.Text = _journal.SubjectID.ToString();
                bindVolumeList();

            }

        }

        private void btnAddVolume_Click(object sender, EventArgs e)
        {
            ManageVolume.AddVolume addVolume = new ManageVolume.AddVolume(_journal);
            addVolume.ShowDialog();
            bindVolumeList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindVolumeList(searchValue);
        }
    }
}
