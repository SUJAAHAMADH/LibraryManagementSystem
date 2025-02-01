using LMS.DAL;
using LMS.MOD;
using System;

namespace LMS.BL
{
    public static class AuthBL
    {
        public static User LoginValidateUser(Login login)
        {
            try
            {
                User user = AuthDAL.LoginValidateUser(login);
                return user;
            }
            catch (Exception ex)
            {
                
                
                throw new Exception(ex.Message);
            }
        }

        public static User Register(User user, int userID = -1)
        {
            try
            {
                user = AuthDAL.Register(user, userID);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool ChangePassword(ChangePassword changePassword)
        {
            try
            {
                bool user = AuthDAL.ChangePassword(changePassword);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static User UpdateProfile(User user)
        {
            try
            {
                user = AuthDAL.UpdateProfile(user);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void SaveBackFileToComputer(string path, string fileName)
        {
            try
            {
                AuthDAL.SaveBackFileToComputer(path, fileName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}