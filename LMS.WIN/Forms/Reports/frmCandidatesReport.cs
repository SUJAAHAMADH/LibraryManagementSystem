using LMS.BL;
using LMS.DAL.Shared;
using LMS.MOD;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
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
            datagridReportList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            datagridReportList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridReportList.DefaultCellStyle.SelectionBackColor = Color.Teal;
            datagridReportList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            datagridReportList.BackgroundColor = Color.White;
            datagridReportList.EnableHeadersVisualStyles = false;
            datagridReportList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridReportList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            datagridReportList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void bindCandidateList(int userID, int courseID)
        {
            List<Candidate> data = null;
            data = ReportBL.GetCandidateWiseReport(userID, courseID);
            if (data != null)
            {
                datagridReportList.AutoGenerateColumns = false;
                datagridReportList.Refresh();
                getGridviewByDefaultDesign();
                datagridReportList.DataSource = data;
            }
            else
            {
                MessageBox.Show("data not found");
                datagridReportList.DataSource = null;
                datagridReportList.AutoGenerateColumns = false;
                datagridReportList.Refresh();
            }
        }

        private void txtCourse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                courseObj = null;
                GlobalVariable.GlobalCourseObj = null;
                Search_Control.frmSearchCourse frmSearchCourse = new Search_Control.frmSearchCourse();
                frmSearchCourse.ShowDialog();
                courseObj = GlobalVariable.GlobalCourseObj;
                if (courseObj != null)
                {
                    txtCourse.Text = courseObj.Name;
                    bindCandidateList(-1, courseObj.CourseID);
                }
            }
        }

        private void txtCountry_KeyDown(object sender, KeyEventArgs e)
        {
            //if (courseObj == null)
            //{
            //    courseObj = new Course();
            //    courseObj.CourseID = -1;
            //}

            //if (e.KeyCode == Keys.Enter)
            //{
            //    //countryObj = null;
            //    GlobalVariable.GlobalCountryObj = null;
            //    Search_Control.frmSearchCountry frmSearchCountry = new Search_Control.frmSearchCountry();
            //    frmSearchCountry.ShowDialog();
            //    //countryObj = GlobalVariable.GlobalCountryObj;
            //    //if (countryObj != null)
            //    //{
            //    //    txtCountry.Text = countryObj.Name;
            //    //    bindCandidateList(-1, courseObj.CourseID, countryObj.CountryID, txtRank.Text, txtUnit.Text);
            //    //}
            //}
        }

        private void txtRank_KeyDown(object sender, KeyEventArgs e)
        {
            //if (courseObj == null)
            //{
            //    courseObj = new Course();
            //    courseObj.CourseID = -1;
            //}
            ////if (countryObj == null)
            ////{
            ////    countryObj = new Country();
            ////    countryObj.CountryID = -1;
            ////}

            //if (e.KeyCode == Keys.Enter)
            //{
            //    rankObj = null;
            //    GlobalVariable.GlobalRankObj = null;
            //    Search_Control.frmSearchRank frmSearchRank = new Search_Control.frmSearchRank();
            //    frmSearchRank.ShowDialog();
            //    rankObj = GlobalVariable.GlobalRankObj;
            //    if (rankObj != null)
            //    {
            //        txtRank.Text = rankObj.RankName;
            //        bindCandidateList(-1, courseObj.CourseID, countryObj.CountryID, txtRank.Text, txtUnit.Text);
            //    }
            //}
        }

        private void txtUnit_KeyDown(object sender, KeyEventArgs e)
        {
            //if (courseObj == null)
            //{
            //    courseObj = new Course();
            //    courseObj.CourseID = -1;
            //}
            //if (countryObj == null)
            //{
            //    countryObj = new Country();
            //    countryObj.CountryID = -1;
            //}

            //if (e.KeyCode == Keys.Enter)
            //{
            //    rankObj = null;
            //    GlobalVariable.GlobalRankObj = null;
            //    Search_Control.frmSearchUnit frmSearchUnit = new Search_Control.frmSearchUnit();
            //    frmSearchUnit.ShowDialog();
            //    rankObj = GlobalVariable.GlobalRankObj;
            //    if (rankObj != null)
            //    {
            //        txtUnit.Text = rankObj.UnitName;
            //        bindCandidateList(-1, courseObj.CourseID, countryObj.CountryID, txtRank.Text, txtUnit.Text);
            //    }
            //}
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtCourse.Text = string.Empty;
            bindCandidateList(-1, -1);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            int courseID = -1;
            if (courseObj != null)
            {
                courseID = Convert.ToInt32(courseObj.CourseID);
            }
            SqlConnection con = null;
            #region Candidate-details
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Client-Deatils";

            #region Interacting with database
            con = SqlConnectionHelper.GetConnectionSync();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "ShowCandidate",
                CommandType = CommandType.StoredProcedure,
                Connection = con
            };
            cmd.Parameters.Clear();
            if (courseID != -1)
            {
                cmd.Parameters.Add("@CourseID", SqlDbType.Int).Value = Convert.ToInt32(courseID);
            }
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();
            adp.Fill(dt);
            #endregion

            worksheet.Cells[1, 1] = "SR";
            worksheet.Cells[1, 2] = "Name";
            worksheet.Cells[1, 3] = "Role";
            worksheet.Cells[1, 4] = "Contact Number";
            worksheet.Cells[1, 5] = "Service No";
            worksheet.Cells[1, 6] = "Course";
            worksheet.Cells[1, 7] = "From Date";
            worksheet.Cells[1, 8] = "To Date";
            worksheet.Cells[1, 9] = "TOS Date";
            worksheet.Cells[1, 10] = "SOS Date";

            #region Wrap data
            if (dt.Rows.Count > 0)
            {
                int sr = 1;
                int i = 2;
                foreach (DataRow row in dt.Rows)
                {
                    worksheet.Cells[i, 1] = sr;
                    worksheet.Cells[i, 2] = row["Name"] as string ?? string.Empty;
                    worksheet.Cells[i, 3] = row["Role"] as string ?? string.Empty;
                    worksheet.Cells[i, 4] = row["ContactNumber"] as string ?? string.Empty;
                    worksheet.Cells[i, 5] = row["ServiceNo"] as string ?? string.Empty;
                    worksheet.Cells[i, 6] = row["CourseName"] as string ?? string.Empty;
                    worksheet.Cells[i, 7] = row["FromDate"] as string ?? string.Empty;
                    worksheet.Cells[i, 8] = row["ToDate"] as string ?? string.Empty;
                    worksheet.Cells[i, 9] = row["TOSDate"] as string ?? string.Empty;
                    worksheet.Cells[i, 10] = row["SOSDate"] as string ?? string.Empty;
                    i = i + 1;
                    sr = sr + 1;
                }
            }
            #endregion
            worksheet.Columns.AutoFit();
            Range rng = worksheet.get_Range("A1:N1", Missing.Value);
            rng.Interior.Color = XlRgbColor.rgbLightBlue;

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Candidate-Report";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
            MessageBox.Show("Excel successfully created");
            #endregion
        }
    }
}
