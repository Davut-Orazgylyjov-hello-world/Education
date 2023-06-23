using System;

namespace Education
{
    /*
     * Условный оператор switch
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
     
            
            var a = Console.ReadLine();

            switch (a)
            {
                case "-":
                    Console.WriteLine(a);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}