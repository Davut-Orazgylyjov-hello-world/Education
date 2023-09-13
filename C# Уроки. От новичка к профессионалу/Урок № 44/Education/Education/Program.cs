using System;

namespace Education
{
    internal class Program
    {
        private static void Foo(ref int value)
        {
            value++;
        }

        private static void Bar(out int value)
        {
            value = 5;
        }
        
        public static void Main(string[] args)
        {
            // Foo(ref a);
           Bar(out var a); 
           
            Console.WriteLine(a);
        }
    }
}