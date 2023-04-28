using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=SERVICELOGIC;Database=Blog;User Id=sa;Password=saDefault;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true";

using var connection = new SqlConnection(connectionString);
ReadUsers(connection);
ReadRoles(connection);


static void ReadUsers(SqlConnection connection)
{
    var repository = new GenericRepository<User>(connection);
    var users = repository.GetAllAsync();

    foreach (var user in users.Result)
        Console.WriteLine($"{user.Id} - {user.Name}");


}
static void ReadRoles(SqlConnection connection)
{
    var repository = new GenericRepository<Role>(connection);
    var roles = repository.GetAllAsync();

    foreach (var role in roles.Result)
        Console.WriteLine($"{role.Id} - {role.Name}");
}