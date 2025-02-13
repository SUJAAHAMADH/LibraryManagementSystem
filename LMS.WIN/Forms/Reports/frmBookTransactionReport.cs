using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.Reports
{
    public partial class frmBookTransactionReport : Form
    {
        public frmBookTransactionReport()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBookTransactionReport_Load(object sender, EventArgs e)
        {
            // Bind book issue data on form load
            BindBookIssueData();
        }

        private void BindBookIssueData()
        {
            string startDate = dtStartDateDate.Text;
            string endDate = dtendDate.Text;
            bindIssueBookList(startDate, endDate);
        }

        private void bindIssueBookList(string startDate, string endDate)
        {

            if (DateTime.TryParse(startDate, out DateTime start) && DateTime.TryParse(endDate, out DateTime end))
            {
                List<IssueBook> data = IssueBookBL.GetIssueBook(-1, -1, -1, null, null, startDate, endDate);
                if (data != null && data.Count > 0)
                {
                    dataGridissueBook.AutoGenerateColumns = false;
                    dataGridissueBook.DataSource = data;
                    dataGridissueBook.Refresh();
                }
                else
                {
                    MessageBox.Show("No records found.");
                    dataGridissueBook.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Invalid date range.");
            }
        }

        private void pbFilter_Click(object sender, EventArgs e)
        {
            // Filter records based on selected dates
            BindBookIssueData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset filter and reload data
            dtStartDateDate.Text = string.Empty;
            dtendDate.Text = string.Empty;
            BindBookIssueData();
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridissueBook.ColumnHeadersHeight = 35;
            dataGridissueBook.BorderStyle = BorderStyle.None;
            dataGridissueBook.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 246, 255);
            dataGridissueBook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridissueBook.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 123, 255); // Bright Blue
            dataGridissueBook.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridissueBook.BackgroundColor = Color.FromArgb(245, 247, 250);
            dataGridissueBook.EnableHeadersVisualStyles = false;
            dataGridissueBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridissueBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 53, 147); // Darker Blue
            dataGridissueBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Center align columns' content
            foreach (DataGridViewColumn column in dataGridissueBook.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridissueBook.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        }
    }
}
