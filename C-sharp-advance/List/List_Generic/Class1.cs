using System;
using System.Collections.Generic;
namespace ConsoleApp
{
    class Department
    {
        public string Name { get; set; }
        public string Office { get; set; }
    }
    internal class _12_dictionary
    {
        private static void Main(string[] args)
        {
            var dict = new Dictionary<string, Department>
            {
                ["Donald Trump"] = new Department { Name = "Sale", Office = "New York" },
                ["Bill Clinton"] = new Department { Name = "Technical", Office = "California" },
                ["George Bush"] = new Department { Name = "Service", Office = "Alaska" }
            };
            Console.ReadKey();
        }
    }
}