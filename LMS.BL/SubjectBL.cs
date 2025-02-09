using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public class SubjectBL
    {
        public static Subject Save(Subject subject, int subjectID = -1)
        {
            try
            {
                subject = SubjectDAL.Save(subject, subjectID);
                return subject;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Subject> Get(int userID = -1, string searchValue = null)
        {
            try
            {
                List<Subject> subjects = SubjectDAL.Get(userID, searchValue);
                return subjects;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Subject GetByID(int subjectID)
        {
            try
            {
                Subject subject = SubjectDAL.GetByID(subjectID);
                return subject;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Subject Deactive(Subject subject)
        {
            try
            {
                subject = SubjectDAL.Deactive(subject);
                return subject;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Subject GetByName(string name)
        {
            try
            {
                Subject subject = SubjectDAL.GetByName(name);
                return subject;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
