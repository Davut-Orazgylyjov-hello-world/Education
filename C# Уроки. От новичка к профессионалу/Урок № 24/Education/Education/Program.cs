using System;
using System.Linq;

namespace Education
{
    internal class Program
    {
        /*
         * Массивы
         *
         * Одномерные массивы
         *
         * тип_элементов_массива [] имя_массива;
         */
        public static void Main(string[] args)
        {
            // new int[5] -> обявляем контейнер, заполняя память компьютера. Удаляется с памяти автоматически
            
            int[] myArray;
            
            myArray = Enumerable.Repeat(5, 10).ToArray(); // заполнения всего массива определенным значением

            myArray = Enumerable.Range(4, 5).ToArray(); // заполнение элементов начиная с определенного значения. 4-5-6-7-8
            
            myArray = new int[4];
            
            myArray = new int[] {3, 523, 3, 123};
            
            myArray = new int[4] {3, 523, 3, 123};

            Console.WriteLine(myArray);
        }
    }
}