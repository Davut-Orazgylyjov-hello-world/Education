using System;
using System.Linq;

namespace Education
{
    /*
     * как работать с массивами в C# на самом деле
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] myArray = {111, 10, 4,111, 777,777,99, 49, 64, 77, 4, 42, 5};

            // var value = myArray.Where(i => i % 2 != 0).Max();
            //
            // Console.WriteLine(value);

            //int[] result = myArray.OrderByDescending(i => i).ToArray();

            int result = myArray.FirstOrDefault(i => i < 10);
            
             Console.WriteLine(result);
            
            Console.ReadLine();
        }
    }
}