using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Search_Control
{
    public partial class frmSearchByUID : Form
    {
        public frmSearchByUID()
        {
            InitializeComponent();
        }

        private void frmSearchByUID_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            bindCandidateList();
        }

        private void bindCandidateList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<Candidate> data = null;
            data = CandidateBL.Get(/*-1,*/ -1, null, null, -1, searchValue);

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
                Candidate candidate = new Candidate();
                candidate = (Candidate)gridCandidate.CurrentRow.DataBoundItem;
                if (candidate != null)
                {
                    GlobalVariable.GlobalCandidateObj = candidate;
                    Close();
                }
                else
                {
                    MessageBox.Show(" No UID list found", "UID list", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                GlobalVariable.GlobalUserObj = null;
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
                Candidate candidate = new Candidate();
                candidate = (Candidate)gridCandidate.CurrentRow.DataBoundItem;
                if (candidate != null)
                {
                    GlobalVariable.GlobalCandidateObj = candidate;
                    Close();
                }
            }

            if (gridCandidate.Columns[e.ColumnIndex].Name == "ServiceNo")
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
