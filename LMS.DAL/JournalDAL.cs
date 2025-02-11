using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public static class JournalDAL
    {
        public static Journal Save(Journal journal, int journalID)
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
                new SqlParameter { ParameterName = "@JournalName", DbType = DbType.String, Value = journal.JournalName ?? (object)DBNull.Value },
                new SqlParameter { ParameterName = "@Frequency", DbType = DbType.Int32, Value = journal.Frequency },
                new SqlParameter { ParameterName = "@Price", DbType = DbType.Decimal, Value = journal.Price },
                new SqlParameter { ParameterName = "@InvoiceNo", DbType = DbType.String, Value = journal.InvoiceNo ?? (object)DBNull.Value },
                new SqlParameter { ParameterName = "@InvoiceDate", DbType = DbType.DateTime, Value = journal.InvoiceDate },
                new SqlParameter { ParameterName = "@OrderNo", DbType = DbType.String, Value = journal.OrderNo ?? (object)DBNull.Value },
                new SqlParameter { ParameterName = "@IsActive", DbType = DbType.Boolean, Value = journal.IsActive },
                new SqlParameter { ParameterName = "@SubjectID", DbType = DbType.Int32, Value = journal.SubjectID },
                new SqlParameter { ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output },
                new SqlParameter { ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000 }
            };
                #endregion

                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                transaction = con.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("SaveJournal", con, transaction))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(param.ToArray());
                    cmd.ExecuteNonQuery();

                    string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                    if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new Exception(outputMessage);
                    }

                    journal.ID = cmd.Parameters["@ID"].Value as int? ?? 0;
                }
                #endregion

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                con?.Close();
            }

            return journal;
        }

        public static Journal Update(Journal journal, int journalID)
        {
            if (journal == null)
            {
                throw new ArgumentNullException(nameof(journal));
            }
            if (journalID == -1)
            {
                throw new ArgumentOutOfRangeException(nameof(journalID));
            }

            SqlConnection con = null;
            SqlTransaction transaction = null;

            try
            {
                List<SqlParameter> param = new List<SqlParameter>
        {
            new SqlParameter { ParameterName = "@ID", DbType = DbType.Int32, Value = journal.ID },
            new SqlParameter { ParameterName = "@JournalName", DbType = DbType.String, Value = journal.JournalName ?? (object)DBNull.Value },
            new SqlParameter { ParameterName = "@Frequency", DbType = DbType.Int32, Value = journal.Frequency },
            new SqlParameter { ParameterName = "@Price", DbType = DbType.Decimal, Value = journal.Price },
            new SqlParameter { ParameterName = "@InvoiceNo", DbType = DbType.String, Value = journal.InvoiceNo ?? (object)DBNull.Value },
            new SqlParameter { ParameterName = "@InvoiceDate", DbType = DbType.DateTime, Value = journal.InvoiceDate },
            new SqlParameter { ParameterName = "@OrderNo", DbType = DbType.String, Value = journal.OrderNo ?? (object)DBNull.Value },
            new SqlParameter { ParameterName = "@IsActive", DbType = DbType.Boolean, Value = journal.IsActive },
            new SqlParameter { ParameterName = "@SubjectID", DbType = DbType.Int32, Value = journal.SubjectID },
            new SqlParameter { ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000 }
        };

                con = SqlConnectionHelper.GetConnectionSync();
                transaction = con.BeginTransaction();

                using (SqlCommand cmd = new SqlCommand("UpdateJournal", con, transaction))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(param.ToArray());
                    cmd.ExecuteNonQuery();

                    string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                    if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new Exception(outputMessage);
                    }
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                con?.Close();
            }

            return journal;
        }


        public static List<Journal> Get(int journalID, string name, int subjectID)
        {
            #region Declaration
            List<Journal> journals = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();

            if (journalID != -1)
            {
                param.Add(new SqlParameter("@ID", journalID));
            }
            if (!string.IsNullOrEmpty(name))  // Check for null or empty name
            {
                param.Add(new SqlParameter("@JournalName", name));
            }
            if (subjectID != -1)
            {
                param.Add(new SqlParameter("@SubjectID", subjectID));
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowJournal", con)
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
                    journals = new List<Journal>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Journal journal = new Journal
                        {
                            ID = row["ID"] as int? ?? 0,
                            JournalName = row["JournalName"] as string ?? string.Empty,
                            Frequency = row["Frequency"] as int? ?? 0,
                            Price = row["Price"] as decimal? ?? 0,
                            InvoiceNo = row["InvoiceNo"] as string ?? string.Empty,
                            InvoiceDate = row["InvoiceDate"] as DateTime? ?? DateTime.MinValue,
                            OrderNo = row["OrderNo"] as string ?? string.Empty,
                            IsActive = row["IsActive"] as bool? ?? false,
                            SubjectID = row["SubjectID"] as int? ?? 0,
                        };

                        journals.Add(journal);
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
            return journals;
        }

        public static Journal GetByID(int journalID)
        {
            #region Declaration
            DataTable dt = new DataTable();
            Journal journal = null;
            #endregion

            try
            {
                using (SqlConnection con = SqlConnectionHelper.GetConnectionSync())
                using (SqlCommand cmd = new SqlCommand("ShowJournal", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = journalID });

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(dt);
                    }
                }

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0]; // Fetch first (and only) row
                    journal = new Journal
                    {
                        ID = row["ID"] as int? ?? 0,
                        JournalName = row["JournalName"] as string ?? string.Empty,
                        Frequency = row["Frequency"] as int? ?? 0,
                        Price = row["Price"] as decimal? ?? 0,
                        InvoiceNo = row["InvoiceNo"] as string ?? string.Empty,
                        InvoiceDate = row["InvoiceDate"] as DateTime? ?? DateTime.MinValue,
                        OrderNo = row["OrderNo"] as string ?? string.Empty,
                        IsActive = row["IsActive"] as bool? ?? false,
                        SubjectID = row["SubjectID"] as int? ?? 0
                    };
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching journal: " + ex.Message);
            }

            return journal;
        }




        public static Journal Deactive(Journal journal)
        {
            #region Declaration
            string outputMessage = string.Empty;
            #endregion

            try
            {
                using (SqlConnection con = SqlConnectionHelper.GetConnectionSync())
                using (SqlCommand cmd = new SqlCommand("DeactiveJournal", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adding parameters
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = journal.ID });
                    SqlParameter outputParam = new SqlParameter("@OutputMessage", SqlDbType.NVarChar, 2000)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    // Execute command
                    cmd.ExecuteNonQuery();

                    // Retrieve output message
                    outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                    if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new Exception(outputMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deactivating journal: " + ex.Message);
            }

            return journal;
        }

    }
}
