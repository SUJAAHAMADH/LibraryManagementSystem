using LMS.DAL;
using LMS.MOD;
using System;

namespace LMS.BL
{
    public static class StudentBL
    {
        public static Student Save(Student student, int StudentID = -1) 
        {
            try
            {
                student = StudentDAL.Save(student, StudentID); 
                return student;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
