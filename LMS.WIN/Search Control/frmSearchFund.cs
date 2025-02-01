using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Search_Control
{
    public partial class frmSearchFund : Form
    {
        int userID;
        public frmSearchFund()
        {
            InitializeComponent();
        }
        private void FrmSearchFund_Load(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
            txtSearchName.Focus();
            bindFundList();
        }

        private void bindFundList(string name = null)
        {
                string searchValue = txtSearchName.Text;
            List<Book> data = null;
            data = BookBL.GetFunds(-1, searchValue);
            if (data != null)
            {
                gridFundList.AutoGenerateColumns = false;
                gridFundList.Refresh();
                gridFundList.DataSource = data;
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Funds list not found");
                gridFundList.DataSource = null;
                gridFundList.AutoGenerateColumns = false;
                gridFundList.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            gridFundList.ColumnHeadersHeight = 35;
            gridFundList.BorderStyle = BorderStyle.None;
            gridFundList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridFundList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridFundList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridFundList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridFundList.BackgroundColor = Color.White;
            gridFundList.EnableHeadersVisualStyles = false;
            gridFundList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridFundList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridFundList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridFundList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridFundList.Columns[e.ColumnIndex].Name == "Name")
            {
                Book fund = new Book();
                fund = (Book)gridFundList.CurrentRow.DataBoundItem;
                if (fund != null)
                {
                    GlobalVariable.GlobalBookObj = fund;
                    Close();
                }

            }
            if (gridFundList.Columns[e.ColumnIndex].Name == "Select")
            {
                Book fund = new Book();
                fund = (Book)gridFundList.CurrentRow.DataBoundItem;
                if (fund != null)
                {
                    GlobalVariable.GlobalBookObj = fund;
                    Close();
                }

            }
        }

        private void TxtSearchName_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchName.Text;
            bindFundList(searchValue);
        }

        private void TxtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                GlobalVariable.GlobalBookObj = null;
            }
            if (e.KeyCode == Keys.Down)
            {
                gridFundList.Focus();
            }
        }

        private void gridFundList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearchName.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Book fund = new Book();
                fund = (Book)gridFundList.CurrentRow.DataBoundItem;
                if (fund != null)
                {
                    GlobalVariable.GlobalBookObj = fund;
                    Close();
                }
                else
                {
                    MessageBox.Show(" No book list found", "Author list", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
