using LMS.BL;
using LMS.MOD;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageJournal
{
    public partial class ViewJournalDetails : Form
    {
        Journal journal = new Journal();
        public ViewJournalDetails(Journal journalOBJ)
        {
            InitializeComponent();
            journal = journalOBJ;
        }

        private void ViewJournalDetails_Load(object sender, EventArgs e)
        {
            if (journal != null)
            {
                bindJournalBarcodeList();
                lbljournalname.Text = string.Empty;
                lbljournalname.Text = journal.JournalName;
            }
        }

        private void bindJournalBarcodeList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<Journal> data = null;
            data = JournalBL.Get();
            if (data != null)
            {
                dataGridBookHistory.AutoGenerateColumns = false;
                dataGridBookHistory.DataSource = data;
                dataGridBookHistory.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Journal details not found....!");
                //dataGridBookHistory.Visible = false;
                dataGridBookHistory.DataSource = null;
                dataGridBookHistory.AutoGenerateColumns = false;
                dataGridBookHistory.Refresh();
            }
        }

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string searchValue = txtSearch.Text;
            bindJournalBarcodeList(searchValue);
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            
        }
    }
}
