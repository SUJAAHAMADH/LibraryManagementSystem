using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public class CategoryBL
    {
        public static Category Save(Category category, int categoryID = -1)
        {
            try
            {
                category = CategoryDAL.Save(category, categoryID);
                return category;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Category> Get(int userID = -1, int parentID = -1, string searchValue = null)
        {
            try
            {
                List<Category> categories = CategoryDAL.Get(userID, parentID, searchValue);
                return categories;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Category GetByID(int categoryID)
        {
            try
            {
                Category category = CategoryDAL.GetByID(categoryID);
                return category;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Category GetByName(string name, int userID)
        {
            try
            {
                Category category = CategoryDAL.GetByName(name, userID);
                return category;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Category> GetAll()
        {
            try
            {
                List<Category> category = CategoryDAL.GetAll();
                return category;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static Category Deactive(Category category)
        {
            try
            {
                category = CategoryDAL.DeactiveCategory(category);
                return category;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
