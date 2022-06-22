using System;
namespace P01_VariableSample
{
    class Program
    {
        static void Main(String[] args)
        {
            Car bmw = new Car();
            bmw.Color = "White";
            bmw.Seats = 2;
            Console.WriteLine("A new " + bmw.Color + "BMW");
            Console.WriteLine($"A new {bmw.Color} and {bmw.Seats} BMW");
            Console.ReadKey();
        }

    }

    class Car
    {
        // private _ before character
        string _make;
        int _yearOfProduction;
        bool _hasInsurance;

        // public => PascalCase
        public int Seats = 5;
        public string Color = "Black";
    }
}