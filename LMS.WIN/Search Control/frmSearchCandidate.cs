using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Search_Control
{
    public partial class frmSearchCandidate : Form
    {
        public frmSearchCandidate()
        {
            InitializeComponent();
        }

        private void frmSearchCandidate_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            bindCandidateList();
        }

        private void bindCandidateList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<Candidate> data = null;
            data = CandidateBL.Get(/*-1,*/ -1, null, null, -1,  searchValue);

            if (data != null)
            {

                gridCandidate.AutoGenerateColumns = false;
                gridCandidate.Refresh();
                gridCandidate.DataSource = data;
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Candidat list not found");
                gridCandidate.DataSource = null;
                gridCandidate.AutoGenerateColumns = false;
                gridCandidate.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            gridCandidate.ColumnHeadersHeight = 35;
            gridCandidate.BorderStyle = BorderStyle.None;
            gridCandidate.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridCandidate.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCandidate.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridCandidate.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridCandidate.BackgroundColor = Color.White;

            gridCandidate.EnableHeadersVisualStyles = false;
            gridCandidate.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridCandidate.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridCandidate.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void gridCandidate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearch.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Candidate Candidate = new Candidate();
                Candidate = (Candidate)gridCandidate.CurrentRow.DataBoundItem;
                if (Candidate != null)
                {
                    GlobalVariable.GlobalCandidateObj = Candidate;
                    Close();
                }
                else
                {
                    MessageBox.Show(" No Author list found", "Author list", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                GlobalVariable.GlobalCandidateObj = null;
            }
            if (e.KeyCode == Keys.Down)
            {
                gridCandidate.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindCandidateList(searchValue);
        }

        private void gridCandidate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCandidate.Columns[e.ColumnIndex].Name == "Select")
            {
                Candidate Candidate = new Candidate();
                Candidate = (Candidate)gridCandidate.CurrentRow.DataBoundItem;
                if (Candidate != null)
                {
                    GlobalVariable.GlobalCandidateObj = Candidate;
                    Close();
                }
            }

            if (gridCandidate.Columns[e.ColumnIndex].Name == "Name")
            {
                Candidate candidate = new Candidate();
                candidate = (Candidate)gridCandidate.CurrentRow.DataBoundItem;
                if (candidate != null)
                {
                    GlobalVariable.GlobalCandidateObj = candidate;
                    Close();
                }
            }
        }
    }
}
