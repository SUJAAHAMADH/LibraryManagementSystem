using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManagePublisher
{
    public partial class ManagePublisher : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        public ManagePublisher()
        {
            InitializeComponent();
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher();
            frmAddPublisher addPublisher = new frmAddPublisher(publisher);
            addPublisher.Show();
        }

        private void ManagePublisher_Load(object sender, EventArgs e)
        {
            bindPublisherList();
        }

        private void bindPublisherList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<Publisher> data = null;
            data = PublisherBL.Get(-1, searchValue);
            if (data != null)
            {
                dataGridPublisher.AutoGenerateColumns = false;
                dataGridPublisher.DataSource = data;
                dataGridPublisher.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Publisher list not found");
                dataGridPublisher.DataSource = null;
                dataGridPublisher.AutoGenerateColumns = false;
                dataGridPublisher.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {

            //dataGridPublisher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //dataGridPublisher.ColumnHeadersHeight = 30;
            //dataGridPublisher.BorderStyle = BorderStyle.None;
            //dataGridPublisher.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dataGridPublisher.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dataGridPublisher.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridPublisher.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dataGridPublisher.BackgroundColor = Color.White;
            //dataGridPublisher.EnableHeadersVisualStyles = false;
            //dataGridPublisher.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridPublisher.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dataGridPublisher.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dataGridPublisher.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

   
        }

        private void dataGridPublisher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPublisher.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Do you want to delete the Publisher ?", " Publisher / Master ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        DataGridViewRow dgvRow = dataGridPublisher.CurrentRow;
                        Publisher publisher = new Publisher
                        {
                            PublisherID = Convert.ToInt32(dgvRow.Cells["PublisherID"].Value.ToString()),
                            UserID = userID,
                        };
                        publisher = PublisherBL.Deactive(publisher);
                        MessageBox.Show("Publisher Delete successfully.");
                        bindPublisherList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (dataGridPublisher.Columns[e.ColumnIndex].Name == "Edit")
            {
                Publisher publisher = new Publisher();
                publisher = (Publisher)dataGridPublisher.CurrentRow.DataBoundItem;
                frmAddPublisher frm = new frmAddPublisher(publisher);
                frm.Show();
            }
        }

        private void dataGridPublisher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int col = dataGridPublisher.CurrentCell.ColumnIndex;
                int row = dataGridPublisher.CurrentCell.RowIndex;
                if (col < dataGridPublisher.ColumnCount - 1)
                {
                    col++;
                    Publisher publisher = new Publisher();
                    publisher = (Publisher)dataGridPublisher.CurrentRow.DataBoundItem;
                    frmAddPublisher frm = new frmAddPublisher(publisher);
                    frm.Show();
                }
                else
                {
                    col = 0;
                    row++;
                }
                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindPublisherList(searchValue);
        }

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            bindPublisherList();
        }
    }
}
