using LMS.DAL.Shared;
using LMS.MOD;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace LMS.DAL
{
    public class VolumeDAL
    {
        public static Volume Save(Volume volume, int volumeID)
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
            new SqlParameter { ParameterName = "@VolumeNo", DbType = DbType.String, Value = volume.VolumeNo ?? (object)DBNull.Value },
            new SqlParameter { ParameterName = "@IssueNo", DbType = DbType.String, Value = volume.IssueNo ?? (object)DBNull.Value },
            new SqlParameter { ParameterName = "@Month", DbType = DbType.String, Value = volume.Month ?? (object)DBNull.Value },
            new SqlParameter { ParameterName = "@Remark", DbType = DbType.String, Value = volume.Remark ?? (object)DBNull.Value },
            new SqlParameter { ParameterName = "@JournalID", DbType = DbType.Int32, Value = volume.JournalID },
            new SqlParameter { ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output },
            new SqlParameter { ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000 }
        };
                #endregion

                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                transaction = con.BeginTransaction();

                using (SqlCommand cmd = new SqlCommand("SaveVolume", con, transaction))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(param.ToArray());
                    cmd.ExecuteNonQuery();

                    string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                    if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new Exception(outputMessage);
                    }

                    volume.VolumeID = cmd.Parameters["@ID"].Value as int? ?? 0;
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

            return volume;
        }

        public static List<Volume> Get(int volumeID, string volumeNo, int journalID)
        {
            #region Declaration
            List<Volume> volumes = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>();

            if (volumeID != -1)
            {
                param.Add(new SqlParameter("@ID", volumeID));
            }
            if (!string.IsNullOrEmpty(volumeNo))
            {
                param.Add(new SqlParameter("@VolumeNo", volumeNo));
            }
            if (journalID != -1)
            {
                param.Add(new SqlParameter("@JournalID", journalID));
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowVolume", con)
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
                    volumes = new List<Volume>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Volume volume = new Volume
                        {
                            VolumeID = row["ID"] as int? ?? 0,
                            VolumeNo = row["VolumeNo"] as string ?? string.Empty,
                            IssueNo = row["IssueNo"] as string ?? string.Empty,
                            Month = row["Month"] as string ?? string.Empty,
                            Remark = row["Remark"] as string ?? string.Empty,
                            JournalID = row["JournalID"] as int? ?? 0,
                        };

                        volumes.Add(volume);
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
            return volumes;
        }
        public static Volume GetByID(int volumeID)
        {
            #region Declaration
            DataTable dt = new DataTable();
            Volume volume = null;
            #endregion

            try
            {
                using (SqlConnection con = SqlConnectionHelper.GetConnectionSync())
                using (SqlCommand cmd = new SqlCommand("ShowVolume", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = volumeID });

                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(dt);
                    }
                }

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0]; // Fetch first (and only) row
                    volume = new Volume
                    {
                        VolumeID = row["ID"] as int? ?? 0,
                        VolumeNo = row["VolumeNo"] as string ?? string.Empty,
                        IssueNo = row["IssueNo"] as string ?? string.Empty,
                        Month = row["Month"] as string ?? string.Empty,
                        Remark = row["Remark"] as string ?? string.Empty,
                        JournalID = row["JournalID"] as int? ?? 0
                    };
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching volume: " + ex.Message);
            }

            return volume;
        }
        public static Volume Deactivate(Volume volume)
        {
            #region Declaration
            string outputMessage = string.Empty;
            #endregion

            try
            {
                using (SqlConnection con = SqlConnectionHelper.GetConnectionSync())
                using (SqlCommand cmd = new SqlCommand("DeactivateVolume", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adding parameters
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = volume.VolumeID });
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
                throw new Exception("Error deactivating volume: " + ex.Message);
            }

            return volume;
        }
        public static List<Volume> GetByJournal(int journalID)
        {
            List<Volume> volumes = new List<Volume>();
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = SqlConnectionHelper.GetConnectionSync())
                using (SqlCommand cmd = new SqlCommand("GetVolumesByJournal", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add Journal ID parameter
                    cmd.Parameters.Add(new SqlParameter("@JournalID", SqlDbType.Int) { Value = journalID });

                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                }

                // Wrap data into Volume objects
                foreach (DataRow row in dt.Rows)
                {
                    volumes.Add(new Volume
                    {
                        VolumeID = row["ID"] as int? ?? 0,
                        VolumeNo = row["VolumeNo"] as string ?? string.Empty,
                        IssueNo = row["IssueNo"] as string ?? string.Empty,
                        Month = row["Month"] as string ?? string.Empty,
                        Remark = row["Remark"] as string ?? string.Empty,
                        JournalID = row["JournalID"] as int? ?? 0,
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching volumes by journal: " + ex.Message);
            }

            return volumes;
        }
    }
}
