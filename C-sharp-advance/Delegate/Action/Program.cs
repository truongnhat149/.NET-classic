namespace System
{
    class Program
    {
        public delegate void Action();
        public delegate void Action<in T>(T obj);
        public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
        // còn các delegate tương tự như vậy nữa
        // .NET framework định nghĩa tổng cộng 16 delegate như vậy với số lượng tham số đầu vào từ 1 đến 16.



        public delegate TResult Func<out TResult>();
        public delegate TResult Func<in T, out TResult>(T arg);
        public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
        // có 17 delegate tương tự như vậy


        public delegate bool Predicate<[NullableAttribute(2)] in T>(T obj);

    static void Main(string[] args)
        {
            Action action1 = () => Console.WriteLine("Hello world");
            Action<string> action2 = (s) => Console.WriteLine(s);
            Action<string, int> action3 = (s, i) => { for (int j = 0; j < i; j++) Console.WriteLine(s); };

            Func<int> func1 = () => 0;
            Func<int, int> func2 = (i) => i * 10;
            Func<int, int, float> func3 = (a, b) => a / b;
            Console.WriteLine($"func1: {func1}; func2: {func2(10)}; func3: {func3(1, 2)}");

            Predicate<int> predicate1 = (i) => i > 100;
            Console.WriteLine($"is 10 > 100? it's {predicate1(10)}");
            Predicate<string> predicate2 = (s) => s.Length > 10;
        }
    }

  
}