using System;
using System.Text;
namespace P02_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một số từ 1 đến 8: ");
            var day = Console.ReadLine();
            switch (day)
            {
                case "2":
                    Console.WriteLine("Thứ hai");
                    break;
                case "3":
                    Console.WriteLine("Thứ ba");
                    break;
                case "4":
                    Console.WriteLine("Thứ tư");
                    break;
                case "5":
                    Console.WriteLine("Thứ năm");
                    break;
                case "6":
                    Console.WriteLine("Thứ sáu");
                    break;
                case "7":
                    Console.WriteLine("Thứ bảy");
                    break;
                // nhập 1 và 8 sẽ đều thực hiện chung lệnh viết ra "Chủ nhật", rồi quay về case "2"
                case "1":
                case "8":
                    Console.WriteLine("Chủ nhật");
                    goto case "3";
                // nếu nhập bất kỳ giá trị nào khác sẽ thực hiện lệnh ở nhóm này
                default:
                    Console.WriteLine("Bạn nhập sai rồi");
                    break;
            }
            Console.ReadKey();
        }
    }
}