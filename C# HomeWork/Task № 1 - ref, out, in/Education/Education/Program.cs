using System;
using System.Linq;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 5, b = 3;

            int[] array = new int[3] {1,3,4};
            
            //Task1Swap(ref a, ref b);
            Task2(out a);

            Console.WriteLine( Task3(array));
            
            Console.WriteLine();
            
            Console.WriteLine($"{a} {b}");
        }
        
        private static void Task1Swap(ref int a, ref int b) => (a, b) = (b, a);

        private static void Task2(out int a)
        {
            a = 50;
        }

        private static int Task3(in int[] array)
        {
            return array.Sum();
        }
    }
}