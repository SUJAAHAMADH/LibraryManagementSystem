using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public static class UserDAL
    {
        public static List<User> Get(string role, int createdBy, string searchValue,string thumbImpression)
        {
            #region Declaration
            List<User> users = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(role))
            {
                param.Add(new SqlParameter("@Role", role));
            }
            if (createdBy != -1)
            {
                param.Add(new SqlParameter("@CreatedBy", createdBy));
            }
            if (!string.IsNullOrEmpty(searchValue))
            {
                param.Add(new SqlParameter("@SearchValue", searchValue));
            }
            if (!string.IsNullOrEmpty(thumbImpression))
            {
                param.Add(new SqlParameter("@ThumbImpression", thumbImpression));
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    users = new List<User>();
                    foreach (DataRow row in dt.Rows)
                    {
                        User user = new User();

                        user.UserID = row["UserID"] as int? ?? 0;
                        user.Name = row["Name"] as string ?? string.Empty;
                        user.ContactNumber = row["ContactNumber"] as string ?? string.Empty;
                        user.Email = row["Email"] as string ?? string.Empty;
                        user.UserName = row["UserName"] as string ?? string.Empty;
                        user.Password = row["Password"] as string ?? string.Empty;
                        user.ThumbImpression = row["ThumbImpression"] as string ?? string.Empty;
                        user.UID = row["UID"] as string ?? string.Empty;
                        user.Role = row["Role"] as string ?? string.Empty;
                        users.Add(user);
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
            return users;
        }

        public static User GetByID(int userID)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            User user = null;
            SqlParameter param = new SqlParameter { ParameterName = "@UserID", Value = userID, DbType = DbType.Int32 };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    user = new User();
                    foreach (DataRow row in dt.Rows)
                    {
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
        
        public static User Deactive(User user)
        {
            #region Declaration
            SqlConnection con = null;

            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = user.UserID},
                new SqlParameter{ParameterName = "@CreatedBy", DbType = DbType.Int32, Value = user.CreatedBy},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("DeactiveUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                user.UserID = id;
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

    }
}
