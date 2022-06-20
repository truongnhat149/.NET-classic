using static System.Console;

namespace ReadKey
{
    class ReadKey
    {
        //static void Main(String[] args)
        //{
        //    Console.Title = "Readkey";
        //    Console.WriteLine("Press a key: ");
        //    var key = Console.ReadKey();
        //    Console.WriteLine();
        //    Console.WriteLine(key.KeyChar);
        //    Console.WriteLine(key.Modifiers);
        //    if (key.Key == ConsoleKey.H)
        //        Console.WriteLine("Hello World");
        //    Console.ReadKey();
        //}

        static void Main(String[] args)
        {
            Title = "Readkey";
            WriteLine("Press a key");
            var key = Console.ReadKey();
            WriteLine();
            WriteLine(key.KeyChar);
            WriteLine(key.Modifiers);

        }

    }
}