using System;

namespace Education_3 
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var myArray = new string[2, 3];

            // var random = new Random();
            //
            // for (var i = 0; i < myArray.GetLength(0); i++)
            // {
            //     for (var j =  0; j < myArray.GetLength(1); j++)
            //     {
            //         myArray[i, j] = random.Next(100);
            //     }
            // }
            
            for (var i = 0; i < myArray.GetLength(0); i++)
            {
                for (var j =  0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine($"ВВедите значение для Y{i} X{j} яйчейки");
                    myArray[i, j] = Console.ReadLine() ?? string.Empty;
                }
            }

            Console.WriteLine();
            
            
            for (var y = 0; y < myArray.GetLength(0); y++)
            {
                for (var x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}