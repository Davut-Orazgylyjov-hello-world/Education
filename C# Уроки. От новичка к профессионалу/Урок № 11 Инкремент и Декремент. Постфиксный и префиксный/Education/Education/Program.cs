/*
 * Инкремент и Декремент. Постфиксный и префиксный
 */

using System;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0;

            a--;//Постфиксный
            a++;//Постфиксный
            
            --a;//Префиксный
            ++a;//Префиксный
            
            Console.WriteLine(a);

            
            
            int b = 1;

            b = ++b * b;

            Console.WriteLine(b);
        }
    }
}