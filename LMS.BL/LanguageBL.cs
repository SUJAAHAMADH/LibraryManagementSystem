using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public class LanguageBL
    {
        public static Language Save(Language language, int languageID = -1)
        {
            try
            {
                language = LanguageDAL.Save(language, languageID);
                return language;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Language> Get(int userID = -1, string searchValue = null)
        {
            try
            {
                List<Language> languages = LanguageDAL.Get(userID, searchValue);
                return languages;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Language GetByID(int languageID)
        {
            try
            {
                Language language = LanguageDAL.GetByID(languageID);
                return language;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Language Deactive(Language language)
        {
            try
            {
                language = LanguageDAL.Deactive(language);
                return language;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Language GetByName(string name, int userID)
        {
            try
            {
                Language language = LanguageDAL.GetByName(name, userID);
                return language;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
