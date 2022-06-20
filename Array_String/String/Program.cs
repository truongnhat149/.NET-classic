namespace Array_String
{
    class Stringg
    {
        private static void Main(String[] args)
        {
            string greeting = " Hello World World ";
            Console.WriteLine(greeting.Length);
            Console.WriteLine(greeting.StartsWith("Hel"));
            Console.WriteLine(greeting.EndsWith("ld"));
            Console.WriteLine(greeting.Equals("World Hello"));
            Console.WriteLine(greeting.ToLower());
            Console.WriteLine(greeting.ToUpper());
            Console.WriteLine(greeting.Trim());
            Console.WriteLine(greeting.IndexOf("Hel"));
            var insert = greeting.Insert(6, " Holle ");
            Console.WriteLine(insert);
            var remove = greeting.Remove(6, 9);
            Console.WriteLine(remove);
            string replace = greeting.Replace("World", "Baby");
            Console.WriteLine(replace);
            string[] split = greeting.Split(new[] { ' ' });
            Console.WriteLine(split);

            var joinString = string.Join(",", " Helo", "World");
            Console.WriteLine(joinString);

            var numberr = 500;
            string format = $"{numberr, 10:D3}"; // string interpolation
            Console.WriteLine(format);
        }
    }
}