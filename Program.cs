using Blog.Repositories;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=SERVICELOGIC;Database=Blog;User Id=sa;Password=saDefault;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true";

using var connection = new SqlConnection(connectionString);
ReadUsers(connection);
ReadRoles(connection);


static void ReadUsers(SqlConnection connection)
{
    var repository = new UserRepository(connection);
    var users = repository.GetAll();

    foreach (var user in users)
        Console.WriteLine($"{user.Id} - {user.Name}");


}
static void ReadRoles(SqlConnection connection)
{
    var repository = new RoleRepository(connection);
    var roles = repository.GetAll();

    foreach (var role in roles)
        Console.WriteLine($"{role.Id} - {role.Name}");
}