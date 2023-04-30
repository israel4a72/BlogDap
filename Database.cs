using Microsoft.Data.SqlClient;

namespace BlogDap
{
    public static class Database
    {
        const string connectionString = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False;TrustServerCertificate=True;";
        public static SqlConnection Connection = new SqlConnection(connectionString);
    }
}