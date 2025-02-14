using LMS.DAL;
using LMS.MOD;
using System;
using System.Collections.Generic;

namespace LMS.BL
{
    public static class CandidateBL
    {
        public static Candidate Save(Candidate candidate, int candidateID = -1)
        {
            try
            {
                candidate = CandidateDAL.Save(candidate, candidateID);
                return candidate;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Candidate> Get(/*int countryID = -1,*/ int courseID = -1, string stream = null, string thumbImpression = null, int userID = -1, string searchValue = null)
        {
            try
            {
                List<Candidate> candidates = CandidateDAL.Get(/*countryID,*/ courseID, stream, thumbImpression, userID, searchValue);
                return candidates;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Candidate GetByID(int candidateID)
        {
            try
            {
                Candidate candidate = CandidateDAL.GetByID(candidateID);
                return candidate;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Rank> GetRanks(int userID = -1, string searchValue = null)
        {
            try
            {
                List<Rank> ranks = CandidateDAL.GetRanks(userID, searchValue);
                return ranks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Rank> Getunits(int userID = -1, string searchValue = null)
        {
            try
            {
                List<Rank> ranks = CandidateDAL.GetUnits(userID, searchValue);
                return ranks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Candidate SaveByExcel(Candidate candidate, int candidateID = -1)
        {
            try
            {
                candidate = CandidateDAL.SaveByExcel(candidate, candidateID);
                return candidate;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Candidate GetCandidateByBarcode(string barcode)
        {
            try
            {
                Candidate candidate = CandidateDAL.GetCandidateByBarcode(barcode);
                return candidate;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeactivateCandidate(int candidateID, string updatedBy)
        {
            try
            {
                string result = CandidateDAL.DeactivateCandidate(candidateID, updatedBy);
                if (!string.Equals(result, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deactivating the candidate: " + ex.Message);
            }
        }

    }
}
