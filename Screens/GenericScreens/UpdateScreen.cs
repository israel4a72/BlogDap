using System.ComponentModel;
using Blog.Repositories;

namespace BlogDap.Screens.GenericScreens
{
    public class UpdateScreen<T> where T : class
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"Update {typeof(T).Name}");
            Console.WriteLine("---------");

            Console.WriteLine($"Which {typeof(T).Name} do you want to update?");
            int.TryParse(Console.ReadLine(), out int id);
            Update(id);

            Console.ReadKey();
            MenuScreen<T>.Load();
        }
        public static void Update(int id)
        {
            try
            {
                var repository = new GenericRepository<T>(Database.Connection);
                T entity = repository.Get(id);
                foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(typeof(T)))
                {
                    if (prop.Name != "Id")
                    {
                        Console.Write($"{prop.Name}: ");
                        string value = Console.ReadLine() ?? string.Empty;
                        var propType = prop.GetType();
                        if (!string.IsNullOrEmpty(value))
                            prop.SetValue(entity, Convert.ChangeType(value, prop.PropertyType));
                    }
                }
                Console.WriteLine(entity);
                repository.Update(entity);
                Console.WriteLine($"{typeof(T).Name} updated successfully!");
            }
            catch
            {
                MenuScreen<T>.Load();
            }
        }
    }
}