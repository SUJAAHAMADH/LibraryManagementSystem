using LMS.BL;
using LMS.DAL.Shared;
using LMS.MOD;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace LMS.WIN.Forms.ManageCandidate
{
    public partial class ManageCandidates : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        public ManageCandidates()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindCandidateList(searchValue);
        }

        private void ManageCandidates_Load(object sender, EventArgs e)
        {
            bindCandidateList();
        }

        private void bindCandidateList(string searchValue = null, string stream = null)
        {
            List<Candidate> data = null;
            data = CandidateBL.Get(/*-1,*/ -1, stream, null, -1, searchValue);
            if (data != null)
            {
                dataGridCandidate.AutoGenerateColumns = false;
                dataGridCandidate.DataSource = data;
                dataGridCandidate.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Member list not found");
                dataGridCandidate.DataSource = null;
                dataGridCandidate.AutoGenerateColumns = false;
                dataGridCandidate.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            //dataGridCandidate.ColumnHeadersHeight = 35;
            //dataGridCandidate.BorderStyle = BorderStyle.None;
            //dataGridCandidate.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dataGridCandidate.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dataGridCandidate.DefaultCellStyle.SelectionBackColor = Color.Aqua;
            //dataGridCandidate.DefaultCellStyle.SelectionForeColor = Color.Black;
            //dataGridCandidate.BackgroundColor = Color.White;
            //dataGridCandidate.EnableHeadersVisualStyles = false;
            //dataGridCandidate.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridCandidate.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            //dataGridCandidate.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            Candidate user1 = new Candidate();
            frmAddCandidte addCandidte = new frmAddCandidte(user1);
            addCandidte.Show();
        }

        private void dataGridCandidate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridCandidate.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Do You Want To Delete The Member ?", " Member ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        DataGridViewRow dgvRow = dataGridCandidate.CurrentRow;
                        Candidate candidate = new Candidate
                        {
                            CandidateID = Convert.ToInt32(dgvRow.Cells["CandidateID"].Value.ToString()),
                            UserID = userID,
                        };
                        //candidate = CandidateBL.Deactive(candidate);
                        MessageBox.Show("Member Delete Successfully...! ");
                        bindCandidateList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (dataGridCandidate.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow dgvRow = dataGridCandidate.CurrentRow;
                Candidate candidate = new Candidate
                {
                    CandidateID = Convert.ToInt32(dgvRow.Cells["CandidateID"].Value.ToString()),
                    Name = dgvRow.Cells["Name"].Value.ToString(),
                    Barcode = dgvRow.Cells["Barcode"].Value.ToString(),
                    ContactNumber = dgvRow.Cells["ContactNumber"].Value.ToString(),
                    Role = dgvRow.Cells["Role"].Value.ToString(),
                    Stream = dgvRow.Cells["Stream"].Value.ToString(),
                    AcademicYear = Convert.ToInt32(dgvRow.Cells["AcademicYear"].Value.ToString()),
                    RoleID = dgvRow.Cells["ServiceNo"].Value.ToString(),
                    CourseName = dgvRow.Cells["CourseName"].Value.ToString(),
                    FromDate = dgvRow.Cells["FromDate"].Value.ToString(),
                    ToDate = dgvRow.Cells["ToDate"].Value.ToString(),
                    SOSDate = dgvRow.Cells["SOSDate"].Value.ToString(),
                    TOSDate = dgvRow.Cells["TOSDate"].Value.ToString(),
                    ParentsContact = dgvRow.Cells["ParentsContact"].Value.ToString(),
                    Email = dgvRow.Cells["Email"].Value.ToString(),
                    PermanentAddress = dgvRow.Cells["PermanentAddress"].Value.ToString(),
                    PresentAddress = dgvRow.Cells["PresentAddress"].Value.ToString(),

                };
                AddMember frmcandidate = new AddMember(candidate);
                frmcandidate.ShowDialog();
                bindCandidateList();
            }

            else if (dataGridCandidate.Columns[e.ColumnIndex].Name == "View")
            {
                DataGridViewRow dgvRow = dataGridCandidate.CurrentRow;
                Candidate candidate = new Candidate
                {
                    CandidateID = Convert.ToInt32(dgvRow.Cells["CandidateID"].Value.ToString()),
                    Name = dgvRow.Cells["Name"].Value.ToString(),
                    Barcode = dgvRow.Cells["Barcode"].Value.ToString(),
                    ContactNumber = dgvRow.Cells["ContactNumber"].Value.ToString(),
                    Role = dgvRow.Cells["Role"].Value.ToString(),
                    Stream = dgvRow.Cells["Stream"].Value.ToString(),
                    AcademicYear = Convert.ToInt32(dgvRow.Cells["AcademicYear"].Value.ToString()),
                    RoleID = dgvRow.Cells["ServiceNo"].Value.ToString(),
                    CourseName = dgvRow.Cells["CourseName"].Value.ToString(),
                    FromDate = dgvRow.Cells["FromDate"].Value.ToString(),
                    ToDate = dgvRow.Cells["ToDate"].Value.ToString(),
                    SOSDate = dgvRow.Cells["SOSDate"].Value.ToString(),
                    TOSDate = dgvRow.Cells["TOSDate"].Value.ToString(),

                };
                ViewCandidateDetails candidateDetails = new ViewCandidateDetails(candidate);
                candidateDetails.Show();
            }
        }

        private void dataGridCandidate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int col = dataGridCandidate.CurrentCell.ColumnIndex;
                int row = dataGridCandidate.CurrentCell.RowIndex;
                if (col < dataGridCandidate.ColumnCount - 1)
                {
                    col++;
                    Candidate candidate = new Candidate();
                    candidate = (Candidate)dataGridCandidate.CurrentRow.DataBoundItem;
                    frmAddCandidte frmcandidate = new frmAddCandidte(candidate);
                    frmcandidate.Show();
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
            bindCandidateList();
        }

        private void cmboxCandidateType_SelectedValueChanged(object sender, EventArgs e)
        {
            string searchValue = null;
            string stream = cmboxCandidateType.Text;
            bindCandidateList(searchValue, stream);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridCandidate_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridCandidate.Rows)
            {
                string role = Convert.ToString(row.Cells["Role"].Value);
                if (role == "Student")
                {
                    //row.DefaultCellStyle.BackColor = Color.Red;
                    //row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (role == "Teacher")
                {
                    //row.DefaultCellStyle.BackColor = Color.Teal;
                    //row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = null;
                Country country = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files(.xls)|*.xls| Excel Files(.xlsx)| *.xlsx";
                openFileDialog.ShowDialog();
                string fileName = openFileDialog.FileName;

                System.Data.DataTable dt = Utill.ImportExcel.ImportExcelData(fileName);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string role = dt.Rows[i]["Role"].ToString();
                    if (role == "Student")
                    {
                        double dFromDate = double.Parse(dt.Rows[i]["FromDateValue"].ToString());
                        DateTime fromDate = DateTime.FromOADate(dFromDate);

                        double dToDate = double.Parse(dt.Rows[i]["ToDateValue"].ToString());
                        DateTime toDate = DateTime.FromOADate(dToDate);

                        if (dt.Rows[i]["Course"].ToString() != null && dt.Rows[i]["Course"].ToString() != "")
                        {
                            course = CourseBL.GetByName(dt.Rows[i]["Course"].ToString(), userID, fromDate.ToShortDateString(), toDate.ToShortDateString());
                        }
                        else
                        {
                            course = new Course();
                            course.CourseID = -1;
                        }

                        Candidate candidate = new Candidate();
                        candidate.CandidateID = -1;
                        candidate.Role = role;
                        candidate.Name = dt.Rows[i]["Name"].ToString();
                        candidate.ContactNumber = dt.Rows[i]["Contact Number"].ToString();
                        candidate.RoleID = dt.Rows[i]["Service No"].ToString();
                        candidate.CourseID = course.CourseID;
                        candidate.FromDate = fromDate.ToString();
                        candidate.ToDate = toDate.ToString();
                        candidate.UserID = userID;
                        CandidateBL.SaveByExcel(candidate);
                    }
                    else if (role == "Teacher")
                    {

                        double dTosDate = double.Parse(dt.Rows[i]["TOSDateValue"].ToString());
                        DateTime tosDate = DateTime.FromOADate(dTosDate);

                        double dSosDate = double.Parse(dt.Rows[i]["SOSDateValue"].ToString());
                        DateTime sosDate = DateTime.FromOADate(dSosDate);

                        Candidate candidate = new Candidate();
                        candidate.CandidateID = -1;
                        candidate.Role = role;
                        candidate.Name = dt.Rows[i]["Name"].ToString();
                        candidate.ContactNumber = dt.Rows[i]["Contact Number"].ToString();
                        candidate.RoleID = dt.Rows[i]["Service No"].ToString();
                        candidate.TOSDate = tosDate.ToString();
                        candidate.SOSDate = sosDate.ToString();
                        candidate.UserID = userID;
                        CandidateBL.Save(candidate);
                    }
                }
                MessageBox.Show("Candidate Record Import successfully...!");
                bindCandidateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridCandidate_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            Candidate user1 = new Candidate();
            AddMember addMember = new AddMember(user1);
            addMember.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = null;
                Country country = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files(.xls)|*.xls| Excel Files(.xlsx)| *.xlsx";
                openFileDialog.ShowDialog();
                string fileName = openFileDialog.FileName;

                System.Data.DataTable dt = Utill.ImportExcel.ImportExcelData(fileName);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string role = dt.Rows[i]["Role"].ToString();
                    if (role == "STUDENT")
                    {
                        

                        Candidate candidate = new Candidate();
                        candidate.CandidateID = -1;
                        candidate.Role = role;
                        candidate.Name = dt.Rows[i]["Name"].ToString();
                        candidate.ContactNumber = dt.Rows[i]["Contact Number"].ToString();
                        candidate.RoleID = dt.Rows[i]["RollNo"].ToString();
                        candidate.Stream = dt.Rows[i]["Stream"].ToString();
                        candidate.AcademicYear = Convert.ToInt32(dt.Rows[i]["Academic Year"].ToString());
                        candidate.Email = dt.Rows[i]["Email"].ToString();
                        candidate.UserID = userID;
                        CandidateBL.SaveByExcel(candidate);
                    }
                    else if (role == "TEACHER")
                    {

                        Candidate candidate = new Candidate();
                        candidate.CandidateID = -1;
                        candidate.Role = role;
                        candidate.Name = dt.Rows[i]["Name"].ToString();
                        candidate.ContactNumber = dt.Rows[i]["Contact Number"].ToString();
                        candidate.RoleID = dt.Rows[i]["Service No"].ToString();
                        candidate.RoleID = dt.Rows[i]["RollNo"].ToString();
                        candidate.Email = dt.Rows[i]["Email"].ToString();
                        candidate.UserID = userID;
                        CandidateBL.Save(candidate);
                    }
                }
                MessageBox.Show("Member Record Import successfully...!");
                bindCandidateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            string role = cmboxCandidateType.Text;
            #region Candidate-details
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = app.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;
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
            if (!string.IsNullOrEmpty(role))
            {
                cmd.Parameters.Add("@Role", SqlDbType.VarChar).Value = role;
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
            worksheet.Cells[1, 5] = "Roll ID";
            worksheet.Cells[1, 6] = "Stream";
            worksheet.Cells[1, 7] = "Academic Year";
            worksheet.Cells[1, 8] = "Parents Contact";
            worksheet.Cells[1, 9] = "Email";
            worksheet.Cells[1, 10] = "Permanent Address";
            worksheet.Cells[1, 11] = "Present Address";

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
                    worksheet.Cells[i, 6] = row["Stream"] as string ?? string.Empty;
                    worksheet.Cells[i, 7] = row["AcademicYear"] as string ?? string.Empty;
                    worksheet.Cells[i, 8] = row["ParentsContact"] as string ?? string.Empty;
                    worksheet.Cells[i, 9] = row["Email"] as string ?? string.Empty;
                    worksheet.Cells[i, 10] = row["PermanentAddress"] as string ?? string.Empty;
                    worksheet.Cells[i, 11] = row["PresentAddress"] as string ?? string.Empty;

                    Microsoft.Office.Interop.Excel.Range rg = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i, 10];
                    rg.EntireColumn.NumberFormat = "MM-DD-YYYY";

                    Microsoft.Office.Interop.Excel.Range rg1 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i, 11];
                    rg1.EntireColumn.ToString();


                    Microsoft.Office.Interop.Excel.Range rg2 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i, 13];
                    rg2.EntireColumn.NumberFormat = "MM-DD-YYYY";

                    Microsoft.Office.Interop.Excel.Range rg3 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i, 14];
                    rg3.EntireColumn.NumberFormat = "MM-DD-YYYY";


                    i = i + 1;
                    sr = sr + 1;
                }
            }
            #endregion
            worksheet.Columns.AutoFit();
            Range rng = worksheet.get_Range("A1:N1", Missing.Value);
            rng.Interior.Color = XlRgbColor.rgbLightBlue;

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Member-Details";
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

