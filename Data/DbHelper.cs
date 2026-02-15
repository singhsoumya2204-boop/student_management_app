using System.Data.SqlClient;

namespace StudentManagementSystemAPI.Data
{
    public class DbHelper
    {
        private readonly string connectionString;

        public DbHelper(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
