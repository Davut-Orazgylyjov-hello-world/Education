using System;

namespace Education
{
    internal class Program
    {
    /*
     * многомерные массивы
     *
     * двумерные прямоугольный массив
     * 
     */
        public static void Main(string[] args)
        {
            //тип_данных [,] имя_массива;
            int[,] array2d =
            {
                {31,23,2,55},
                {4324,32,5,23},
                {321,41,52,21}
            };

            array2d[0, 3] = 232;
            
            Console.WriteLine(array2d[0,3]);
        }
    }
}