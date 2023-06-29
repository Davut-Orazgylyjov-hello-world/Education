using System;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное значение");
            int startValue = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введите последнее значение");
            int endValue = int.Parse(Console.ReadLine() ?? string.Empty);
            uint even = 0, odd = 0;

            int evenSum = 0, oddSum = 0;
            while (startValue <= endValue)
            {
                if (startValue % 2 == 0)
                {
                    even++;
                    evenSum += startValue;
                }
                else
                {
                    odd++;
                    oddSum += startValue;
                }
                
                startValue++;
            }

            Console.WriteLine($"Четных: {even} Нечетных: {odd}");
            Console.WriteLine($"Сумма Четных: {evenSum} Сумма Нечетных: {oddSum}");
            Console.ReadLine();
        }
    }
}