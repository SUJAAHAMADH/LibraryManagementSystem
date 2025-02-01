using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public class LanguageDAL
    {
        public static Language Save(Language language, int languageID)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = language.Name},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = language.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (languageID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@LanguageID", DbType = DbType.Int32, Value = languageID });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SaveLanguage", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                language.LanguageID = id;
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
            return language;
        }

        public static List<Language> Get(int userID, string searchValue)
        {
            #region Declaration
            List<Language> languages = null;
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
                SqlCommand cmd = new SqlCommand("ShowLanguage", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    languages = new List<Language>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Language language = new Language();

                        language.LanguageID = row["LanguageID"] as int? ?? 0;
                        language.Name = row["Name"] as string ?? string.Empty;
                        languages.Add(language);
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
            return languages;
        }

        public static Language GetByID(int languageID)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Language language = null;
            SqlParameter param = new SqlParameter { ParameterName = "@LanguageID", Value = languageID, DbType = DbType.Int32 };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowLanguage", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    language = new Language();
                    foreach (DataRow row in dt.Rows)
                    {
                        language.LanguageID = row["LanguageID"] as int? ?? 0;
                        language.Name = row["Name"] as string ?? string.Empty;
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
            return language;
        }

        public static Language Deactive(Language language)
        {
            #region Declaration
            SqlConnection con = null;

            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@AuthorID", DbType = DbType.Int32, Value = language.LanguageID},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = language.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("DeactiveLanguage", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                language.LanguageID = id;
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
            return language;
        }

        public static Language GetByName(string name, int userID)
        {
            #region Declaration
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Language language = null;
            SqlParameter param = new SqlParameter { ParameterName = "@SearchValue", Value = name, DbType = DbType.String };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                cmd = new SqlCommand("ShowLanguage", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    language = new Language();
                    foreach (DataRow row in dt.Rows)
                    {
                        language.LanguageID = row["LanguageID"] as int? ?? 0;
                        language.Name = row["Name"] as string ?? string.Empty;
                    }
                }
                else
                {
                    List<SqlParameter> paramAdd = new List<SqlParameter>
                    {
                        new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = name},
                        new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = userID},
                        new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                        new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
                    };

                    cmd = new SqlCommand("SaveLanguage", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(paramAdd.ToArray());
                    cmd.ExecuteNonQuery();
                    string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                    if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new Exception(outputMessage);
                    }
                    int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                    language = new Language();
                    language.LanguageID = id;
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
            return language;
        }
    }
}
