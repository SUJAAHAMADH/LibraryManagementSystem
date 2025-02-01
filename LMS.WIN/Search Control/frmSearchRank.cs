using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Search_Control
{
    public partial class frmSearchRank : Form
    {
        int userID;
        public frmSearchRank()
        {
            InitializeComponent();
        }

        private void FrmSearchRank_Load(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
            txtSearchName.Focus();
            bindRankList();
        }

        private void bindRankList(string name = null)
        {
            string searchValue = txtSearchName.Text;
            List<Rank> data = null;
            data = CandidateBL.GetRanks(-1, searchValue);

            if (data != null)
            {

                gridRankList.AutoGenerateColumns = false;
                gridRankList.Refresh();
                gridRankList.DataSource = data;
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Ranks list not found");
                gridRankList.DataSource = null;
                gridRankList.AutoGenerateColumns = false;
                gridRankList.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            gridRankList.ColumnHeadersHeight = 35;
            gridRankList.BorderStyle = BorderStyle.None;
            gridRankList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridRankList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridRankList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridRankList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridRankList.BackgroundColor = Color.White;
            gridRankList.EnableHeadersVisualStyles = false;
            gridRankList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridRankList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridRankList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void GridRankList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridRankList.Columns[e.ColumnIndex].Name == "Name")
            {
                Rank rank = new Rank();
                rank = (Rank)gridRankList.CurrentRow.DataBoundItem;
                if (rank != null)
                {
                    GlobalVariable.GlobalRankObj = rank;
                    Close();
                }

            }
            if (gridRankList.Columns[e.ColumnIndex].Name == "Select")
            {
                Rank rank = new Rank();
                rank = (Rank)gridRankList.CurrentRow.DataBoundItem;
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
            bindRankList(searchValue);
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
                gridRankList.Focus();
            }
        }

        private void gridRankList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearchName.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Rank rank = new Rank();
                rank = (Rank)gridRankList.CurrentRow.DataBoundItem;
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
