//namespace P01_DefaultConstructor
//{
//    using static System.Console;
//    internal class Book
//    {
//        private string _authors;
//        private string _title;
//        private int _year;
//        private string _publisher;
//        public Book() // đây là một hàm tạo của class Book
//        {
//            _authors = "Unknown author";
//            _title = "A new book";
//            _publisher = "Unknown publisher";
//            _year = 2019;
//        }
//        public Book(string author, string title, int year, string publisher) // đây là hàm tạo có tham số
//        {
//            _authors = author;
//            _title = title;
//            _year = year;
//            _publisher = publisher;
//        }

//        public string Authors { get => _authors; set => _authors = value; }
//        public string Title { get => _title; set => _title = value; }
//        public int Year { get => _year; set => _year = value; }
//        public string Publisher { get => _publisher; set => _publisher = value; }

//        public string Print()
//        {
//            return $"{_authors}, \"{_title}\", -{_publisher}, {_year}";
//        }
//    }
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            ReadKey();
//            var book1 = new Book();
//            WriteLine(book1.Print());
//            var book2 = new Book("Christian Nagel", "Professional C# 7 and the .NET core 2.0", 2018, "Wrox");
//            WriteLine(book2.Print());
//            ReadKey();
//        }

//    }
//}

internal class Book
{
    private string _authors = "Unknown author";
    private string _title = "A new book";
    private int _year = 2019;
    private string _publisher = "Unknown publisher";
    public Book()
    {
        _authors = "Unknown author";
        _title = "A new book";
        _publisher = "Unknown publisher";
        _year = 2019;
    }
    public Book(string author)
    {
        _authors = author;
    }
    public Book(string author, string title) : this(author)
    {
        _title = title;
    }
    public Book(string author, string title, int year) : this(author, title)
    {
        _year = year;
    }
    public Book(string author, string title, int year, string publisher) : this(author, title, year)
    {
        _publisher = publisher;
    }
    public string Print()
    {
        return $"{_authors}, \"{_title}\", -{_publisher}, {_year}";
    }

    static void Main(String[] args)
    {
        var b1 = new Book(); // dùng hàm tạo không tham số
        var b2 = new Book("Donald Trump"); // gọi hàm tạo Book(string author)
        var b3 = new Book("Donald Trump", "C# for dummy"); // gọi hàm tạo Book(string author, string title)
        var b4 = new Book("Donald Trump", "C# for dummy", 2020); // gọi hàm tạo Book(string author, string title, int year)
    }
}