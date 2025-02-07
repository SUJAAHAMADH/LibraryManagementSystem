using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public static class JournalBL
    {
        public static Journal Save(Journal journal, int journalID = -1)
        {
            try
            {
                journal = JournalDAL.Save(journal, journalID);
                return journal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Journal> Get(int journalID = -1, string name = "", int languageID = -1)
        {
            try
            {
                List<Journal> journals = JournalDAL.Get(journalID, name, languageID);
                return journals;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Journal GetByID(int journalID)
        {
            try
            {
                Journal journal = JournalDAL.GetByID(journalID);
                return journal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Journal Deactive(Journal journal)
        {
            try
            {
                journal = JournalDAL.Deactive(journal);
                return journal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
    }
}
