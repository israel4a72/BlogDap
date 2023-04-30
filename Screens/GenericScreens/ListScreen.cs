using Blog.Repositories;

namespace BlogDap.Screens.GenericScreens
{
    public class ListScreen<T> where T : class
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"List {typeof(T).Name} ");
            Console.WriteLine("---------");

            List();

            Console.ReadKey();
            MenuScreen<T>.Load();
        }
        public static void List()
        {
            var repository = new GenericRepository<T>(Database.Connection);
            var entities = repository.GetAll();
            foreach (var entity in entities)
            {
                var props = entity.GetType().GetProperties();
                for (int i = 0; i < props.Length; i++)
                {
                    Console.Write($"{props[i].Name}: {props[i].GetValue(entity)}");
                    if (i != props.Length - 1) Console.Write(" - ");
                }
                Console.WriteLine();
            }
        }
    }
}