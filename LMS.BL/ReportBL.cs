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

        public static List<Book> GetBookWiseReport(int userID, int authorID = -1, int publisherID = -1, int bookID = -1, int categoryID = -1)
        {
            try
            {
                List<Book> reports = ReportDAL.GetBookWiseReport(userID, authorID, publisherID, bookID, categoryID);
                return reports;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<IssueBook> GetIssueBook(int userID = -1, int bookBarcodeID = -1, int candidateID = -1, string barcode = null, string searchValue = null, string startDate = null, string endDate = null)
        {
            try
            {
                List<IssueBook> issueBooks = IssueBookDAL.GetIssueBook(userID, bookBarcodeID, candidateID, barcode, searchValue, startDate, endDate);
                return issueBooks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
