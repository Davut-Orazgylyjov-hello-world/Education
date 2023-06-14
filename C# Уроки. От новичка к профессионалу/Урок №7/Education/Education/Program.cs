/*
 *  конвертация строки
 *  parse и tryparse
 */

using System;
using System.Globalization;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str = "12141";

            // NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            // {
            //     NumberDecimalSeparator = ",",
            // };
            //
            // double a = double.Parse(str, numberFormatInfo);
            //
            // Console.WriteLine(a);

            int a;
            
            bool result = int.TryParse(str, out a);

            Console.WriteLine($"Конвертация: {result}, {a}");

            // try
            // {
            //     int a = int.Parse(str);
            //     Console.WriteLine("Успешная конвертация");
            // }
            // catch (Exception)
            // {
            //     Console.WriteLine("Ошибка при конвертации");
            // }
        }
    }
}