using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public static class MissingBookBL
    {
        public static MissingBook Save(MissingBook missingBook, int missingBookID = -1)
        {
            try
            {
                missingBook = MissingBookDAL.Save(missingBook, missingBookID);
                return missingBook;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<MissingBook> Get(int userID = -1, int bookBarcodeID = -1, string searchValue = null)
        {
            try
            {
                List<MissingBook> missingBooks = MissingBookDAL.Get(userID, bookBarcodeID, searchValue);
                return missingBooks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static MissingBook GetByID(int missingBookID)
        {
            try
            {
                MissingBook missingBook = MissingBookDAL.GetByID(missingBookID);
                return missingBook;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
