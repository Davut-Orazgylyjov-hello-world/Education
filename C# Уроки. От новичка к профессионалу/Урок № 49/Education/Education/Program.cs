using System;

namespace Education
{
    internal class Program
    {
        private static void Foo(int i)
        {
            i++;

            Console.WriteLine(i);

            Foo(i);
        }

        public static void Main(string[] args)
        {
            Foo(0);
        }
    }
}