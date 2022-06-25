namespace Func
{
class Func {
        static void Main(string[] args)
        {
            // tạo một hàm vô danh tuân theo mô tả (double) -> double
            // và gán nó cho biến function
            // biến function là biến thuộc kiểu delegate MathFunction
            MathFunction function = delegate (double x) { return x *= 2; };
            // truyền biến function cho hàm Render
            graph.Render(function, range);
            // khai báo và truyền hàm vô danh trực tiếp tại vị trí tham số
            graph.Render(delegate (double x) { return x++; }, range);


            // khai báo và truyền hàm lambda trực tiếp tại vị trí tham số
            graph.Render((double x) => { return x *= 10; }, range); // lambada expression
            // truyền một hàm lambda rút gọn làm tham số
            graph.Render(x => x / 10, range);
        }
}

}
