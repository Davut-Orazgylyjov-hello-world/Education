using System;

namespace Education
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
                {43, 6, 23, 5, 5}
            };

            foreach (var item in myArray)
            {
                Console.Write(item +  " ");
            }
        }
    }
}