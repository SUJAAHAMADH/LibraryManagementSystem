using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public static class CountryBL
    {
        public static Country Save(Country country, int countryID = -1)
        {
            try
            {
                country = CountryDAL.Save(country, countryID);
                return country;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Country> Get(int userID = -1, string searchValue = null)
        {
            try
            {
                List<Country> countries = CountryDAL.Get(userID, searchValue);
                return countries;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Country GetByID(int countryID)
        {
            try
            {
                Country country = CountryDAL.GetByID(countryID);
                return country;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Country GetByName(string name, int userID)
        {
            try
            {
                Country country = CountryDAL.GetByName(name, userID);
                return country;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
