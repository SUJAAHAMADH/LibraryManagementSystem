using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public class CategoryDAL
    {
        public static Category Save(Category category, int categoryID)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = category.Name},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = category.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (categoryID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@CategoryID", DbType = DbType.Int32, Value = categoryID });
            }
            if (category.ParentID != null)
            {
                param.Add(new SqlParameter { ParameterName = "@ParentID", DbType = DbType.Int32, Value = category.ParentID.Value });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SaveCategory", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                category.CategoryID = id;
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
            return category;
        }

        public static List<Category> Get(int userID, int parentID, string searchValue)
        {
            #region Declaration
            List<Category> categories = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();
            if (userID != -1)
            {
                param.Add(new SqlParameter("@UserID", userID));
            }
            if (parentID != -1)
            {
                param.Add(new SqlParameter("@ParentID", parentID));
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
                SqlCommand cmd = new SqlCommand("ShowCategory", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    categories = new List<Category>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Category category = new Category();

                        category.CategoryID = row["CategoryID"] as int? ?? 0;
                        category.Name = row["Name"] as string ?? string.Empty;
                        category.ParentID = row["ParentID"] as int? ?? 0;
                        categories.Add(category);
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
            return categories;
        }

        public static Category GetByID(int categoryID)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Category category = null;
            SqlParameter param = new SqlParameter { ParameterName = "@CategoryID", Value = categoryID, DbType = DbType.Int32 };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowCategory", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    category = new Category();
                    foreach (DataRow row in dt.Rows)
                    {
                        category.CategoryID = row["CategoryID"] as int? ?? 0;
                        category.Name = row["Name"] as string ?? string.Empty;
                        category.ParentID = row["ParentID"] as int? ?? 0;
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
            return category;
        }

        public static Category Deactive(Category category)
        {
            #region Declaration
            SqlConnection con = null;

            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@CategoryID", DbType = DbType.Int32, Value = category.CategoryID},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = category.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("DeactiveAuthor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                category.CategoryID = id;
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
            return category;
        }

        public static Category GetByName(string name, int userID)
        {
            #region Declaration
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Category category = null;
            SqlParameter param = new SqlParameter { ParameterName = "@SearchValue", Value = name, DbType = DbType.String };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                cmd = new SqlCommand("ShowCategoryByName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    category = new Category();
                    foreach (DataRow row in dt.Rows)
                    {
                        category.CategoryID = row["CategoryID"] as int? ?? 0;
                        category.Name = row["Name"] as string ?? string.Empty;
                        category.ParentID = row["ParentID"] as int? ?? 0;
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
            return category;
        }

        public static List<Category> GetAll()
        {
            #region Declaration
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<Category> categories = null;         
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                cmd = new SqlCommand("ShowCategoryByName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    categories = new List<Category>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Category category = new Category();
                        category.CategoryID = row["CategoryID"] as int? ?? 0;
                        category.Name = row["Name"] as string ?? string.Empty;
                        category.ParentID = row["ParentID"] as int? ?? 0;
                        category.ParentName = category.ParentID == 1 ? "Technical" : "Others";
                        categories.Add(category);
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
            return categories;
        }

        public static Category DeactiveCategory(Category category)
        {
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@CategoryID", DbType = DbType.Int32, Value = category.CategoryID },
                new SqlParameter { ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000 }
            };

            try
            {
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("[DeactiveCategory]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();

                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return category;
        }
    }
}
