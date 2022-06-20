using System;
using System.Globalization;
namespace P01_SingleDimension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Basic Array";
            // khai báo và khởi tạo mảng chứa tên 12 tháng trong tiếng Anh
            string[] months = new string[12];
            // duyệt qua các phần tử và gán giá trị 
            for (int month = 1; month <= 12; month++)
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
                string name = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
                months[month - 1] = name;
            }
            // duyệt qua các phần tử và in giá trị ra console
            foreach (string month in months)
            {
                Console.WriteLine($"-> {month}");
            }
            Console.ReadLine();
        }
    }
}