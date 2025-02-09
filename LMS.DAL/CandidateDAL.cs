using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public static class CandidateDAL
    {
        public static Candidate Save(Candidate candidate, int candidateID)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@Role", DbType = DbType.String, Value = candidate.Role},
                new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = candidate.Name},
                new SqlParameter{ParameterName = "@ContactNumber", DbType = DbType.String, Value = candidate.ContactNumber},
                new SqlParameter{ParameterName = "@ServiceNo", DbType = DbType.String, Value = candidate.RoleID},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = candidate.UserID},
                new SqlParameter{ParameterName = "@DOB", DbType = DbType.DateTime, Value = candidate.DOB},
                new SqlParameter{ParameterName = "@Stream", DbType = DbType.String, Value = candidate.Stream},
                new SqlParameter{ParameterName = "@AcademicYear", DbType = DbType.Int32, Value = candidate.AcademicYear},
                new SqlParameter{ParameterName = "@PermanentAddress", DbType = DbType.String, Value = candidate.PermanentAddress},
                new SqlParameter{ParameterName = "@PresentAddress", DbType = DbType.String, Value = candidate.PresentAddress},
                new SqlParameter{ParameterName = "@Email", DbType = DbType.String, Value = candidate.Email},
                new SqlParameter{ParameterName = "@ParentsContact", DbType = DbType.Int32, Value = candidate.ParentsContact},
                new SqlParameter{ParameterName = "@Photo", DbType = DbType.Binary, Value = (object)candidate.Photo ?? DBNull.Value },
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (candidateID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@CandidateID", DbType = DbType.Int32, Value = candidateID });
            }
            if (candidate.CourseID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@CourseID", DbType = DbType.Int32, Value = candidate.CourseID });
            }
            if (!string.IsNullOrEmpty(candidate.FromDate))
            {
                param.Add(new SqlParameter { ParameterName = "@FromDate", DbType = DbType.Date, Value = candidate.FromDate });
            }
            if (!string.IsNullOrEmpty(candidate.ToDate))
            {
                param.Add(new SqlParameter { ParameterName = "@ToDate", DbType = DbType.Date, Value = candidate.ToDate });
            }
           
            if (!string.IsNullOrEmpty(candidate.TOSDate))
            {
                param.Add(new SqlParameter { ParameterName = "@TOSDate", DbType = DbType.Date, Value = candidate.TOSDate });
            }
            if (!string.IsNullOrEmpty(candidate.SOSDate))
            {
                param.Add(new SqlParameter { ParameterName = "@SOSDate", DbType = DbType.Date, Value = candidate.SOSDate });
            }
            if (candidate.ThumbImpression != null && candidate.ThumbImpression.Length > 0)
            {
                param.Add(new SqlParameter { ParameterName = "@ThumbImpression", DbType = DbType.String, Value = candidate.ThumbImpression });
            }

            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SaveCandidate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                candidate.CandidateID = id;
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                #region Close connection
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                #endregion
            }
            return candidate;
        }

        public static List<Candidate> Get(int courseID, string stream, string thumbImpression, int userID, string searchValue)
        {
            #region Declaration
            List<Candidate> candidates = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();

            if (courseID != -1)
            {
                param.Add(new SqlParameter("@CourseID", courseID));
            }
            if (!string.IsNullOrEmpty(stream))
            {
                param.Add(new SqlParameter("@Stream", stream));
            }
            if (!string.IsNullOrEmpty(thumbImpression))
            {
                param.Add(new SqlParameter("@ThumbImpression", thumbImpression));
            }
            if (userID != -1)
            {
                param.Add(new SqlParameter("@UserID", userID));
            }
            if (!string.IsNullOrEmpty(searchValue))
            {
                param.Add(new SqlParameter("@SearchValue", searchValue));
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowCandidate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    candidates = new List<Candidate>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Candidate candidate = new Candidate
                        {
                            CandidateID = row["CandidateID"] as int? ?? 0,
                            Barcode = row["Barcode"] as string ?? string.Empty,
                            Role = row["Role"] as string ?? string.Empty,
                            Name = row["Name"] as string ?? string.Empty,
                            ContactNumber = row["ContactNumber"] as string ?? string.Empty,
                            RoleID = row["ServiceNo"] as string ?? string.Empty,  
                            Stream = row["Stream"] as string ?? string.Empty,
                            AcademicYear = row["AcademicYear"] as int? ?? 0,
                            CourseID = row["CourseID"] as int? ?? 0,
                            CourseName = row["CourseName"] as string ?? string.Empty,
                            FromDate = row["FromDate"] as string ?? string.Empty,
                            ToDate = row["ToDate"] as string ?? string.Empty,
                            TOSDate = row["TOSDate"] as string ?? string.Empty,
                            SOSDate = row["SOSDate"] as string ?? string.Empty,
                            ThumbImpression = row["ThumbImpression"] as string ?? string.Empty,
                            ParentsContact = row["ParentsContact"] as string ?? string.Empty,
                            Email = row["Email"] as string ?? string.Empty,
                            PermanentAddress = row["PermanentAddress"] as string ?? string.Empty,
                            PresentAddress = row["PresentAddress"] as string ?? string.Empty
                        };
                        candidates.Add(candidate);
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                #region Close connection
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                #endregion
            }
            return candidates;
        }



        public static Candidate GetByID(int candidateID)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Candidate candidate = null;
            SqlParameter param = new SqlParameter { ParameterName = "@CandidateID", Value = candidateID, DbType = DbType.Int32 };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowCandidate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    candidate = new Candidate();
                    foreach (DataRow row in dt.Rows)
                    {
                        candidate.CandidateID = row["CandidateID"] as int? ?? 0;
                        candidate.Barcode = row["Barcode"] as string ?? string.Empty;
                        candidate.Role = row["Role"] as string ?? string.Empty;
                        candidate.Name = row["Name"] as string ?? string.Empty;
                        candidate.ContactNumber = row["ContactNumber"] as string ?? string.Empty;
                        candidate.RoleID = row["ServiceNo"] as string ?? string.Empty;
                        //candidate.Rank = row["Rank"] as string ?? string.Empty;
                        //candidate.Unit = row["Unit"] as string ?? string.Empty;
                        //candidate.CountryID = row["CountryID"] as int? ?? 0;
                        //candidate.CountryName = row["CountryName"] as string ?? string.Empty;
                        candidate.CourseID = row["CourseID"] as int? ?? 0;
                        candidate.CourseName = row["CourseName"] as string ?? string.Empty;
                        candidate.FromDate = row["FromDate"] as string ?? string.Empty;
                        candidate.ToDate = row["ToDate"] as string ?? string.Empty;
                        //candidate.Battalion = row["Battalion"] as string ?? string.Empty;
                        candidate.TOSDate = row["TOSDate"] as string ?? string.Empty;
                        candidate.SOSDate = row["SOSDate"] as string ?? string.Empty;
                        candidate.ThumbImpression = row["ThumbImpression"] as string ?? string.Empty;
                        candidate.Photo = row["Photo"] as byte[] ??null;
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                #region Close connection
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                #endregion
            }
            return candidate;
        }

        public static List<Rank> GetRanks(int userID, string searchValue)
        {
            #region Declaration
            List<Rank> ranks = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();
            if (userID != -1)
            {
                param.Add(new SqlParameter("@UserID", userID));
            }
            if (!string.IsNullOrEmpty(searchValue))
            {
                param.Add(new SqlParameter("@SearchValue", searchValue));
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowRank", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    ranks = new List<Rank>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Rank rank = new Rank();

                        rank.RankName = row["Rank"] as string ?? string.Empty;
                        ranks.Add(rank);
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                #region Close connection
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                #endregion
            }
            return ranks;
        }

        public static List<Rank> GetUnits(int userID, string searchValue)
        {
            #region Declaration
            List<Rank> ranks = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();
            if (userID != -1)
            {
                param.Add(new SqlParameter("@UserID", userID));
            }
            if (!string.IsNullOrEmpty(searchValue))
            {
                param.Add(new SqlParameter("@SearchValue", searchValue));
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowUnit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    ranks = new List<Rank>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Rank rank = new Rank();

                        rank.UnitName = row["Unit"] as string ?? string.Empty;
                        ranks.Add(rank);
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                #region Close connection
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                #endregion
            }
            return ranks;
        }

        public static Candidate SaveByExcel(Candidate candidate, int candidateID)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@Role", DbType = DbType.String, Value = candidate.Role},
                new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = candidate.Name},
                new SqlParameter{ParameterName = "@ContactNumber", DbType = DbType.String, Value = candidate.ContactNumber},
                new SqlParameter{ParameterName = "@ServiceNo", DbType = DbType.String, Value = candidate.RoleID},
                //new SqlParameter{ParameterName = "@Rank", DbType = DbType.String, Value = candidate.Rank},
                //new SqlParameter{ParameterName = "@Unit", DbType = DbType.String, Value = candidate.Unit},
                //new SqlParameter{ParameterName = "@CountryID", DbType = DbType.Int32, Value = candidate.CountryID},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = candidate.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (candidateID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@CandidateID", DbType = DbType.Int32, Value = candidateID });
            }
            if (candidate.CourseID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@CourseID", DbType = DbType.Int32, Value = candidate.CourseID });
            }
            if (!string.IsNullOrEmpty(candidate.FromDate))
            {
                param.Add(new SqlParameter { ParameterName = "@FromDate", DbType = DbType.Date, Value = candidate.FromDate });
            }
            if (!string.IsNullOrEmpty(candidate.ToDate))
            {
                param.Add(new SqlParameter { ParameterName = "@ToDate", DbType = DbType.Date, Value = candidate.ToDate });
            }
            if (!string.IsNullOrEmpty(candidate.Battalion))
            {
                param.Add(new SqlParameter { ParameterName = "@Battalion", DbType = DbType.String, Value = candidate.Battalion });
            }
            if (!string.IsNullOrEmpty(candidate.TOSDate))
            {
                param.Add(new SqlParameter { ParameterName = "@TOSDate", DbType = DbType.Date, Value = candidate.TOSDate });
            }
            if (!string.IsNullOrEmpty(candidate.SOSDate))
            {
                param.Add(new SqlParameter { ParameterName = "@SOSDate", DbType = DbType.Date, Value = candidate.SOSDate });
            }
            if (candidate.ThumbImpression != null && candidate.ThumbImpression.Length > 0)
            {
                param.Add(new SqlParameter { ParameterName = "@ThumbImpression", DbType = DbType.String, Value = candidate.ThumbImpression });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SaveCandidate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                candidate.CandidateID = id;
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                #region Close connection
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                #endregion
            }
            return candidate;
        }

        public static Candidate GetCandidateByBarcode(string barcode)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Candidate candidate = null;
            SqlParameter param = new SqlParameter { ParameterName = "@Barcode", Value = barcode, DbType = DbType.String };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowCandidate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    candidate = new Candidate();
                    foreach (DataRow row in dt.Rows)
                    {
                        candidate.CandidateID = row["CandidateID"] as int? ?? 0;
                        candidate.Barcode = row["Barcode"] as string ?? string.Empty;
                        candidate.Role = row["Role"] as string ?? string.Empty;
                        candidate.Name = row["Name"] as string ?? string.Empty;
                        candidate.ContactNumber = row["ContactNumber"] as string ?? string.Empty;
                        candidate.RoleID = row["ServiceNo"] as string ?? string.Empty;
                        //candidate.Rank = row["Rank"] as string ?? string.Empty;
                        //candidate.Unit = row["Unit"] as string ?? string.Empty;
                        //candidate.CountryID = row["CountryID"] as int? ?? 0;
                        //candidate.CountryName = row["CountryName"] as string ?? string.Empty;
                        candidate.CourseID = row["CourseID"] as int? ?? 0;
                        candidate.CourseName = row["CourseName"] as string ?? string.Empty;
                        candidate.FromDate = row["FromDate"] as string ?? string.Empty;
                        candidate.ToDate = row["ToDate"] as string ?? string.Empty;
                        //candidate.Battalion = row["Battalion"] as string ?? string.Empty;
                        candidate.TOSDate = row["TOSDate"] as string ?? string.Empty;
                        candidate.SOSDate = row["SOSDate"] as string ?? string.Empty;
                        candidate.ThumbImpression = row["ThumbImpression"] as string ?? string.Empty;
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                #region Close connection
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                #endregion
            }
            return candidate;
        }
    }
}
