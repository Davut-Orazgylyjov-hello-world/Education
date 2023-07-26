using System;

namespace Education
{
    /*
     *  вложенные циклы
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину");
            int width = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}