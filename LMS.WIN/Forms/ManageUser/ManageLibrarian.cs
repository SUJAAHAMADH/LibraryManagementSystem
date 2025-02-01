using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageUser
{
    public partial class ManageLibrarian : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        public ManageLibrarian()
        {
            InitializeComponent();
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            User user1 = new User();
            frmAddUser addUser = new frmAddUser(user1);
            addUser.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindUserList(searchValue);
        }

        private void ManageLibrarian_Load(object sender, EventArgs e)
        {
            bindUserList();
        }

        private void bindUserList(string searchValue = null)
        {
            string role = "LIBRARIAN";
            List<User> data = null;
            data = UserBL.Get(role, -1, searchValue);
            if (data != null)
            {
                dataGridUser.AutoGenerateColumns = false;
                dataGridUser.DataSource = data;
                dataGridUser.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("LIBRARIAN list not found");
                dataGridUser.DataSource = null;
                dataGridUser.AutoGenerateColumns = false;
                dataGridUser.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridUser.ColumnHeadersHeight = 35;
            dataGridUser.BorderStyle = BorderStyle.None;
            dataGridUser.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridUser.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridUser.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridUser.BackgroundColor = Color.White;
            dataGridUser.EnableHeadersVisualStyles = false;
            dataGridUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridUser.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridUser.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridUser.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Do you want to delete the LIBRARIAN ?", " LIBRARIAN / Master ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataGridViewRow dgvRow = dataGridUser.CurrentRow;
                    User user = new User
                    {
                        UserID = Convert.ToInt32(dgvRow.Cells["UserID1"].Value.ToString()),
                        CreatedBy = userID
                    };
                    user = UserBL.Deactive(user);

                    MessageBox.Show("LIBRARIAN Delete successfully.");
                    bindUserList();
                }
            }
            else if (dataGridUser.Columns[e.ColumnIndex].Name == "Edit")
            {
                User user = new User();
                user = (User)dataGridUser.CurrentRow.DataBoundItem;
                frmAddUser frm = new frmAddUser(user);
                frm.Show();
            }
        }

        private void dataGridUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int col = dataGridUser.CurrentCell.ColumnIndex;
                int row = dataGridUser.CurrentCell.RowIndex;
                if (col < dataGridUser.ColumnCount - 1)
                {
                    col++;
                    User user = new User();
                    user = (User)dataGridUser.CurrentRow.DataBoundItem;
                    frmAddUser frm = new frmAddUser(user);
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

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            bindUserList();
        }
    }
}
