using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageCourses
{
    public partial class AddCourse : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        int courseID;
        Course course = new Course();
        public AddCourse(Course courseOBJ)
        {
            InitializeComponent();
            course = courseOBJ;
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            if (course != null)
            {
                txtCourseName.Text = course.Name;
                richtextDescription.Text = course.Description;
                //dtFromDate.Text = Convert.ToString(DateTime.ParseExact(course.FromDate, "dd/MM/yyyy", null));
                dtFromDate.Text = course.FromDate;
                dtToDate.Text = course.ToDate;
                courseID = course.CourseID;
            }
        }

        private void btnCloseSim_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text != string.Empty)
            {
                if (MessageBox.Show("Do you want to Save the Course data ?", "Done ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        Course course = new Course
                        {
                            Name = txtCourseName.Text,
                            Description = richtextDescription.Text,
                            FromDate = dtFromDate.Text,
                            ToDate = dtToDate.Text,
                            UserID = userID
                        };
                        if (courseID != 0)
                        {
                            course = CourseBL.Save(course, courseID);
                            MessageBox.Show("Course update successfully.", "Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            course = CourseBL.Save(course);
                            MessageBox.Show("course save successfully.", "course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (txtCourseName.Text == string.Empty)
                {
                    txtCourseName.BackColor = Color.Red;
                    txtCourseName.ForeColor = Color.White;
                    txtCourseName.Focus();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
