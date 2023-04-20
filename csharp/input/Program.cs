using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type your name: ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}hello, {name}, on {date:d} at {date:t}!");
            Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}