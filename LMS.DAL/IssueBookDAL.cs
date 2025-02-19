using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace LMS.DAL
{
    public static class IssueBookDAL
    {
        public static IssueBook SaveIssueBook(IssueBook issueBook, int issueBookID)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@BookBarcodeID", DbType = DbType.Int32, Value = issueBook.BookBarcodeID},
                new SqlParameter{ParameterName = "@CandidateID", DbType = DbType.Int32, Value = issueBook.CandidateID},
                new SqlParameter{ParameterName = "@IssuedOn", DbType = DbType.Date, Value = issueBook.IssuedOn},
                new SqlParameter{ParameterName = "@ReturnDate", DbType = DbType.Date, Value = issueBook.ReturnDate},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = issueBook.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (issueBookID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@IssueBookID", DbType = DbType.Int32, Value = issueBookID });
            }
            if (!string.IsNullOrEmpty(issueBook.Remark))
            {
                param.Add(new SqlParameter { ParameterName = "@Remark", DbType = DbType.String, Value = issueBook.Remark });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SaveIssueBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                issueBook.IssueBookID = id;
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
            return issueBook;
        }

        public static List<IssueBook> GetIssueBook(int userID, int bookBarcodeID, int candidateID, string barcode, string searchValue, string startDate = null, string endDate = null)
        {
            #region Declaration
            List<IssueBook> issueBooks = null;
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
            if (candidateID != -1)
            {
                param.Add(new SqlParameter("@CandidateID", candidateID));
            }
            if (!string.IsNullOrEmpty(barcode))
            {
                param.Add(new SqlParameter("@Barcode", barcode));
            }
            if (!string.IsNullOrEmpty(searchValue))
            {
                param.Add(new SqlParameter("@SearchValue", searchValue));
            }
            if (!string.IsNullOrEmpty(startDate))
            {
                param.Add(new SqlParameter
                {
                    ParameterName = "@StartDate",
                    DbType = DbType.Date,
                    Value = DateTime.ParseExact(startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)
                });
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                param.Add(new SqlParameter
                {
                    ParameterName = "@EndDate",
                    DbType = DbType.Date,
                    Value = DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)
                });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowIssueBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    issueBooks = new List<IssueBook>();
                    foreach (DataRow row in dt.Rows)
                    {
                        IssueBook issueBook = new IssueBook();

                        issueBook.IssueBookID = row["IssueBookID"] as int? ?? 0;
                        issueBook.BookBarcodeID = row["BookBarcodeID"] as int? ?? 0;
                        issueBook.BookBarcode = row["BookBarcode"] as string ?? string.Empty;
                        issueBook.BookID = row["BookID"] as int? ?? 0;
                        issueBook.BookName = row["BookName"] as string ?? string.Empty;
                        issueBook.CandidateID = row["CandidateID"] as int? ?? 0;
                        issueBook.IssuedOn = row["IssuedOn"] as DateTime? ?? null;
                        issueBook.ReturnDate = row["ReturnDate"] as DateTime? ?? null;
                        issueBook.ReturnedOn = row["ReturnedOn"] as DateTime? ?? null;
                        issueBook.RenewalOn = row["LastRenewaledOn"] as DateTime? ?? null;
                        issueBook.NoOfTimeRenewal = row["NoOfTimeRenewal"] as int? ?? 0;
                        issueBook.Remark = row["Remark"] as string ?? string.Empty;
                        issueBook.CandidateNames = row["CandidateNames"] as string ?? string.Empty;
                        issueBook.RollId = row["ROllNo"] as string ?? string.Empty;
                        issueBooks.Add(issueBook);
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
            return issueBooks;
        }

        public static IssueBook SaveReturnBook(IssueBook issueBook, int issueBookID)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@BookBarcodeID", DbType = DbType.Int32, Value = issueBook.BookBarcodeID},
                new SqlParameter{ParameterName = "@CandidateID", DbType = DbType.Int32, Value = issueBook.CandidateID},
                new SqlParameter{ParameterName = "@ReturnedOn", DbType = DbType.Date, Value = issueBook.ReturnDate},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = issueBook.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (issueBookID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@IssueBookID", DbType = DbType.Int32, Value = issueBookID });
            }
            if (!string.IsNullOrEmpty(issueBook.Remark))
            {
                param.Add(new SqlParameter { ParameterName = "@Remark", DbType = DbType.String, Value = issueBook.Remark });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SaveReturnBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                issueBook.IssueBookID = id;
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
            return issueBook;
        }

        public static List<IssueBook> GetReturnBook(int userID, int bookBarcodeID, int candidateID, string searchValue, string startDate = null, string endDate = null)
        {
            #region Declaration
            List<IssueBook> issueBooks = null;
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
            if (candidateID != -1)
            {
                param.Add(new SqlParameter("@CandidateID", candidateID));
            }
            if (!string.IsNullOrEmpty(searchValue))
            {
                param.Add(new SqlParameter("@SearchValue", searchValue));
            }
            if (!string.IsNullOrEmpty(startDate))
            {
                param.Add(new SqlParameter { ParameterName = "@StartDate", DbType = DbType.Date, Value = DateTime.ParseExact(startDate, "dd-MM-yyyy", null) });
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                param.Add(new SqlParameter { ParameterName = "@EndDate", DbType = DbType.Date, Value = DateTime.ParseExact(endDate, "dd-MM-yyyy", null) });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowReturnBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    issueBooks = new List<IssueBook>();
                    foreach (DataRow row in dt.Rows)
                    {
                        IssueBook issueBook = new IssueBook();

                        issueBook.IssueBookID = row["IssueBookID"] as int? ?? 0;
                        issueBook.BookBarcodeID = row["BookBarcodeID"] as int? ?? 0;
                        issueBook.BookBarcode = row["BookBarcode"] as string ?? string.Empty;
                        issueBook.BookID = row["BookID"] as int? ?? 0;
                        issueBook.BookName = row["BookName"] as string ?? string.Empty;
                        issueBook.CandidateID = row["CandidateID"] as int? ?? 0;
                        issueBook.IssuedOn = row["IssuedOn"] as DateTime? ?? null;
                        issueBook.ReturnDate = row["ReturnDate"] as DateTime? ?? null;
                        issueBook.ReturnedOn = row["ReturnedOn"] as DateTime? ?? null;
                        issueBook.RenewalOn = row["LastRenewaledOn"] as DateTime? ?? null;
                        issueBook.NoOfTimeRenewal = row["NoOfTimeRenewal"] as int? ?? 0;
                        issueBook.Remark = row["Remark"] as string ?? string.Empty;
                        issueBook.CandidateName = row["CandidateName"] as string ?? string.Empty;
                        issueBooks.Add(issueBook);
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
            return issueBooks;
        }

        public static IssueBook SaveRenewalBook(IssueBook issueBook, int issueBookID)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@BookBarcodeID", DbType = DbType.Int32, Value = issueBook.BookBarcodeID},
                new SqlParameter{ParameterName = "@CandidateID", DbType = DbType.Int32, Value = issueBook.CandidateID},
                new SqlParameter{ParameterName = "@ReturnDate", DbType = DbType.Date, Value = issueBook.ReturnDate},
                new SqlParameter{ParameterName = "@RenewalOn", DbType = DbType.Date, Value =  issueBook.RenewalOn},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = issueBook.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (issueBookID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@IssueBookID", DbType = DbType.Int32, Value = issueBookID });
            }
            if (!string.IsNullOrEmpty(issueBook.Remark))
            {
                param.Add(new SqlParameter { ParameterName = "@Remark", DbType = DbType.String, Value = issueBook.Remark });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SaveRenewalBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                issueBook.IssueBookID = id;
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
            return issueBook;
        }

        public static List<IssueBook> GetRenewalBook(int userID, int bookBarcodeID, int candidateID, string searchValue, string startDate = null, string endDate = null)
        {
            #region Declaration
            List<IssueBook> issueBooks = null;
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
            if (candidateID != -1)
            {
                param.Add(new SqlParameter("@CandidateID", candidateID));
            }
            if (!string.IsNullOrEmpty(searchValue))
            {
                param.Add(new SqlParameter("@SearchValue", searchValue));
            }
            if (!string.IsNullOrEmpty(startDate))
            {
                param.Add(new SqlParameter { ParameterName = "@StartDate", DbType = DbType.Date, Value = DateTime.ParseExact(startDate, "dd-MM-yyyy", null) });
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                param.Add(new SqlParameter { ParameterName = "@EndDate", DbType = DbType.Date, Value = DateTime.ParseExact(endDate, "dd-MM-yyyy", null) });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowRenewalBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    issueBooks = new List<IssueBook>();
                    foreach (DataRow row in dt.Rows)
                    {
                        IssueBook issueBook = new IssueBook();

                        issueBook.IssueBookID = row["IssueBookID"] as int? ?? 0;
                        issueBook.BookBarcodeID = row["BookBarcodeID"] as int? ?? 0;
                        issueBook.BookBarcode = row["BookBarcode"] as string ?? string.Empty;
                        issueBook.BookID = row["BookID"] as int? ?? 0;
                        issueBook.BookName = row["BookName"] as string ?? string.Empty;
                        issueBook.CandidateID = row["CandidateID"] as int? ?? 0;
                        issueBook.IssuedOn = row["IssuedOn"] as DateTime? ?? null;
                        issueBook.ReturnDate = row["ReturnDate"] as DateTime? ?? null;
                        issueBook.ReturnedOn = row["ReturnedOn"] as DateTime? ?? null;
                        issueBook.RenewalOn = row["LastRenewaledOn"] as DateTime? ?? null;
                        issueBook.NoOfTimeRenewal = row["NoOfTimeRenewal"] as int? ?? 0;
                        issueBook.Remark = row["Remark"] as string ?? string.Empty;
                        issueBook.CandidateName = row["CandidateName"] as string ?? string.Empty;
                        issueBooks.Add(issueBook);
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
            return issueBooks;
        }

        public static List<BookHistory> GetBookHistory(int userID, int bookBarcodeID, int candidateID, string barcode, string searchValue)
        {
            #region Declaration
            List<BookHistory> bookHistories = null;
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
            if (candidateID != -1)
            {
                param.Add(new SqlParameter("@CandidateID", candidateID));
            }
            if (!string.IsNullOrEmpty(barcode))
            {
                param.Add(new SqlParameter("@Barcode", barcode));
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
                SqlCommand cmd = new SqlCommand("ShowBookHistory", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    bookHistories = new List<BookHistory>();
                    foreach (DataRow row in dt.Rows)
                    {
                        BookHistory bookHistory = new BookHistory();

                        bookHistory.BookHistoryID = row["BookHistoryID"] as int? ?? 0;
                        bookHistory.BookBarcodeID = row["BookBarcodeID"] as int? ?? 0;
                        bookHistory.BookBarcode = row["BookBarcode"] as string ?? string.Empty;
                        bookHistory.CandidateID = row["CandidateID"] as int? ?? 0;
                        bookHistory.Date = row["Date"] as DateTime? ?? null;
                        bookHistory.Status = row["Status"] as string ?? string.Empty;
                        bookHistory.UserName = row["Name"] as string ?? string.Empty;
                        bookHistory.Role = row["Role"] as string ?? string.Empty;
                        bookHistory.Unit = row["Unit"] as string ?? string.Empty;
                        bookHistory.ContactNumber = row["ContactNumber"] as string ?? string.Empty;
                        bookHistory.BookName = row["BookName"] as string ?? string.Empty;
                        bookHistory.Language = row["Language"] as string ?? string.Empty;
                        bookHistory.Price = row["Price"] as decimal? ?? 0;
                        //bookHistory.ReturnDate = row["ReturnDate"] as DateTime? ?? null;
                        //bookHistory.ReturnedOn = row["ReturnedOn"] as DateTime? ?? null;
                        bookHistories.Add(bookHistory);
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
            return bookHistories;
        }

        public static IssueBook GetIssueBookByBarcode(string barcode)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            IssueBook issueBook = null;
            SqlParameter param = new SqlParameter { ParameterName = "@Barcode", Value = barcode, DbType = DbType.String };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowIssueBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    issueBook = new IssueBook();
                    foreach (DataRow row in dt.Rows)
                    {
                        issueBook.IssueBookID = row["IssueBookID"] as int? ?? 0;
                        issueBook.BookBarcodeID = row["BookBarcodeID"] as int? ?? 0;
                        issueBook.BookBarcode = row["BookBarcode"] as string ?? string.Empty;
                        issueBook.BookID = row["BookID"] as int? ?? 0;
                        issueBook.CandidateID = row["CandidateID"] as int? ?? 0;
                        issueBook.IssuedOn = row["IssuedOn"] as DateTime? ?? null;
                        issueBook.ReturnDate = row["ReturnDate"] as DateTime? ?? null;
                        issueBook.ReturnedOn = row["ReturnedOn"] as DateTime? ?? null;
                        issueBook.RenewalOn = row["LastRenewaledOn"] as DateTime? ?? null;
                        issueBook.NoOfTimeRenewal = row["NoOfTimeRenewal"] as int? ?? 0;
                        issueBook.Remark = row["Remark"] as string ?? string.Empty;
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
            return issueBook;
        }

        public static List<IssueBook> GetLatestIssueBook(int userID, int bookBarcodeID, int candidateID, string barcode, string searchValue)
        {
            #region Declaration
            List<IssueBook> issueBooks = null;
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
            if (candidateID != -1)
            {
                param.Add(new SqlParameter("@CandidateID", candidateID));
            }
            if (!string.IsNullOrEmpty(barcode))
            {
                param.Add(new SqlParameter("@Barcode", barcode));
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
                SqlCommand cmd = new SqlCommand("LatestIssueBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    issueBooks = new List<IssueBook>();
                    foreach (DataRow row in dt.Rows)
                    {
                        IssueBook issueBook = new IssueBook();

                        issueBook.IssueBookID = row["IssueBookID"] as int? ?? 0;
                        issueBook.BookBarcodeID = row["BookBarcodeID"] as int? ?? 0;
                        issueBook.BookBarcode = row["BookBarcode"] as string ?? string.Empty;
                        issueBook.BookID = row["BookID"] as int? ?? 0;
                        issueBook.BookName = row["BookName"] as string ?? string.Empty;
                        issueBook.CandidateID = row["CandidateID"] as int? ?? 0;
                        issueBook.IssuedOn = row["IssuedOn"] as DateTime? ?? null;
                        issueBook.ReturnDate = row["ReturnDate"] as DateTime? ?? null;
                        issueBook.ReturnedOn = row["ReturnedOn"] as DateTime? ?? null;
                        issueBook.RenewalOn = row["LastRenewaledOn"] as DateTime? ?? null;
                        issueBook.NoOfTimeRenewal = row["NoOfTimeRenewal"] as int? ?? 0;
                        issueBook.Remark = row["Remark"] as string ?? string.Empty;
                        issueBook.CandidateName = row["CandidateName"] as string ?? string.Empty;
                        issueBooks.Add(issueBook);
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
            return issueBooks;
        }

        public static List<IssueBook> GetMonthlyTransaction(int userID, int bookBarcodeID, int candidateID, string barcode, string searchValue, string startDate = null, string endDate = null)
        {
            #region Declaration
            List<IssueBook> issueBooks = null;
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
            if (candidateID != -1)
            {
                param.Add(new SqlParameter("@CandidateID", candidateID));
            }
            if (!string.IsNullOrEmpty(barcode))
            {
                param.Add(new SqlParameter("@Barcode", barcode));
            }
            if (!string.IsNullOrEmpty(searchValue))
            {
                param.Add(new SqlParameter("@SearchValue", searchValue));
            }
            if (!string.IsNullOrEmpty(startDate))
            {
                param.Add(new SqlParameter
                {
                    ParameterName = "@StartDate",
                    DbType = DbType.Date,
                    Value = DateTime.ParseExact(startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)
                });
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                param.Add(new SqlParameter
                {
                    ParameterName = "@EndDate",
                    DbType = DbType.Date,
                    Value = DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)
                });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowBookTransactionInMonth", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    issueBooks = new List<IssueBook>();
                    foreach (DataRow row in dt.Rows)
                    {
                        IssueBook issueBook = new IssueBook();

                        issueBook.IssueBookID = row["IssueBookID"] as int? ?? 0;
                        issueBook.BookBarcodeID = row["BookBarcodeID"] as int? ?? 0;
                        issueBook.BookBarcode = row["BookBarcode"] as string ?? string.Empty;
                        issueBook.BookID = row["BookID"] as int? ?? 0;
                        issueBook.BookName = row["BookName"] as string ?? string.Empty;
                        issueBook.CandidateID = row["CandidateID"] as int? ?? 0;
                        issueBook.IssuedOn = row["IssuedOn"] as DateTime? ?? null;
                        issueBook.ReturnDate = row["ReturnDate"] as DateTime? ?? null;
                        issueBook.ReturnedOn = row["ReturnedOn"] as DateTime? ?? null;
                        issueBook.RenewalOn = row["LastRenewaledOn"] as DateTime? ?? null;
                        issueBook.NoOfTimeRenewal = row["NoOfTimeRenewal"] as int? ?? 0;
                        issueBook.Remark = row["Remark"] as string ?? string.Empty;
                        issueBook.CandidateNames = row["CandidateNames"] as string ?? string.Empty;
                        issueBook.RollId = row["ROllNo"] as string ?? string.Empty;
                        issueBooks.Add(issueBook);
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
            return issueBooks;
        }
    }
}