using System;

namespace Education
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var arrayStairs = new int[3][];
            arrayStairs[0] = new int[5];
            arrayStairs[1] = new int[10];
            arrayStairs[2] = new int[3];

            var random = new Random();

            for (var i = 0; i < arrayStairs.Length; i++)
            {
                for (var j = 0; j < arrayStairs[i].Length; j++)
                {
                    arrayStairs[i][j] = random.Next(100);
                }
            }
            
            for (var i = 0; i < arrayStairs.Length; i++)
            {
                for (var j = 0; j < arrayStairs[i].Length; j++)
                {
                    Console.Write(arrayStairs[i][j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}