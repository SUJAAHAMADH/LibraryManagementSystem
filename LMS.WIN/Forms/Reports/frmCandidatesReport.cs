using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LMS.WIN.Forms.Reports
{
    public partial class frmCandidatesReport : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        User user = new User();

        Course courseObj = null;
        //Country countryObj = null;
       // Rank rankObj = null;

        public frmCandidatesReport()
        {
            InitializeComponent();
        }


        private void FrmCandidatesReport_Load(object sender, EventArgs e)
        {
            bindCandidateList(-1, -1);
        }

        public void getGridviewByDefaultDesign()
        {
            datagridReportList.ColumnHeadersHeight = 35;
            datagridReportList.BorderStyle = BorderStyle.None;
            datagridReportList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 246, 255);
            datagridReportList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridReportList.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 123, 255); // Bright Blue
            datagridReportList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            datagridReportList.BackgroundColor = Color.FromArgb(245, 247, 250);
            datagridReportList.EnableHeadersVisualStyles = false;
            datagridReportList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridReportList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 53, 147); // Darker Blue
            datagridReportList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            // Center align columns' content
            foreach (DataGridViewColumn column in datagridReportList.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            datagridReportList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
        }

        private void bindCandidateList(int userID, int courseID, string roleFilter = "")
        {
            List<Candidate> data = ReportBL.GetCandidateWiseReport(userID, courseID);
            if (data != null)
            {
                // Apply role filter if it is not empty
                if (!string.IsNullOrEmpty(roleFilter))
                {
                    data = data.Where(c => c.Role.IndexOf(roleFilter, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                }

                datagridReportList.AutoGenerateColumns = false;
                datagridReportList.DataSource = data;
                datagridReportList.Columns["CandidateID"].DataPropertyName = "CandidateID";

                // Call to apply the default grid view design
                getGridviewByDefaultDesign(); // Corrected call with parentheses

                datagridReportList.Refresh();
            }
            else
            {
                MessageBox.Show("Data not found");
                datagridReportList.DataSource = null;
                datagridReportList.Refresh();
            }
        }




        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Reset filters
            cbPersonType.SelectedIndex = -1; // Reset ComboBox (if applicable)

            // Rebind the list without filters
            bindCandidateList(-1, -1);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
        }

        private void cbPersonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cbPersonType.SelectedItem?.ToString() ?? string.Empty;
            bindCandidateList(-1, -1, roleFilter: selectedRole);
        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

