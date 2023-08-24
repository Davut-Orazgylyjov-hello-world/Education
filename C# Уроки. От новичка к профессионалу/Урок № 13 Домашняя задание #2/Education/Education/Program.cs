using System;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.WriteLine(num % 2 == 0 ? "Четное" : "Нечетное");
        }
    }
}