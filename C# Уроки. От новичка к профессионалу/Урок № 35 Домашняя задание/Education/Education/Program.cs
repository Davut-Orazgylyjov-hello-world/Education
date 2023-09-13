using System;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           // PrintLine();

           int[] array = GenerateRandomArray(100000000,-1500000,15000000);
           
           Console.WriteLine(FindIndexOfElement(-150,array));

           // PrintLine(Console.ReadKey().KeyChar,43);
           Console.Read();
        }

        private static void PrintLine(char symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }
        }

        private static int FindIndexOfElement(int needElement, int[] array)
        {
            if (array == null) return -1;
             
            //return Array.IndexOf(array, needElement);

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == needElement) return i;
            }
            
            return -1;
        }

        private static int[] GenerateRandomArray(int length,int minValue, int maxValue)
        {
            var random = new Random();
            
            var randomArray = new int[length];

            for (var i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue);
            }

            return randomArray;
        }

        private static void PrintLine()
        {
            string userInput = null;

            userInput += Console.ReadLine();
            
            Console.WriteLine(userInput);
        }
    }
}