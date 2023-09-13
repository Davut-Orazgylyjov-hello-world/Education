using System;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(Sum(3.23,5.43),Sum(32,5)));   
        }

        private static int Sum(int a,int b)
        {
            return a + b;
        }
        
        private static double Sum(double a,double b)
        {
            return a + b;
        }
    }
}