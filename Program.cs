using Blog.Models;
using BlogDap;
using BlogDap.Screens.GenericScreens;
using Microsoft.Data.SqlClient;

const string connectionString = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False;TrustServerCertificate=True;";

using var connection = new SqlConnection(connectionString);
connection.Open();
Database.Connection = connection;
Load();
connection.Close();

static void Load()
{
    //Console.Clear();
    Console.WriteLine("Select the entity to manage:");
    string entity = Console.ReadLine() ?? string.Empty;

    switch (entity.ToLower())
    {
        case "category":
            MenuScreen<Category>.Load();
            break;
        case "post":
            MenuScreen<Post>.Load();
            break;
        case "tag":
            MenuScreen<Tag>.Load();
            break;
        case "user":
            MenuScreen<User>.Load();
            break;
        case "role":
            MenuScreen<Role>.Load();
            break;
        default:
            Console.WriteLine("Invalid entity");
            Console.ReadKey();
            Load();
            break;
    }
}