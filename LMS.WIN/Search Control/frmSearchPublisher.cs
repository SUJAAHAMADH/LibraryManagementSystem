using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Search_Control
{
    public partial class frmSearchPublisher : Form
    {
        int userID;
        public frmSearchPublisher()
        {
            InitializeComponent();
        }

        private void frmSearchPublisher_Load(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
            txtSearchPublisherName.Focus();
            bindPublisherList();
        }

        private void bindPublisherList(string name = null)
        {
            string searchValue = txtSearchPublisherName.Text;
            List<Publisher> data = null;
            data = PublisherBL.Get(-1, searchValue);

            if (data != null)
            {

                gridPublisherList.AutoGenerateColumns = false;
                gridPublisherList.Refresh();
                gridPublisherList.DataSource = data;
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Publisher list not found");
                gridPublisherList.DataSource = null;
                gridPublisherList.AutoGenerateColumns = false;
                gridPublisherList.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            gridPublisherList.ColumnHeadersHeight = 35;
            gridPublisherList.BorderStyle = BorderStyle.None;
            gridPublisherList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridPublisherList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridPublisherList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridPublisherList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridPublisherList.BackgroundColor = Color.White;

            gridPublisherList.EnableHeadersVisualStyles = false;
            gridPublisherList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridPublisherList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridPublisherList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtSearchPublisherName_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchPublisherName.Text;
            bindPublisherList(searchValue);
        }

        private void txtSearchPublisherName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                GlobalVariable.GlobalPublisherObj = null;
            }
            if (e.KeyCode == Keys.Down)
            {
                gridPublisherList.Focus();
            }
        }

        private void gridPublisherList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearchPublisherName.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Publisher publisher = new Publisher();
                publisher = (Publisher)gridPublisherList.CurrentRow.DataBoundItem;
                if (publisher != null)
                {
                    GlobalVariable.GlobalPublisherObj = publisher;
                    Close();
                }
                else
                {
                    MessageBox.Show(" No Publisher list found", "Publisher list", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gridPublisherList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridPublisherList.Columns[e.ColumnIndex].Name == "Name")
            {
                Publisher publisher = new Publisher();
                publisher = (Publisher)gridPublisherList.CurrentRow.DataBoundItem;
                if (publisher != null)
                {
                    GlobalVariable.GlobalPublisherObj = publisher;
                    Close();
                }

            }
            if (gridPublisherList.Columns[e.ColumnIndex].Name == "Select")
            {
                Publisher publisher = new Publisher();
                publisher = (Publisher)gridPublisherList.CurrentRow.DataBoundItem;
                if (publisher != null)
                {
                    GlobalVariable.GlobalPublisherObj = publisher;
                    Close();
                }

            }
        }
    }
}
