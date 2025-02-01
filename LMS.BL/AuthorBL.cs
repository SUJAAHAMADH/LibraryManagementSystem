using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public static class AuthorBL
    {
        public static Author Save(Author author, int authorID = -1)
        {
            try
            {
                author = AuthorDAL.Save(author, authorID);
                return author;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Author> Get(int userID = -1, string searchValue = null)
        {
            try
            {
                List<Author> authors = AuthorDAL.Get(userID, searchValue);
                return authors;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Author GetByID(int authorID)
        {
            try
            {
                Author author = AuthorDAL.GetByID(authorID);
                return author;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Author Deactive(Author author)
        {
            try
            {
                author = AuthorDAL.Deactive(author);
                return author;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Author GetByName(string name, int userID)
        {
            try
            {
                Author author = AuthorDAL.GetByName(name, userID);
                return author;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}