
class Program
{
    static void Main(String[] args)
    {
        //Console.WriteLine("The value: {0}", 500);

        //Console.WriteLine("The value: {0:P}", 500);
        //Console.WriteLine("The value: {0:P}", 500);

        //decimal value = 500; 
        //Console.WriteLine($"The value: {value:P}");

        //Console.WriteLine($"The value: {value:P}");

        //int x1 = 500, x2 = 1000;
        //Console.WriteLine($"The value {x1}, {x2}", x1, x2);
        Console.WriteLine("{0 :C4}", 12.5);

        Console.WriteLine("{0 :D4}", 12);
      
        Console.WriteLine("{0 :F4}", 12.3456789);
    
        Console.WriteLine("{0 :G4}", 12.3456789);
    
        Console.WriteLine("{0 :x}", 180026);
 
        Console.WriteLine("{0 :N2}", 12345678.54321);
   
        Console.WriteLine("{0 :P2}", 0.1221897);
     
        Console.WriteLine("{0 :e4}", 12.3456789);
      
    }
}
