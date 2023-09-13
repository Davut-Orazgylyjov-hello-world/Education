using System;

namespace Education_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var myArray = new int[,]
            {
                {2, 423, 3, 52, 5},
                {5, 63, 233, 5, 64},
                {63, 2, 36, 6, 23},
                {43, 6, 23, 5, 5},
                {2, 423, 3, 52, 5},
                {5, 63, 233, 5, 64},
                {63, 2, 36, 6, 23},
            };

            for (var y = 0; y < myArray.GetLength(0); y++)
            {
                for (var x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y,x] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}