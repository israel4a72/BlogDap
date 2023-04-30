using Blog.Repositories;

namespace BlogDap.Screens.GenericScreens
{
    public class DeleteScreen<T> where T : class
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"Delete {typeof(T).Name}");
            Console.WriteLine("---------");
            Console.WriteLine($"Which {typeof(T).Name} do you want to delete?");
            int.TryParse(Console.ReadLine(), out int id);
            Delete(id);
            Console.ReadKey();
            MenuScreen<T>.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new GenericRepository<T>(Database.Connection);
                repository.Remove(id);
                Console.WriteLine($"{typeof(T).Name} deleted successfully!");
            }
            catch
            {
                MenuScreen<T>.Load();
            }
        }
    }
}