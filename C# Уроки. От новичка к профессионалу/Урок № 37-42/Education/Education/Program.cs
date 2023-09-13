using System;
using System.Linq;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] myArray = null;

            Console.WriteLine("сумма элементов массива " + (myArray?.Sum() ?? 0));

            // string str = null;
            //
            //
            //
            // //string result = str ?? string.Empty;
            // str ??= string.Empty;
            //
            // int[] myArray = null;
            // myArray ??= Array.Empty<int>();
            //
            // Console.WriteLine(myArray);
        }
    }
}