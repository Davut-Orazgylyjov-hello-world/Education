using System;
using System.Linq;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] myArray = GetUserNumbers();

            ShowArrayBackside(myArray);
            
            FindSumNumbersInArray(myArray);

            Console.WriteLine($"Наименьшее число в массиве: { myArray.Min()}");
        }
        
        private static int[] GetUserNumbers()
        {
            Console.WriteLine("Укажите длину массива:\t");
            var lengthArray = int.Parse(Console.ReadLine() ?? string.Empty);

            var userNumbers = new int[lengthArray];

            for (int i = 0; i < userNumbers.Length; i++)
            {
                Console.WriteLine($"Укажите элемент массива {i}");
                userNumbers[i] = int.Parse(Console.ReadLine() ?? string.Empty);
            }

            return userNumbers;
        }

        private static void ShowArrayBackside(int[] array)
        {
            Console.WriteLine("Показываем все элементы массива в обратном порядке");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            
            Console.WriteLine("Конец");
        }

        private static void FindSumNumbersInArray(int[] array)
        {
            Console.WriteLine("Найти сумму четных чисел в массиве");
            int sumValue = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    sumValue += array[i];
            }

            Console.WriteLine($"Ответ: {sumValue}");
        }
    }
}