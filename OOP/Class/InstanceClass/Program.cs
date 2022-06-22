//class ConsoleHelper
//{
//    public ConsoleColor BackgroundColor { get; set; } = ConsoleColor.Black;
//    public ConsoleColor ForegroundColor { get; set; } = ConsoleColor.White;
//    public void WriteLine(object message)
//    {
//        WriteLine(message, ForegroundColor, BackgroundColor);
//    }
//    public static void WriteLine(object message,
//                            ConsoleColor fgColor = ConsoleColor.White,
//                            ConsoleColor bgColor = ConsoleColor.Black,
//                            bool reset = true)
//    {
//        Console.ForegroundColor = fgColor;
//        Console.BackgroundColor = bgColor;
//        Console.WriteLine(message);
//        if (reset)
//            Console.ResetColor();
//    }


//    static void Main(string[] args)
//    {
//        // gọi phương thức tĩnh WriteLine
//        ConsoleHelper.WriteLine("Hello world!", ConsoleColor.Magenta, ConsoleColor.White);
//        // khởi tạo object và gọi phương thức thành viên WriteLine
//        var helper = new ConsoleHelper { BackgroundColor = ConsoleColor.Black, ForegroundColor = ConsoleColor.Yellow };
//        helper.WriteLine("Hello again!");
//        Console.ReadKey();
//    }
//}
class Employee
{
    public Employee(string firstname, string lastname)
    {
        firstname = firstname;
        lastname = lastname;
        id = nextid;

        nextid++;
    }
    public static int nextid;
    public int id { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }
    public string salary { get; set; } = "not enough";

    //static Employee() // constructor static
    //{
    //    Random randomGenerator = new Random();
    //    NextId = randomGenerator.Next(101, 999);
    //}
    //// ...
    //public static int NextId = 42;
    //// ...

   
        // ...
        public static int NextId
        {
            get
            {
                return _nextId;
            }
            private set
            {
                _nextId = value;
            }
        }
        private static int _nextId = 42;
        // ...
    static void main(string[] args)
    {
        Employee.nextid = 0;
        Employee Employee1 = new Employee("inigo", "montoya");
        Employee Employee2 = new Employee("princess", "buttercup");
        Console.WriteLine("{0} {1} ({2})", Employee1.firstname, Employee1.lastname, Employee1.id);
        Console.WriteLine("{0} {1} ({2})", Employee2.firstname, Employee2.lastname, Employee2.id);
        Console.WriteLine($"nextid = {Employee.nextid}");
        Console.ReadKey();
}
    // ... khai báo của lớp Employee nằm đây, bỏ qua cho gọn code
}
