using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public static class DashboardDAL
    {
        public static Dashboard GetDashboard()
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Dashboard dashboard = null;
            //SqlParameter param = new SqlParameter { ParameterName = "@BookID", Value = bookID, DbType = DbType.Int32 };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowDashboard", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    dashboard = new Dashboard();
                    foreach (DataRow row in dt.Rows)
                    {
                        dashboard.TotalAuthor = row["TotalAuthor"] as int? ?? 0;
                        dashboard.TotalPublisher = row["TotalPublisher"] as int? ?? 0;
                        dashboard.TotalLibrarian = row["TotalLibrarian"] as int? ?? 0;
                        dashboard.TotalCandidate = row["TotalCandidate"] as int? ?? 0;
                        dashboard.TotalBook = row["TotalBook"] as int? ?? 0;
                        dashboard.TotalIssueBook = row["TotalIssueBook"] as int? ?? 0;
                        dashboard.TotalReturnBook = row["TotalReturnBook"] as int? ?? 0;
                        dashboard.TotalRenewalBook = row["TotalRenewalBook"] as int? ?? 0;
                        dashboard.TotalPendingBook = row["TotalPendingBook"] as int? ?? 0;
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
            return dashboard;
        }
    }
}
