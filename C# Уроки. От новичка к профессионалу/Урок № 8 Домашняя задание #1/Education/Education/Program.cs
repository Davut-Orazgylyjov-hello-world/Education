/*
 * ОПЕРАТОРЫ
 *
 * Арифметические операции с числами
 */

using System;
using System.Collections.Generic;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Exercises exercises = new Exercises();
            //Home Work
             exercises.Exercise1();
            // exercises.Exercise2();
            // exercises.Exercise3();
        }

        private class Exercises
        {
            //1) Напишите программу, вычисляющую среднее ариметическое двух чисел
            public void Exercise1()
            {
                double num1 = double.Parse(Console.ReadLine() ?? string.Empty),
                    num2 = double.Parse(Console.ReadLine() ?? string.Empty);
                
                Console.WriteLine($"Answer {(num1 + num2) / 2}");
            }
            
            //2)Введите три числа и выведите на экран значение суммы и произведения этих чисел
            public void Exercise2()
            {
                var nums = new List<int>();

                for (var i = 0; i < 3; i++)
                {
                    int.TryParse(Console.ReadLine(), out var num);
                    nums.Add(num);
                }

                var resultSum = nums[0];
                var resultMultiplication = nums[0];
           

                for (var i = 1; i < nums.Count; i++)
                    resultMultiplication *= nums[i];
                
                for (var i = 1; i < nums.Count; i++)
                    resultSum += nums[i];

                Console.WriteLine($"Answer: {resultSum}, {resultMultiplication}");
            }

            /*
             * 3) Напишите простой конвертер валют (без возможности диначисеского выбора валюты пользователем).
             *  Валюты заданы хардкодом и не изменяютя. Тип валют на выбор программиста.
             */
            public void Exercise3()
            {
                double dollar = 75.34, euros = 91.43;

                double.TryParse(Console.ReadLine(),out double convertRubbles);

                Console.WriteLine($"Answer: Converted to Dollars {Math.Round(convertRubbles/dollar, 2)}, " +
                                  $"Converted to Euros {Math.Round(convertRubbles/euros, 2)}");
            }
        }
      
    }
}