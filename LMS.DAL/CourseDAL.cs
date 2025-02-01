using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public static class CourseDAL
    {
        public static Course Save(Course course, int courseID)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = course.Name},
                new SqlParameter{ParameterName = "@FromDate", DbType = DbType.String, Value = course.FromDate},
                new SqlParameter{ParameterName = "@ToDate", DbType = DbType.String, Value = course.ToDate},
                new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = course.UserID},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };
            if (courseID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@CourseID", DbType = DbType.Int32, Value = courseID });
            }
            if (!string.IsNullOrEmpty(course.Description))
            {
                param.Add(new SqlParameter { ParameterName = "@Description", DbType = DbType.String, Value = course.Description });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SaveCourse", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();
                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }
                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                course.CourseID = id;
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
            return course;
        }

        public static List<Course> Get(int userID, string searchValue)
        {
            #region Declaration
            List<Course> courses = null;
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
                SqlCommand cmd = new SqlCommand("ShowCourse", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    courses = new List<Course>();
                    foreach (DataRow row in dt.Rows)
                    {
                        Course course = new Course();

                        course.CourseID = row["CourseID"] as int? ?? 0;
                        course.Name = row["Name"] as string ?? string.Empty;
                        course.FromDate = row["FromDate"] as string ?? string.Empty;
                        course.ToDate = row["ToDate"] as string ?? string.Empty;
                        course.Description = row["Description"] as string ?? string.Empty;
                        courses.Add(course);
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
            return courses;
        }

        public static Course GetByID(int courseID)
        {
            #region Declaration
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Course course = null;
            SqlParameter param = new SqlParameter { ParameterName = "@CourseID", Value = courseID, DbType = DbType.Int32 };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("ShowCourse", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    course = new Course();
                    foreach (DataRow row in dt.Rows)
                    {
                        course.CourseID = row["CourseID"] as int? ?? 0;
                        course.Name = row["Name"] as string ?? string.Empty;
                        course.FromDate = row["FromDate"] as string ?? string.Empty;
                        course.ToDate = row["ToDate"] as string ?? string.Empty;
                        course.Description = row["Description"] as string ?? string.Empty;
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
            return course;
        }

        public static Course GetByName(string name, int userID, string fromDate, string toDate)
        {
            #region Declaration
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            SqlConnection con = null;
            Course course = null;
            SqlParameter param = new SqlParameter { ParameterName = "@SearchValue", Value = name, DbType = DbType.String };
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                cmd = new SqlCommand("ShowCourse", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(param);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                #endregion

                #region Wrap data
                if (dt.Rows.Count > 0)
                {
                    course = new Course();
                    foreach (DataRow row in dt.Rows)
                    {
                        course.CourseID = row["CourseID"] as int? ?? 0;
                        course.Name = row["Name"] as string ?? string.Empty;
                    }
                }
                else
                {
                    List<SqlParameter> paramAdd = new List<SqlParameter>
                    {
                        new SqlParameter{ParameterName = "@Name", DbType = DbType.String, Value = name},
                        new SqlParameter{ParameterName = "@FromDate", DbType = DbType.String, Value = fromDate},
                        new SqlParameter{ParameterName = "@ToDate", DbType = DbType.String, Value = toDate},
                        new SqlParameter{ParameterName = "@UserID", DbType = DbType.Int32, Value = userID},
                        new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                        new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
                    };

                    cmd = new SqlCommand("SaveCourse", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(paramAdd.ToArray());
                    cmd.ExecuteNonQuery();
                    string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                    if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new Exception(outputMessage);
                    }
                    int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                    course = new Course();
                    course.CourseID = id;
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
            return course;
        }
    }
}
