using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public static class IssueBookBL
    {
        public static IssueBook SaveIssueBook(IssueBook issueBook, int issueBookID = -1)
        {
            try
            {
                issueBook = IssueBookDAL.SaveIssueBook(issueBook, issueBookID);
                return issueBook;
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

        public static List<IssueBook> GetMonthlyTransactionBook(int userID = -1, int bookBarcodeID = -1, int candidateID = -1, string barcode = null, string searchValue = null, string startDate = null, string endDate = null)
        {
            try
            {
                List<IssueBook> issueBooks = IssueBookDAL.GetMonthlyTransaction(userID, bookBarcodeID, candidateID, barcode, searchValue, startDate, endDate);
                return issueBooks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static IssueBook SaveReturnBook(IssueBook issueBook, int issueBookID = -1)
        {
            try
            {
                issueBook = IssueBookDAL.SaveReturnBook(issueBook, issueBookID);
                return issueBook;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<IssueBook> GetReturnBook(int userID = -1, int bookBarcodeID = -1, int candidateID = -1, string searchValue = null, string startDate = null, string endDate = null)
        {
            try
            {
                List<IssueBook> issueBooks = IssueBookDAL.GetReturnBook(userID, bookBarcodeID, candidateID, searchValue, startDate, endDate);
                return issueBooks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static IssueBook SaveRenewalBook(IssueBook issueBook, int issueBookID = -1)
        {
            try
            {
                issueBook = IssueBookDAL.SaveRenewalBook(issueBook, issueBookID);
                return issueBook;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<IssueBook> GetRenewalBook(int userID = -1, int bookBarcodeID = -1, int candidateID = -1, string searchValue = null, string startDate = null, string endDate = null)
        {
            try
            {
                List<IssueBook> issueBooks = IssueBookDAL.GetRenewalBook(userID, bookBarcodeID, candidateID, searchValue, startDate, endDate);
                return issueBooks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<BookHistory> GetBookHistory(int userID = -1, int bookBarcodeID = -1, int candidateID = -1, string barcode = null, string searchValue = null)
        {
            try
            {
                List<BookHistory> bookHistories = IssueBookDAL.GetBookHistory(userID, bookBarcodeID, candidateID, barcode, searchValue);
                return bookHistories;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static IssueBook GetIssueBookByBarcode(string barcode)
        {
            try
            {
                IssueBook issueBook = IssueBookDAL.GetIssueBookByBarcode(barcode);
                return issueBook;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<IssueBook> GetLatestIssueBook(int userID = -1, int bookBarcodeID = -1, int candidateID = -1, string barcode = null, string searchValue = null)
        {
            try
            {
                List<IssueBook> issueBooks = IssueBookDAL.GetLatestIssueBook(userID, bookBarcodeID, candidateID, barcode, searchValue);
                return issueBooks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
