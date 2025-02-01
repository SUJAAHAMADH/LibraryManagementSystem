using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public static class BookBL
    {
        public static Book Save(Book book, int bookID = -1)
        {
            try
            {
                book = BookDAL.Save(book, bookID);
                return book;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Book> Get(int userID = -1, int authorID = -1, int publisherID = -1, string searchValue = null)
        {
            try
            {
                List<Book> books = BookDAL.Get(userID, authorID, publisherID, searchValue);
                return books;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Book GetByID(int bookID)
        {
            try
            {
                Book book = BookDAL.GetByID(bookID);
                return book;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static BookBarcode DeactiveBookBarcode(BookBarcode bookBarcode)
        {
            try
            {
                bookBarcode = BookDAL.DeactiveBookBarcode(bookBarcode);
                return bookBarcode;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Book Deactive(Book book)
        {
            try
            {
                book = BookDAL.Deactive(book);
                return book;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static BookDetail GetBookByBarcode(string barcode)
        {
            try
            {
                BookDetail bookDetail = BookDAL.GetBookByBarcode(barcode);
                return bookDetail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string GetBarcode(bool isRestricted)
        {
            try
            {
                string barcode = BookDAL.GetBarcode(isRestricted);
                return barcode;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<BookBarcode> GetBookBarcodeByBookID(int bookID = -1, string searchValue = null)
        {
            try
            {
                List<BookBarcode> bookBarcodes = BookDAL.GetBookBarcode(bookID, searchValue);
                return bookBarcodes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<AvailableBook> GetBookAvailableQty(int bookID = -1, string searchValue = null)
        {
            try
            {
                List<AvailableBook> availableBooks = BookDAL.GetBookAvailableQty(bookID, searchValue);
                return availableBooks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<BookBarcode> GetAvailableBookBarcodeByBookID(int bookID = -1, string searchValue = null)
        {
            try
            {
                List<BookBarcode> bookBarcodes = BookDAL.GetAvailableBookBarcodeByBookID(bookID, searchValue);
                return bookBarcodes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool CheckAvailableBookBarcode(int bookBarcodeID)
        {
            try
            {
                return BookDAL.CheckAvailableBookBarcode(bookBarcodeID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Book> GetFunds(int userID = -1, string searchValue = null)
        {
            try
            {
                List<Book> ranks = BookDAL.GetFunds(userID, searchValue);
                return ranks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
