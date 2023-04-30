namespace BlogDap.Screens.GenericScreens
{
    public class MenuScreen<T> where T : class
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"{typeof(T).Name} Management");
            Console.WriteLine("----------------");
            Console.WriteLine($"1 - Create {typeof(T).Name} ");
            Console.WriteLine($"2 - Update {typeof(T).Name} ");
            Console.WriteLine($"3 - List {typeof(T).Name} ");
            Console.WriteLine($"4 - Delete {typeof(T).Name} ");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine() ?? "0");
            switch (option)
            {
                case 1:
                    CreateScreen<T>.Load();
                    break;
                case 2:
                    UpdateScreen<T>.Load();
                    break;
                case 3:
                    ListScreen<T>.Load();
                    break;
                case 4:
                    DeleteScreen<T>.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}