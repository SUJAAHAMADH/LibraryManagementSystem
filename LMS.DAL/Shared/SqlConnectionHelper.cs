using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LMS.DAL.Shared
{
    public static class SqlConnectionHelper
    {

        private static string _connectionString;
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_connectionString))
                {
                    _connectionString = ConfigurationManager.ConnectionStrings["AMS"].ConnectionString;
                }
                return _connectionString;
            }
        }

        //public static async Task<SqlConnection> GetConnection()
        //{
        //    SqlConnection connection = new SqlConnection(ConnectionString);
        //    await connection.OpenAsync().ConfigureAwait(false);
        //    return connection;
        //}

        public static SqlConnection GetConnectionSync()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.; Initial Catalog=LibrarySystem-Army; Integrated Security=True;");
            connection.Open();
            return connection;
        }
    }
}
