// See https://aka.ms/new-console-template for more information

namespace ConsoleApp_1
{
    class TestColor
    {
        static void Main(String[] args)
        {
            Console.Title = "Colorful Console";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Le Phung Nhat Truong");
            Console.ResetColor();
            var name = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(name);
            Console.ReadLine();
        }
    }
}

