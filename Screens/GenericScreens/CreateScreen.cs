using System.ComponentModel;
using Blog.Repositories;

namespace BlogDap.Screens.GenericScreens
{
    public class CreateScreen<T> where T : class
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"Create {typeof(T).Name} ");
            Console.WriteLine("---------");

            Create();

            Console.ReadKey();
            MenuScreen<T>.Load();
        }
        public static void Create()
        {
            try
            {
                var repository = new GenericRepository<T>(Database.Connection);
                T entity = Activator.CreateInstance<T>();
                foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(typeof(T)))
                {

                    if (prop.Name != "Id")
                    {
                        Console.Write($"{prop.Name}: ");
                        string value = Console.ReadLine() ?? string.Empty;
                        var propType = prop.GetType();
                        prop.SetValue(entity, Convert.ChangeType(value, prop.PropertyType));
                    }
                }
                Console.WriteLine(entity);
                repository.Add(entity);
                Console.WriteLine($"{typeof(T).Name}  created successfully!");
            }
            catch
            {
                MenuScreen<T>.Load();
            }
        }
    }
}