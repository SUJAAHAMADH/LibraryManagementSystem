using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public static class AuthDAL
    {
        public static User LoginValidateUser(Login login)
        {
            #region Declaration
            User user = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@UserName", DbType = DbType.String, Value = login.UserName},
                new SqlParameter{ParameterName = "@Password", DbType = DbType.String, Value = login.Password},
                new SqlParameter{ParameterName = "@Role", DbType = DbType.String, Value = login.Role}
            };
            #endregion
            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("LoginValidateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
                {
                    user = new User();
                    DataRow row = dt.Rows[0];
                    user.UserID = row["UserID"] as int? ?? 0;
                    user.Name = row["Name"] as string ?? string.Empty;
                    user.ContactNumber = row["ContactNumber"] as string ?? string.Empty;
                    user.Email = row["Email"] as string ?? string.Empty;
                    user.UserName = row["UserName"] as string ?? string.Empty;
                    user.Password = row["Password"] as string ?? string.Empty;
                    //user.ThumbImpression = row["ThumbImpression"] as string ?? string.Empty;
                    user.UID = row["UID"] as string ?? string.Empty;
                    user.Role = row["Role"] as string ?? string.Empty;
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
            return user;
        }

        public static User Register(User user, int userID)
        {
            #region Declaration
            SqlConnection con = null;
            SqlCommand cmd = null;

            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = user.Name},
                new SqlParameter{ParameterName = "@Role", DbType = DbType.String, Value = user.Role},
                new SqlParameter{ParameterName = "@CreatedBy", DbType = DbType.Int32, Value = user.CreatedBy},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (userID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@UserID", DbType = DbType.Int32, Value = userID });
            }
            if (!string.IsNullOrEmpty(user.ContactNumber))
            {
                param.Add(new SqlParameter { ParameterName = "@ContactNumber", DbType = DbType.String, Value = user.ContactNumber });
            }
            if (!string.IsNullOrEmpty(user.Email))
            {
                param.Add(new SqlParameter { ParameterName = "@Email", DbType = DbType.String, Value = user.Email });
            }
            if (!string.IsNullOrEmpty(user.UserName))
            {
                param.Add(new SqlParameter { ParameterName = "@UserName", DbType = DbType.String, Value = user.UserName });
            }
            if (!string.IsNullOrEmpty(user.Password))
            {
                param.Add(new SqlParameter { ParameterName = "@Password", DbType = DbType.String, Value = user.Password });
            }
            if (user.ThumbImpression != null && user.ThumbImpression.Length > 0)
            {
                param.Add(new SqlParameter { ParameterName = "@ThumbImpression", DbType = DbType.String, Value = user.ThumbImpression });
            }
            if (!string.IsNullOrEmpty(user.UID))
            {
                param.Add(new SqlParameter { ParameterName = "@UID", DbType = DbType.String, Value = user.UID });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                cmd = new SqlCommand("SaveUser", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                user.UserID = cmd.Parameters["@ID"].Value as int? ?? 0;
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
            return user;
        }

        public static bool ChangePassword(ChangePassword changePassword)
        {
            #region Declaration
            bool hasPasswordChanged = false;
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int16, Value = changePassword.UserID},
                new SqlParameter{ParameterName = "@CurrentPassword", DbType = DbType.String, Value = changePassword.CurrentPassword},
                new SqlParameter{ParameterName = "@NewPassword", DbType = DbType.String, Value = changePassword.NewPassword},
                new SqlParameter{ParameterName = "@CreatedBy", DbType = DbType.String, Value = changePassword.CreatedBy},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            #endregion
            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ChangePassword", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                hasPasswordChanged = true;
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
            return hasPasswordChanged;
        }

        public static User UpdateProfile(User user)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = user.UserID},
                new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = user.Name},
                new SqlParameter{ParameterName = "@Role", DbType = DbType.String, Value = user.Role},
                new SqlParameter{ParameterName = "@CreatedBy", DbType = DbType.Int32, Value = user.CreatedBy},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (!string.IsNullOrEmpty(user.ContactNumber))
            {
                param.Add(new SqlParameter { ParameterName = "@ContactNumber", DbType = DbType.String, Value = user.ContactNumber });
            }
            if (!string.IsNullOrEmpty(user.Email))
            {
                param.Add(new SqlParameter { ParameterName = "@Email", DbType = DbType.String, Value = user.Email });
            }
            if (!string.IsNullOrEmpty(user.UserName))
            {
                param.Add(new SqlParameter { ParameterName = "@UserName", DbType = DbType.String, Value = user.UserName });
            }
            if (!string.IsNullOrEmpty(user.Password))
            {
                param.Add(new SqlParameter { ParameterName = "@Password", DbType = DbType.String, Value = user.Password });
            }
            if (user.ThumbImpression != null && user.ThumbImpression.Length > 0)
            {
                param.Add(new SqlParameter { ParameterName = "@ThumbImpression", DbType = DbType.Byte, Value = user.ThumbImpression });
            }
            if (!string.IsNullOrEmpty(user.UID))
            {
                param.Add(new SqlParameter { ParameterName = "@UID", DbType = DbType.String, Value = user.UID });
            }
            #endregion
            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("UpdateUserProfile", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
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
            return user;
        }

        public static void SaveBackFileToComputer(string path, string fileName)
        {
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@Path", DbType = DbType.String, Value = path},
                new SqlParameter{ParameterName = "@FileName", DbType = DbType.String, Value = fileName}
            };

            try
            {
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SaveBackFileToComputerLocation", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
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
        }
    }
}
