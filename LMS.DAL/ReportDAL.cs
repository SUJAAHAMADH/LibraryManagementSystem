using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace LMS.DAL
{
    public class ReportDAL
    {
        public static List<Candidate> GetCandidateWiseReport(int userID, int courseID = -1)
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
            if (userID != -1)
            {
                param.Add(new SqlParameter("@UserID", userID));
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
                        Candidate candidate = new Candidate();

                        candidate.CandidateID = row["CandidateID"] as int? ?? 0;
                        candidate.Role = row["Role"] as string ?? string.Empty;
                        candidate.Name = row["Name"] as string ?? string.Empty;
                        candidate.ContactNumber = row["ContactNumber"] as string ?? string.Empty;
                        candidate.RoleID = row["ServiceNo"] as string ?? string.Empty;
                        candidate.CourseID = row["CourseID"] as int? ?? 0;
                        candidate.CourseName = row["CourseName"] as string ?? string.Empty;
                        candidate.FromDate = row["FromDate"] as string ?? string.Empty;
                        candidate.ToDate = row["ToDate"] as string ?? string.Empty;
                        candidate.TOSDate = row["TOSDate"] as string ?? string.Empty;
                        candidate.SOSDate = row["SOSDate"] as string ?? string.Empty;
                        candidate.ThumbImpression = row["ThumbImpression"] as string ?? string.Empty;
                        //candidate.DOB = row["DOB"] as DateTime? ?? (DateTime?)null;
                        candidate.Stream = row["Stream"] as string ?? string.Empty;
                        candidate.AcademicYear = row["AcademicYear"] as int? ?? 0;
                        candidate.PermanentAddress = row["PermanentAddress"] as string ?? string.Empty;
                        candidate.PresentAddress = row["PresentAddress"] as string ?? string.Empty;
                        candidate.Email = row["Email"] as string ?? string.Empty;
                        candidate.ParentsContact = row["ParentsContact"] as string ?? string.Empty;
                        candidate.Photo = row["Photo"] as byte[] ?? null;
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

        public static List<Book> GetBookWiseReport(int userID, int authorID = -1, int publisherID = -1, int bookID = -1, int categoryID = -1)
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
            if (bookID != -1)
            {
                param.Add(new SqlParameter("@BookID", bookID));
            }
            if (categoryID != -1)
            {
                param.Add(new SqlParameter("@CategoryID", categoryID));
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
                    Value = DateTime.Parse(startDate, CultureInfo.InvariantCulture)
                });
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                param.Add(new SqlParameter
                {
                    ParameterName = "@EndDate",
                    DbType = DbType.Date,
                    Value = DateTime.Parse(endDate, CultureInfo.InvariantCulture)
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
