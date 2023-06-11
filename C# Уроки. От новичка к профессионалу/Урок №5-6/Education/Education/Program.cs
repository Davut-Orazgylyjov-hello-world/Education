/*
 * ReadLine
 */

using System;
using System.Globalization;

namespace Education
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            //program.SayHelloToUser();
            
            Console.WriteLine(program.GetConsoleDouble() * 3);
        }

        private void SayHelloToUser()
        {
            var userName = Console.ReadLine();
            
            Console.WriteLine($"Hello {userName}!!!");
        }

        private int GetConsoleInt()
        {
            string str = Console.ReadLine();

            return Convert.ToInt32(str);
        }

        private double GetConsoleDouble()
        {
            string str = Console.ReadLine();

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ",",
            };
            
            return Convert.ToDouble(str, numberFormatInfo);
        }
    }
}