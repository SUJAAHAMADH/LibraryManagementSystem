using LMS.BL;
using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
namespace LMS.WIN.Forms.ManageCourses
{
    public partial class ManageCourse : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        public ManageCourse()
        {
            InitializeComponent();
        }

        private void ManageCourse_Load(object sender, EventArgs e)
        {
            bindCourseList();
        }

        private void bindCourseList(string searchValue = null)
        {
            List<Course> data = null;
            data = CourseBL.Get(-1,  searchValue);
            if (data != null)
            {
                dataGridCourse.AutoGenerateColumns = false;
                dataGridCourse.DataSource = data;
                dataGridCourse.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Course list not found");
                dataGridCourse.DataSource = null;
                dataGridCourse.AutoGenerateColumns = false;
                dataGridCourse.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridCourse.ColumnHeadersHeight = 35;
            dataGridCourse.BorderStyle = BorderStyle.None;
            dataGridCourse.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridCourse.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridCourse.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridCourse.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridCourse.BackgroundColor = Color.White;
            dataGridCourse.EnableHeadersVisualStyles = false;
            dataGridCourse.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridCourse.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridCourse.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            AddCourse addCourse = new AddCourse(course);
            addCourse.Show();
        }

        private void dataGridCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridCourse.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Do you want to delete the Course ?", " Course / Master ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        DataGridViewRow dgvRow = dataGridCourse.CurrentRow;
                        Course course = new Course
                        {
                            CourseID = Convert.ToInt32(dgvRow.Cells["CourseID"].Value.ToString()),
                            UserID = userID,
                        };
                        //course = CourseBL.Deactive(course);
                        MessageBox.Show("Course Delete successfully.");
                        bindCourseList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (dataGridCourse.Columns[e.ColumnIndex].Name == "Edit")
            {
                Course course = new Course();
                course = (Course)dataGridCourse.CurrentRow.DataBoundItem;
                AddCourse frm = new AddCourse(course);
                frm.Show();
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindCourseList(searchValue);
        }

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            bindCourseList();
        }
    }
}
