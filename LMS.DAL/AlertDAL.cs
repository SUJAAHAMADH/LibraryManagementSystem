using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public static class AlertDAL
    {
        public static List<IssueBook> Get(string searchValue = null)
        {
            #region Declaration
            List<IssueBook> issueBooks = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(searchValue))
            {
                param.Add(new SqlParameter("@SearchValue", searchValue));
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowAlert", con);
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
