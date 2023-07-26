using System;

namespace HomeWork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину треугольник");

            int width = int.Parse(Console.ReadLine() ?? string.Empty);
            
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            
            Console.WriteLine();


            for (int i = 0; i < width+1; i++)
            {
                for (int k = i; k < width; k++)
                {
                    Console.Write(" ");
                }
                
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
            
                Console.WriteLine();
            }
            

            Console.WriteLine();
            
            for (int i = width; i > 0; i--)
            {
                for (int k = i; k < width; k++)
                {
                    Console.Write(" ");
                }
                
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
            
                Console.WriteLine();
            }
    
            Console.ReadLine();
            
            //функция для смены позиция курсора, чтобы не писать вложенные циклы как наверху
            Console.SetCursorPosition(left: 1, top: 2);
        }
    }
}