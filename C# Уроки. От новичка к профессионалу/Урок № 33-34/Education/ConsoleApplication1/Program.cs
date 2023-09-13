using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var myArray = new int[3, 4, 4, 7];
            // {
            //     {
            //         {
            //             {2, 4, 5},
            //             {23, 543, 2}
            //         },
            //
            //         {
            //             {3, 53, 1},
            //             {43, 4, 64}
            //         },
            //
            //         {
            //             {32, 1, 45},
            //             {3, 23, 5}
            //         }
            //     },
            //     
            //     {
            //         {
            //             {2, 3, 5},
            //             {34, 3, 2}
            //         },
            //
            //         {
            //             {3, 23, 1},
            //             {43, 6, 64}
            //         },
            //
            //         {
            //             {1, 3, 6},
            //             {3, 32, 5}
            //         }
            //     },
            // };

            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        for (int l = 0; l < myArray.GetLength(3); l++)
                        {
                            myArray[i, j, k, l] = random.Next(100);
                        }
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine($"Book № {i + 1}");
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine($"Page № {j + 1}");
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        for (int l = 0; l < myArray.GetLength(3); l++)
                        {
                            Console.Write(myArray[i, j, k, l] + " ");
                        }

                        Console.WriteLine();
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}