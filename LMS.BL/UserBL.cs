using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public static class UserBL
    {
        public static List<User> Get(string role, int createdBy = -1, string searchValue = null, string thumbImpression=null)
        {
            try
            {
                List<User> users = UserDAL.Get(role, createdBy, searchValue, thumbImpression);
                return users;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static User GetByID(int userID)
        {
            try
            {
                User user = UserDAL.GetByID(userID);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static User Deactive(User user)
        {
            try
            {
                user = UserDAL.Deactive(user);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
