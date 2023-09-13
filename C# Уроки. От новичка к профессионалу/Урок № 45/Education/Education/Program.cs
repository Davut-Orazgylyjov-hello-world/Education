using System;

namespace Education
{
    internal class Program
    {
        static void Foo(in int value)
        {
            Console.WriteLine(value);
            
        }
        
        public static void Main(string[] args)
        {
            int a = 10;
            
            Foo(a);
        }
    }
}