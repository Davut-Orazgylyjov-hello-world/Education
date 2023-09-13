using System;
using System.Linq;

namespace Education
{
    //именованные параметры
    internal class Program
    {
        private static int CalculateAreaRectangle(int x, int y)
        {
            return x * y;
        }

        private static void FormatInformation(string name, string age, string city)
        {
            string message = "Name {0}, Age {1}, City {2}";

            Console.WriteLine(message, name, age, city);
        }

        private static int Sum(params int[] numbers)
        {
            return numbers.Sum();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(CalculateAreaRectangle(y:3, x:5));
         
            FormatInformation("Ivan","26","Moscow");
            
            int sum =  Sum(1, 2, 3, 4, 5);
        }
    }
}