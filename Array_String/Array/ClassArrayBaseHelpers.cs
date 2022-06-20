namespace Array
{
    internal static class ClassArrayBaseHelpers
    {
        private static void Main(String[] args)
        {
            int[] intergers = new int[] { 2, 4, 5, 4, 7, 8 };
            foreach (var i in intergers)
            {
                Console.Write($"{i}\t");
            }
        }
    }
}