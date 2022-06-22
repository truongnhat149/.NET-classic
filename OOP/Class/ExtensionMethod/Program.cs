static class ExtensionMethods
{
    public static void ToConsole(this string message)
    {
        Console.WriteLine(message);
    }
    public static void ToConsole(this string message, ConsoleColor fgColor = ConsoleColor.White, ConsoleColor bgColor = ConsoleColor.Black, bool reset = true)
    {
        Console.ForegroundColor = fgColor;
        Console.BackgroundColor = bgColor;
        Console.WriteLine(message);
        if (reset) Console.ResetColor();
    }
    public static double ToDouble(this string number)
    {
        return double.TryParse(number, out double d) ? d : double.NaN;
    }
    public static int ToInt(this string number)
    {
        return int.Parse(number);
    }

    static void Main(string[] args)
    {
        ToConsole("Hello world!");
        //"Hello world!".ToConsole();
        "Hello again!".ToConsole(ConsoleColor.Magenta);
        int i = "2000".ToInt();
        double d = "2000.0001".ToDouble();
        Console.ReadKey();
    }
}