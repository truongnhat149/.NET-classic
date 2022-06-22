//namespace P02_IndexerOverload
//{
//    using static System.Console;
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //var vector1 = new Vector(1, 2, 3);
//            //WriteLine($"vector 1: {vector1}");
//            //ReadLine();

//            var vector1 = new Vector(1, 2, 3);
//            WriteLine($"vector 1: {vector1}");
//            var x = vector1[0];
//            var y = vector1[1];
//            var z = vector1[2];
//            WriteLine($"Vector components: x = {x}, y = {y}, z = {z}");
//            vector1[2] = 30;
//            vector1[1] = 20;
//            vector1[0] = 10;
//            WriteLine($"vector 1: {vector1}");
//            ReadLine();
//    }
//    }

//    class Vector
//    {
//        private double[] _components;
//        public Vector(int dimension)
//        {
//            _components = new double[dimension];
//        }
//        public Vector(params double[] components)
//        {
//            _components = components;
//        }
//        public override string ToString()
//        {
//            return $"({string.Join(", ", _components)})";
//        }
//    }
//}

namespace P02_IndexerOverload
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            var vector1 = new Vector(1, 2, 3);
            WriteLine($"vector 1: {vector1}");
            var x = vector1[0];
            var y = vector1[1];
            var z = vector1[2];
            WriteLine($"Vector components: x = {x}, y = {y}, z = {z}");
            vector1[2] = 30;
            vector1[1] = 20;
            vector1[0] = 10;
            WriteLine($"vector 1: {vector1}");
            ReadLine();
        }
    }
    class Vector
    {
        public double this[int index]
        {
            get => (index < _components.Length) ? _components[index] : double.NaN;
            set { if (index < _components.Length) _components[index] = value; }
        }
        private double[] _components;
        public Vector(int dimension)
        {
            _components = new double[dimension];
        }
        public Vector(params double[] components)
        {
            _components = components;
        }
        public override string ToString()
        {
            return $"({string.Join(", ", _components)})";
        }
    }
}