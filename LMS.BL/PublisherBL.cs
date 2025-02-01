using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public static class PublisherBL
    {
        public static Publisher Save(Publisher publisher, int publisherID = -1)
        {
            try
            {
                publisher = PublisherDAL.Save(publisher, publisherID);
                return publisher;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Publisher> Get(int userID = -1, string searchValue = null)
        {
            try
            {
                List<Publisher> publishers = PublisherDAL.Get(userID, searchValue);
                return publishers;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Publisher GetByID(int publisherID)
        {
            try
            {
                Publisher publisher = PublisherDAL.GetByID(publisherID);
                return publisher;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Publisher Deactive(Publisher publisher)
        {
            try
            {
                publisher = PublisherDAL.Deactive(publisher);
                return publisher;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Publisher GetByName(string name, int userID)
        {
            try
            {
                Publisher publisher = PublisherDAL.GetByName(name, userID);
                return publisher;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
