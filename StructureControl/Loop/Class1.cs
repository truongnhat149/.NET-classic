using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Class1
    {
        private static void Main(string[] args)
        {
            var i = 0;
            while (true)
            {
                if (i == 10)
                    break;
                Console.Write($"{i}\t");
                i++;
            }
            var j = 0;
            do
            {
                j++;
                if (j == 5) continue;
                Console.Write($"{j}\t");
            } while (j < 10);
            Console.ReadKey();
        }
    }
}
