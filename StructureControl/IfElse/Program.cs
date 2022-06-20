using System;
using System.Text;
namespace P01_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập nhiệt độ (oC): ");
            var input = Console.ReadLine();
            var temperature = int.Parse(input);
            //if (temperature <= 5)
            //{
            //    Console.WriteLine("Lạnh quá!");
            //}
            //else
            //{
            //    if (temperature <= 15)
            //    {
            //        Console.WriteLine("Mát mẻ, dễ chịu!");
            //    }
            //    else
            //    {
            //        if (temperature <= 25)
            //        {
            //            Console.WriteLine("Ấm áp!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Nóng quá!");
            //        }
            //    }
            //}
            //Console.ReadKey();
            if (temperature < 5)
            {
                Console.WriteLine("Test 4");
            } else if (temperature == 5){
                Console.WriteLine("Test 5");
            } else
            {
                Console.WriteLine("Test 6");
            }
        }
    }
}