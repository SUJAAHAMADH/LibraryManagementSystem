using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Search_Control
{
    public partial class frmSearchUnit : Form
    {
        int userID;
        public frmSearchUnit()
        {
            InitializeComponent();
        }
        private void FrmSearchUnit_Load(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
            txtSearchName.Focus();
            bindUnitList();
        }

        private void bindUnitList(string name = null)
        {
            string searchValue = txtSearchName.Text;
            List<Rank> data = null;
            data = CandidateBL.Getunits(-1, searchValue);

            if (data != null)
            {

                gridUnitList.AutoGenerateColumns = false;
                gridUnitList.Refresh();
                gridUnitList.DataSource = data;
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Unit list not found");
                gridUnitList.DataSource = null;
                gridUnitList.AutoGenerateColumns = false;
                gridUnitList.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            gridUnitList.ColumnHeadersHeight = 35;
            gridUnitList.BorderStyle = BorderStyle.None;
            gridUnitList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridUnitList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridUnitList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridUnitList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridUnitList.BackgroundColor = Color.White;
            gridUnitList.EnableHeadersVisualStyles = false;
            gridUnitList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridUnitList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridUnitList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridRankList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUnitList.Columns[e.ColumnIndex].Name == "Name")
            {
                Rank rank = new Rank();
                rank = (Rank)gridUnitList.CurrentRow.DataBoundItem;
                if (rank != null)
                {
                    GlobalVariable.GlobalRankObj = rank;
                    Close();
                }

            }
            if (gridUnitList.Columns[e.ColumnIndex].Name == "Select")
            {
                Rank rank = new Rank();
                rank = (Rank)gridUnitList.CurrentRow.DataBoundItem;
                if (rank != null)
                {
                    GlobalVariable.GlobalRankObj = rank;
                    Close();
                }

            }
        }

        private void TxtSearchName_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchName.Text;
            bindUnitList(searchValue);
        }

        private void TxtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                GlobalVariable.GlobalRankObj = null;
            }
            if (e.KeyCode == Keys.Down)
            {
                gridUnitList.Focus();
            }
        }

        private void gridUnitList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearchName.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Rank rank = new Rank();
                rank = (Rank)gridUnitList.CurrentRow.DataBoundItem;
                if (rank != null)
                {
                    GlobalVariable.GlobalRankObj = rank;
                    Close();
                }
                else
                {
                    MessageBox.Show(" No Author list found", "Author list", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
