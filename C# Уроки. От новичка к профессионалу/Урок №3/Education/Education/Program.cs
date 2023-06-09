/*
data type
*/

using System;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string msg = "Type {0,8} |\t.NET ={1.8} |\tSize = {2} \t| MIN = {3,30}\t| MAX = {4}";

            Console.Title = "Data types в C#";

            Console.WriteLine("\n\t\t\t\t\tNumeric (integer) Type:\n");

            Console.WriteLine(string.Format(msg, "byte", typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue));

        }
    }
}