using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public static class BookDAL
    {
        public static Book Save(Book book, int bookID)
        {
            #region Declaration
            SqlConnection con = null;
            SqlTransaction transaction = null;
            #endregion

            try
            {
                #region Passing parameters
                List<SqlParameter> param = new List<SqlParameter>
                {
                    new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = book.Name},
                    new SqlParameter{ParameterName = "@AuthorID", DbType = DbType.Int32, Value = book.AuthorID},
                    new SqlParameter{ParameterName = "@PublisherID", DbType = DbType.Int32, Value = book.PublisherID},
                    new SqlParameter{ParameterName = "@LanguageID", DbType = DbType.Int32, Value = book.LanguageID},
                    new SqlParameter{ParameterName = "@Price", DbType = DbType.Decimal, Value = book.Price},
                    new SqlParameter{ParameterName = "@TotalQuantity", DbType = DbType.Int32, Value = book.TotalQuantity},
                    new SqlParameter{ParameterName = "@CategoryID", DbType = DbType.Int32, Value = book.CategoryID},
                    new SqlParameter{ParameterName = "@IsRestricted", DbType = DbType.Boolean, Value = book.IsRestricted},
                    new SqlParameter{ParameterName = "@Funds", DbType = DbType.String, Value = book.Funds},
                    new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = book.UserID},
                    new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                    new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
                };
                if (bookID != -1)
                {
                    param.Add(new SqlParameter { ParameterName = "@BookID", DbType = DbType.Int32, Value = bookID });
                }
                if (!string.IsNullOrEmpty(book.Edition))
                {
                    param.Add(new SqlParameter { ParameterName = "@Edition", DbType = DbType.String, Value = book.Edition });
                }
                if (!string.IsNullOrEmpty(book.Isbn))
                {
                    param.Add(new SqlParameter { ParameterName = "@ISBN", DbType = DbType.String, Value = book.Isbn });
                }
                if (!string.IsNullOrEmpty(book.Description))
                {
                    param.Add(new SqlParameter { ParameterName = "@Description", DbType = DbType.String, Value = book.Description });
                }
                #endregion

                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                transaction = con.BeginTransaction();
                SqlCommand cmd = null;
                cmd = new SqlCommand("SaveBook", con, transaction)
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
                book.BookID = cmd.Parameters["@ID"].Value as int? ?? 0;
                #endregion

                #region Processing stock adjustment items
                if(book.BookBarcodes != null)
                {
                    foreach (var item in book.BookBarcodes)
                    {
                        cmd.Parameters.Clear();
                        cmd = new SqlCommand("SaveBookBarcode", con, transaction)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        param = new List<SqlParameter>
                        {
                            new SqlParameter{ParameterName = "@BookID", DbType = DbType.Int32, Value = book.BookID},
                            new SqlParameter{ParameterName = "@Barcode", DbType = DbType.String, Value = item.Barcode},
                            new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = book.UserID},
                            new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                            new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
                        };

                        if (item.BookBarcodeID != -1)
                        {
                            param.Add(new SqlParameter { ParameterName = "@BookBarcodeID", DbType = DbType.Int32, Value = item.BookBarcodeID });
                        }
                        cmd.Parameters.AddRange(param.ToArray());
                        cmd.ExecuteNonQuery();
                        outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                        if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                        {
                            throw new Exception(outputMessage);
                        }
                        //item.BookBarcodeID = cmd.Parameters["@ID"].Value as int? ?? 0;
                    }
                }
                #endregion

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
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
            return book;

        }

        public static List<Book> Get(int userID, int authorID, int publisherID, string searchValue)
        {
            #region Declaration
            List<Book> books = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();
            if (userID != -1)
            {
                param.Add(new SqlParameter("@UserID", userID));
            }
            if (authorID != -1)
            {
                param.Add(new SqlParameter("@AuthorID", authorID));
            }
            if (publisherID != -1)
            {
                param.Add(new SqlParameter("@PublisherID", publisherID));
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
                SqlCommand cmd = new SqlCommand("ShowBook", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    books = new List<Book>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Book book = new Book
                        {
                            BookID = row["BookID"] as int? ?? 0,
                            Name = row["Name"] as string ?? string.Empty,
                            Edition = row["Edition"] as string ?? string.Empty,
                            Language = row["Language"] as string ?? string.Empty,
                            Price = row["Price"] as decimal? ?? 0,
                            Isbn = row["ISBN"] as string ?? string.Empty,
                            Description = row["Description"] as string ?? string.Empty,
                            TotalQuantity = row["TotalQuantity"] as int? ?? 0,
                            Funds = row["Funds"] as string ?? string.Empty,
                            IsRestricted = row["IsRestricted"] as bool? ?? false,

                            AuthorID = row["AuthorID"] as int? ?? 0,
                            Author = row["Author"] as string ?? string.Empty,

                            PublisherID = row["PublisherID"] as int? ?? 0,
                            Publisher = row["Publisher"] as string ?? string.Empty,

                            CategoryID = row["CategoryID"] as int? ?? 0,
                            Category = row["Category"] as string ?? string.Empty,

                        };
                        books.Add(book);
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
            return books;
        }

        public static Book GetByID(int bookID)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Book book = null;
            SqlParameter param = new SqlParameter { ParameterName = "@BookID", Value = bookID, DbType = DbType.Int32 };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowBook", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    book = new Book();
                    foreach (DataRow row in dt.Rows)
                    {
                        book.BookID = row["BookID"] as int? ?? 0;
                        book.Name = row["Name"] as string ?? string.Empty;
                        book.Edition = row["Edition"] as string ?? string.Empty;
                        book.Language = row["Language"] as string ?? string.Empty;
                        book.Price = row["Price"] as decimal? ?? 0;
                        book.Isbn = row["ISBN"] as string ?? string.Empty;
                        book.Description = row["Description"] as string ?? string.Empty;
                        book.TotalQuantity = row["TotalQuantity"] as int? ?? 0;
                        book.Funds = row["Funds"] as string ?? string.Empty;
                        book.IsRestricted = row["IsRestricted"] as bool? ?? false;

                        book.AuthorID = row["AuthorID"] as int? ?? 0;
                        book.Author = row["Author"] as string ?? string.Empty;

                        book.CategoryID = row["CategoryID"] as int? ?? 0;
                        book.Category = row["Category"] as string ?? string.Empty;

                        book.PublisherID = row["PublisherID"] as int? ?? 0;
                        book.Publisher = row["Publisher"] as string ?? string.Empty;
                        book.BookBarcodes = GetBookBarcode(row["BookID"] as int? ?? 0);
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
            return book;
        }

        public static List<BookBarcode> GetBookBarcode(int bookID = -1, string searchValue = null)
        {
            #region Declaration
            List<BookBarcode> bookBarcodes = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();
            if (bookID != -1)
            {
                param.Add(new SqlParameter("@BookID", bookID));
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
                SqlCommand cmd = new SqlCommand("ShowBookBarcode", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    bookBarcodes = new List<BookBarcode>();
                    foreach (DataRow row in dt.Rows)
                    {
                        BookBarcode bookBarcode = new BookBarcode
                        {
                            BookBarcodeID = row["BookBarcodeID"] as int? ?? 0,
                            BookID = row["BookID"] as int? ?? 0,
                            Barcode = row["Barcode"] as string ?? string.Empty,
                            Name = row["Name"] as string ?? string.Empty,
                            Author = row["Author"] as string ?? string.Empty,
                            Publisher = row["Publisher"] as string ?? string.Empty,
                            Language = row["Language"] as string ?? string.Empty,
                            ISBN = row["ISBN"] as string ?? string.Empty,
                            Price = row["Price"] as decimal? ?? 0,
                        };
                        bookBarcodes.Add(bookBarcode);
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
            return bookBarcodes;
        }

        public static BookBarcode DeactiveBookBarcode(BookBarcode bookBarcode)
        {
            #region Declaration
            SqlConnection con = null;

            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@BookBarcodeID", DbType = DbType.Int32, Value = bookBarcode.BookBarcodeID},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = bookBarcode.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("DeactiveBookBarcode", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                bookBarcode.BookBarcodeID = id;
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
            return bookBarcode;
        }

        public static Book Deactive(Book book)
        {
            #region Declaration
            SqlConnection con = null;

            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@BookID", DbType = DbType.Int32, Value = book.BookID},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = book.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("DeactiveBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                book.BookID = id;
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
            return book;
        }

        public static BookDetail GetBookByBarcode(string barcode)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            BookDetail bookDetail = null;
            SqlParameter param = new SqlParameter { ParameterName = "@Barcode", Value = barcode, DbType = DbType.String };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("GetBookByBarcode", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    bookDetail = new BookDetail();
                    foreach (DataRow row in dt.Rows)
                    {
                        bookDetail.BookID = row["BookID"] as int? ?? 0;
                        bookDetail.Name = row["Name"] as string ?? string.Empty;
                        bookDetail.Edition = row["Edition"] as string ?? string.Empty;
                        bookDetail.Language = row["Language"] as string ?? string.Empty;
                        bookDetail.Price = row["Price"] as decimal? ?? 0;
                        bookDetail.Isbn = row["ISBN"] as string ?? string.Empty;
                        bookDetail.Description = row["Description"] as string ?? string.Empty;
                        bookDetail.TotalQuantity = row["TotalQuantity"] as int? ?? 0;

                        bookDetail.AuthorID = row["AuthorID"] as int? ?? 0;
                        bookDetail.Author = row["Author"] as string ?? string.Empty;

                        bookDetail.PublisherID = row["PublisherID"] as int? ?? 0;
                        bookDetail.Publisher = row["Publisher"] as string ?? string.Empty;

                        bookDetail.BookBarcodeID = row["BookBarcodeID"] as int? ?? 0;
                        bookDetail.BookBarcode = row["Barcode"] as string ?? string.Empty;
                        bookDetail.CategoryID = row["BookBarcodeID"] as int? ?? 0;
                        bookDetail.Category = row["Category"] as string ?? string.Empty;
                        bookDetail.Funds = row["Funds"] as string ?? string.Empty;
                        bookDetail.IsRestricted = row["IsRestricted"] as bool? ?? false;

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
            return bookDetail;
        }

        public static string GetBarcode(bool isRestricted)
        {
            #region Declaration
            SqlConnection con = null;
            string barcode = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@IsRestricted", DbType = DbType.Boolean, Value = isRestricted},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("GetBarcode", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                barcode = cmd.Parameters["@OutputMessage"].Value.ToString();
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
            return barcode;
        }

        public static List<AvailableBook> GetBookAvailableQty(int bookID, string searchValue)
        {
            #region Declaration
            List<AvailableBook> availableBooks = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();
            if (bookID != -1)
            {
                param.Add(new SqlParameter("@UserID", bookID));
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
                SqlCommand cmd = new SqlCommand("ShowAvailableBook", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    availableBooks = new List<AvailableBook>();
                    foreach (DataRow row in dt.Rows)
                    {
                        AvailableBook availableBook = new AvailableBook
                        {
                            BookID = row["BookID"] as int? ?? 0,
                            Name = row["Name"] as string ?? string.Empty,
                            Edition = row["Edition"] as string ?? string.Empty,
                            Language = row["Language"] as string ?? string.Empty,
                            Price = row["Price"] as decimal? ?? 0,
                            Isbn = row["ISBN"] as string ?? string.Empty,
                            Description = row["Description"] as string ?? string.Empty,
                            TotalQuantity = row["TotalQuantity"] as int? ?? 0,

                            AuthorID = row["AuthorID"] as int? ?? 0,
                            Author = row["Author"] as string ?? string.Empty,

                            PublisherID = row["PublisherID"] as int? ?? 0,
                            Publisher = row["Publisher"] as string ?? string.Empty,

                            TotalIssueBook = row["TotalIssueBook"] as int? ?? 0,
                            TotalReturnBook = row["TotalReturnBook"] as int? ?? 0,

                            TotalAvailableBook = (row["TotalQuantity"] as int? ?? 0) - (row["TotalIssueBook"] as int? ?? 0)
                        };
                        availableBooks.Add(availableBook);
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
            return availableBooks;
        }

        public static List<BookBarcode> GetAvailableBookBarcodeByBookID(int bookID = -1, string searchValue = null)
        {
            #region Declaration
            List<BookBarcode> bookBarcodes = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();
            if (bookID != -1)
            {
                param.Add(new SqlParameter("@BookID", bookID));
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
                SqlCommand cmd = new SqlCommand("ShowAvailableBookBarcodeByBookID", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    bookBarcodes = new List<BookBarcode>();
                    foreach (DataRow row in dt.Rows)
                    {
                        BookBarcode bookBarcode = new BookBarcode
                        {
                            BookBarcodeID = row["BookBarcodeID"] as int? ?? 0,
                            BookID = row["BookID"] as int? ?? 0,
                            Barcode = row["Barcode"] as string ?? string.Empty,
                            Publisher = row["Publisher"] as string ?? string.Empty,
                            Author = row["Author"] as string ?? string.Empty,
                            Name = row["Name"] as string ?? string.Empty,
                            Language = row["Language"] as string ?? string.Empty,
                            ISBN = row["ISBN"] as string ?? string.Empty,
                            Price = row["Price"] as decimal? ?? 0,
                        };
                        bookBarcodes.Add(bookBarcode);
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
            return bookBarcodes;
        }

        public static bool CheckAvailableBookBarcode(int bookBarcodeID)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            SqlParameter param = new SqlParameter { ParameterName = "@BookBarcodeID", Value = bookBarcodeID, DbType = DbType.Int32 };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("CheckAvailableBookBarcode", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        public static List<Book> GetFunds(int userID, string searchValue)
        {
            #region Declaration
            List<Book> books = null;
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
                SqlCommand cmd = new SqlCommand("ShowFunds", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    books = new List<Book>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Book book = new Book();
                        book.BookID = row["BookID"] as int? ?? 0;
                        book.Funds = row["Funds"] as string ?? string.Empty;
                        books.Add(book);
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
            return books;
        }
    }
}
