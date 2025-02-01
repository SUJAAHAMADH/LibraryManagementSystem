using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public static class PublisherDAL
    {
        public static Publisher Save(Publisher publisher, int publisherID)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = publisher.Name},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = publisher.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (publisherID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@PublisherID", DbType = DbType.Int32, Value = publisherID });
            }
            if (!string.IsNullOrEmpty(publisher.ContactNumber))
            {
                param.Add(new SqlParameter { ParameterName = "@ContactNumber", DbType = DbType.String, Value = publisher.ContactNumber });
            }

            if (!string.IsNullOrEmpty(publisher.AlternateContactNumber))
            {
                param.Add(new SqlParameter { ParameterName = "@AlternateContactNumber", DbType = DbType.String, Value = publisher.AlternateContactNumber });
            }
            if (!string.IsNullOrEmpty(publisher.EmailID))
            {
                param.Add(new SqlParameter { ParameterName = "@EmailID", DbType = DbType.String, Value = publisher.EmailID });
            }
            if (!string.IsNullOrEmpty(publisher.Fax))
            {
                param.Add(new SqlParameter { ParameterName = "@Fax", DbType = DbType.String, Value = publisher.Fax });
            }
            if (!string.IsNullOrEmpty(publisher.Website))
            {
                param.Add(new SqlParameter { ParameterName = "@Website", DbType = DbType.String, Value = publisher.Website });
            }
            if (!string.IsNullOrEmpty(publisher.Address))
            {
                param.Add(new SqlParameter { ParameterName = "@Address", DbType = DbType.String, Value = publisher.Address });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SavePublisher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                publisher.PublisherID = id;
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
            return publisher;
        }

        public static List<Publisher> Get(int userID, string searchValue)
        {
            #region Declaration
            List<Publisher> publishers = null;
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
                SqlCommand cmd = new SqlCommand("ShowPublisher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    publishers = new List<Publisher>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Publisher publisher = new Publisher();

                        publisher.PublisherID = row["PublisherID"] as int? ?? 0;
                        publisher.Name = row["Name"] as string ?? string.Empty;
                        publisher.ContactNumber = row["ContactNumber"] as string ?? string.Empty;
                        publisher.AlternateContactNumber = row["AlternateContactNumber"] as string ?? string.Empty;
                        publisher.EmailID = row["EmailID"] as string ?? string.Empty;
                        publisher.Fax = row["Fax"] as string ?? string.Empty;
                        publisher.Website = row["Website"] as string ?? string.Empty;
                        publisher.Address = row["Address"] as string ?? string.Empty;
                        publishers.Add(publisher);
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
            return publishers;
        }

        public static Publisher GetByID(int publisherID)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Publisher publisher = null;
            SqlParameter param = new SqlParameter { ParameterName = "@PublisherID", Value = publisherID, DbType = DbType.Int32 };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowPublisher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    publisher = new Publisher();
                    foreach (DataRow row in dt.Rows)
                    {
                        publisher.PublisherID = row["PublisherID"] as int? ?? 0;
                        publisher.Name = row["Name"] as string ?? string.Empty;
                        publisher.ContactNumber = row["ContactNumber"] as string ?? string.Empty;
                        publisher.AlternateContactNumber = row["AlternateContactNumber"] as string ?? string.Empty;
                        publisher.EmailID = row["EmailID"] as string ?? string.Empty;
                        publisher.Fax = row["Fax"] as string ?? string.Empty;
                        publisher.Website = row["Website"] as string ?? string.Empty;
                        publisher.Address = row["Address"] as string ?? string.Empty;
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
            return publisher;
        }

        public static Publisher Deactive(Publisher publisher)
        {
            #region Declaration
            SqlConnection con = null;

            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@PublisherID", DbType = DbType.Int32, Value = publisher.PublisherID},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = publisher.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("DeactivePublisher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                publisher.PublisherID = id;
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
            return publisher;
        }

        public static Publisher GetByName(string name, int userID)
        {
            #region Declaration
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Publisher publisher = null;
            SqlParameter param = new SqlParameter { ParameterName = "@SearchValue", Value = name, DbType = DbType.String };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                cmd = new SqlCommand("ShowPublisher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    publisher = new Publisher();
                    foreach (DataRow row in dt.Rows)
                    {
                        publisher.PublisherID = row["PublisherID"] as int? ?? 0;
                        publisher.Name = row["Name"] as string ?? string.Empty;
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

                    cmd = new SqlCommand("SavePublisher", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(paramAdd.ToArray());
                    cmd.ExecuteNonQuery();
                    string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                    if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new Exception(outputMessage);
                    }
                    int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                    publisher = new Publisher();
                    publisher.PublisherID = id;
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
            return publisher;
        }
    }
}
