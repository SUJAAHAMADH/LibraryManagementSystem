using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;


namespace LMS.BL
{
   public class ReportBL
    {
        public static List<Candidate> GetCandidateWiseReport(int userID, int courseID = -1)
        {
            try
            {
                List<Candidate> reports = ReportDAL.GetCandidateWiseReport(userID, courseID);
                return reports;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Book> GetBookWiseReport(int userID, int authorID = -1, int publisherID = -1, int bookID = -1, string funds = null)
        {
            try
            {
                List<Book> reports = ReportDAL.GetBookWiseReport(userID, authorID, publisherID, bookID, funds);
                return reports;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
