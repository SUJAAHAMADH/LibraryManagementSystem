using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public static class MissingBookDAL
    {
        public static MissingBook Save(MissingBook missingBook, int missingBookID)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@BookBarcodeID", DbType = DbType.Int32, Value = missingBook.BookBarcodeID},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = missingBook.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (missingBookID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@MissingBookID", DbType = DbType.Int32, Value = missingBookID });
            }
            if (!string.IsNullOrEmpty(missingBook.Remark))
            {
                param.Add(new SqlParameter { ParameterName = "@Remark", DbType = DbType.String, Value = missingBook.Remark });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SaveMissingBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                missingBook.MissingBookID = id;
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
            return missingBook;
        }

        public static List<MissingBook> Get(int userID, int bookBarcodeID, string searchValue)
        {
            #region Declaration
            List<MissingBook> missingBooks = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();
            if (userID != -1)
            {
                param.Add(new SqlParameter("@UserID", userID));
            }
            if (bookBarcodeID != -1)
            {
                param.Add(new SqlParameter("@BookBarcodeID", bookBarcodeID));
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
                SqlCommand cmd = new SqlCommand("ShowMissingBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    missingBooks = new List<MissingBook>();
                    foreach (DataRow row in dt.Rows)
                    {
                        MissingBook missingBook = new MissingBook();

                        missingBook.MissingBookID = row["MissingBookID"] as int? ?? 0;
                        missingBook.BookBarcodeID = row["BookBarcodeID"] as int? ?? 0;
                        missingBook.BookBarcode = row["BookBarcode"] as string ?? string.Empty;
                        missingBook.BookID = row["BookID"] as int? ?? 0;
                        missingBook.BookName = row["Name"] as string ?? string.Empty;
                        missingBook.Remark = row["Remark"] as string ?? string.Empty;
                        missingBooks.Add(missingBook);
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
            return missingBooks;
        }

        public static MissingBook GetByID(int missingBookID)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            MissingBook missingBook = null;
            SqlParameter param = new SqlParameter { ParameterName = "@MissingBookID", Value = missingBookID, DbType = DbType.Int32 };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowMissingBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    missingBook = new MissingBook();
                    foreach (DataRow row in dt.Rows)
                    {
                        missingBook.MissingBookID = row["MissingBookID"] as int? ?? 0;
                        missingBook.BookBarcodeID = row["BookBarcodeID"] as int? ?? 0;
                        missingBook.BookBarcode = row["BookBarcode"] as string ?? string.Empty;
                        missingBook.BookID = row["BookID"] as int? ?? 0;
                        missingBook.BookName = row["Name"] as string ?? string.Empty;
                        missingBook.Remark = row["Remark"] as string ?? string.Empty;
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
            return missingBook;
        }
    }
}
