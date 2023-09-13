using System;
using System.Linq;

namespace Education
{
    internal class Program
    {
        private static int Sum(string h, int b , params int[] a)
        {
            return a.Sum();
        }

        private static void Foo(params object[] parameters)
        {
            string message = "Тип Данных{0}, значение {1}";

            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }

        public static void Main(string[] args)
        {
           // Console.WriteLine(Sum("32",3,5,2,34,5,2));

           Foo(42, "gdgr", '#', 35.4f, 23D);
        }
    }
}