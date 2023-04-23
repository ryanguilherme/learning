namespace arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"array length = {array.Length}" );
            Console.WriteLine($"array first  = {array.First()}");
            Console.WriteLine($"array test = {array[5]}");
        }
    }
}