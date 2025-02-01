using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public static class CourseBL
    {
        public static Course Save(Course course, int courseID = -1)
        {
            try
            {
                course = CourseDAL.Save(course, courseID);
                return course;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Course> Get(int userID = -1, string searchValue = null)
        {
            try
            {
                List<Course> courses = CourseDAL.Get(userID, searchValue);
                return courses;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Course GetByID(int courseID)
        {
            try
            {
                Course course = CourseDAL.GetByID(courseID);
                return course;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Course GetByName(string name, int userID, string fromDate = null, string toDate = null)
        {
            try
            {
                Course course = CourseDAL.GetByName(name, userID, fromDate, toDate);
                return course;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
