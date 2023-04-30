using Blog.Models;
using BlogDap;
using BlogDap.Screens.GenericScreens;

Database.Connection.Open();
Load();
Database.Connection.Close();

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