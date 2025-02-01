using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageAlerts
{
    public partial class ManageAlert : Form
    {
        public ManageAlert()
        {
            InitializeComponent();
        }

        private void ManageAlert_Load(object sender, EventArgs e)
        {
            bindAlertList();
        }

        private void bindAlertList(string searchValue = null)
        {
            List<IssueBook> data = null;
            data = AlertBL.Get(searchValue);
            if (data != null)
            {
                dataGridAlertBook.AutoGenerateColumns = false;
                dataGridAlertBook.Refresh();
                dataGridAlertBook.DataSource = data;
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Alert  list not found");
                dataGridAlertBook.DataSource = null;
                dataGridAlertBook.AutoGenerateColumns = false;
                dataGridAlertBook.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridAlertBook.ColumnHeadersHeight = 35;
            dataGridAlertBook.BorderStyle = BorderStyle.None;
            dataGridAlertBook.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridAlertBook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridAlertBook.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridAlertBook.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridAlertBook.BackgroundColor = Color.White;
            dataGridAlertBook.EnableHeadersVisualStyles = false;
            dataGridAlertBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridAlertBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridAlertBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindAlertList(searchValue);
        }
    }
}
