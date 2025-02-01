using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public static class CountryDAL
    {
        public static Country Save(Country country, int countryID)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = country.Name},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = country.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (countryID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@CountryID", DbType = DbType.Int32, Value = countryID });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SaveCountry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                country.CountryID = id;
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
            return country;
        }

        public static List<Country> Get(int userID, string searchValue)
        {
            #region Declaration
            List<Country> countries = null;
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
                SqlCommand cmd = new SqlCommand("ShowCountry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    countries = new List<Country>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Country country = new Country();

                        country.CountryID = row["CountryID"] as int? ?? 0;
                        country.Name = row["Name"] as string ?? string.Empty;
                        countries.Add(country);
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
            return countries;
        }

        public static Country GetByID(int countryID)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Country country = null;
            SqlParameter param = new SqlParameter { ParameterName = "@CountryID", Value = countryID, DbType = DbType.Int32 };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowCountry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    country = new Country();
                    foreach (DataRow row in dt.Rows)
                    {
                        country.CountryID = row["CountryID"] as int? ?? 0;
                        country.Name = row["Name"] as string ?? string.Empty;
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
            return country;
        }

        public static Country GetByName(string name, int userID)
        {
            #region Declaration
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Country country = null;
            SqlParameter param = new SqlParameter { ParameterName = "@SearchValue", Value = name, DbType = DbType.String };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                cmd = new SqlCommand("ShowCountry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    country = new Country();
                    foreach (DataRow row in dt.Rows)
                    {
                        country.CountryID = row["CountryID"] as int? ?? 0;
                        country.Name = row["Name"] as string ?? string.Empty;
                    }
                }
                else{
                    
                    List<SqlParameter> paramAdd = new List<SqlParameter>
                    {
                        new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = name},
                        new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = userID},
                        new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                        new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
                    };

                    cmd = new SqlCommand("SaveCountry", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(paramAdd.ToArray());
                    cmd.ExecuteNonQuery();
                    string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                    if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new Exception(outputMessage);
                    }
                    int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                    country = new Country();
                    country.CountryID = id;
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
            return country;
        }
    }
}
