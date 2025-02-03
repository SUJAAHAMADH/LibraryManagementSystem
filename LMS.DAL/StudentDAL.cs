using LMS.DAL.Shared;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LMS.DAL
{
    public static class StudentDAL
    {
        public static Student Save(Student student, int studentID)
        {
            #region Declaration
            SqlConnection con = null;
            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@StudentID", DbType = DbType.String, Value = student.StudentID},
                new SqlParameter{ParameterName = "@NameOfStudent", DbType = DbType.String, Value = student.NameOfStudent},
                new SqlParameter{ParameterName = "@DOB", DbType = DbType.DateTime, Value = student.DOB},
                new SqlParameter{ParameterName = "@Stream", DbType = DbType.String, Value = student.Stream},
                new SqlParameter{ParameterName = "@AcademicYear", DbType = DbType.Int32, Value = student.AcademicYear},
                new SqlParameter{ParameterName = "@PermanentAddress", DbType = DbType.String, Value = student.PermanentAddress},
                new SqlParameter{ParameterName = "@PresentAddress", DbType = DbType.String, Value = student.PresentAddress},
                new SqlParameter{ParameterName = "@Email", DbType = DbType.String, Value = student.Email},
                new SqlParameter{ParameterName = "@ParentsContact", DbType = DbType.String, Value = student.ParentsContact},
                new SqlParameter{ParameterName = "@StudentContact", DbType = DbType.String, Value = student.StudentContact},
                new SqlParameter{ParameterName = "@ID", DbType = DbType.Int32, Direction = ParameterDirection.Output},
                new SqlParameter{ParameterName = "@OutputMessage", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 2000}
            };

            if (studentID != -1)
            {
                param.Add(new SqlParameter { ParameterName = "@ID", DbType = DbType.Int32, Value = studentID });
            }

            if (student.Photo != null && student.Photo.Length > 0)
            {
                param.Add(new SqlParameter { ParameterName = "@Photo", DbType = DbType.Binary, Value = student.Photo });
            }
            #endregion

            try
            {
                #region Interacting with database
                con = SqlConnectionHelper.GetConnectionSync();
                SqlCommand cmd = new SqlCommand("SaveStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param.ToArray());
                cmd.ExecuteNonQuery();

                string outputMessage = cmd.Parameters["@OutputMessage"].Value.ToString();
                if (!string.Equals(outputMessage, "SUCCESS", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(outputMessage);
                }

                int id = cmd.Parameters["@ID"].Value as int? ?? 0;
                student.ID = id;
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
            return student;
        }
    }
}
