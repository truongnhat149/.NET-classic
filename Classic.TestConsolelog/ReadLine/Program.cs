// See https://aka.ms/new-console-template for more information
namespace Readline
{
    class ReadLine
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            Console.Write(number);
            Console.WriteLine("Enter true or false");
            string boolean = Console.ReadLine();
            Console.Write(boolean);
            Console.WriteLine("Enter a String"); ;
            string message = Console.ReadLine();
            Console.Write(message);
            Console.WriteLine("Press enter to quit");
        }
    }
}
