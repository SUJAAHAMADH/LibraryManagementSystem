using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public static class AlertBL
    {
        public static List<IssueBook> Get(string searchValue = null)
        {
            try
            {
                List<IssueBook> issueBooks = AlertDAL.Get(searchValue);
                return issueBooks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
