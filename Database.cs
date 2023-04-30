using Microsoft.Data.SqlClient;

namespace BlogDap
{
    public static class Database
    {
        public static SqlConnection Connection = new SqlConnection();
    }
}