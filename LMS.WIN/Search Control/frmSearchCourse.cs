using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace LMS.WIN.Search_Control
{
    public partial class frmSearchCourse : Form
    {
        int userID;
        public frmSearchCourse()
        {
            InitializeComponent();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchName.Text;
            bindCourseList(searchValue);
        }

        private void frmSearchCourse_Load(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
            txtSearchName.Focus();
            bindCourseList();
        }

        private void bindCourseList(string name = null)
        {
            string searchValue = txtSearchName.Text;
            List<Course> data = null;
            data = CourseBL.Get(-1, searchValue);

            if (data != null)
            {

                gridCourseList.AutoGenerateColumns = false;
                gridCourseList.Refresh();
                gridCourseList.DataSource = data;
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("course list not found");
                gridCourseList.DataSource = null;
                gridCourseList.AutoGenerateColumns = false;
                gridCourseList.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            gridCourseList.ColumnHeadersHeight = 35;
            gridCourseList.BorderStyle = BorderStyle.None;
            gridCourseList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridCourseList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCourseList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridCourseList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridCourseList.BackgroundColor = Color.White;
            gridCourseList.EnableHeadersVisualStyles = false;
            gridCourseList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridCourseList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridCourseList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                GlobalVariable.GlobalCourseObj = null;
            }
            if (e.KeyCode == Keys.Down)
            {
                gridCourseList.Focus();
            }
        }

        private void gridCourseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCourseList.Columns[e.ColumnIndex].Name == "Name")
            {
                Course course = new Course();
                course = (Course)gridCourseList.CurrentRow.DataBoundItem;
                if (course != null)
                {
                    GlobalVariable.GlobalCourseObj = course;
                    Close();
                }

            }
            if (gridCourseList.Columns[e.ColumnIndex].Name == "Select")
            {
                Course course = new Course();
                course = (Course)gridCourseList.CurrentRow.DataBoundItem;
                if (course != null)
                {
                    GlobalVariable.GlobalCourseObj = course;
                    Close();
                }

            }
        }

        private void gridCourseList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearchName.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Course course = new Course();
                course = (Course)gridCourseList.CurrentRow.DataBoundItem;
                if (course != null)
                {
                    GlobalVariable.GlobalCourseObj = course;
                    Close();
                }
                else
                {
                    MessageBox.Show(" No Course list found", "Course list", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
