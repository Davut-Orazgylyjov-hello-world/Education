using System;

namespace Education
{
    internal class Program
    {
/*
 *  индексы и диапазоны в C# 8
 */    
        public static void Main(string[] args)
        {
            int[] myArray = {2, 10, 5, 6, 77, 69};

            // все подчеркнуто из-за того что это .net frameWork а нужен .net Core 3.0 и выше
            Console.WriteLine(myArray[^1]);//первый элемент с конца (^ означает с конца, а цифра будет индексом, но начинается с 1 а не с 0)

            int[] myArray2 = myArray[1..4];//от индекса до индекса
            
            int[] myArray3 = myArray[..4]; //от начала массива до индекса
            
            int[] myArray4 = myArray[4..]; //от индекса до конца массива

            Index myIndex = ^1; // Index это тип данных (как int, bool и тд), он хранит index который мы можем использовать в массивах

            myIndex = new Index(3, false);

            Range myRange = 1..4; // Тип даных который хранит диапозон, используется в массивах, если хотим забрать диапозон элементов;

            myRange = ^3..^4;
            myRange = new Range(2, 5); //от индекса до индекса
            myRange = new Range(2, myIndex);
            
            Console.WriteLine(myArray[myIndex]);

            string str = "Hello world! =)";

            Console.WriteLine(str[^2..]);
            Console.WriteLine(str[..^2]);
            Console.WriteLine(str[6..11]);
        }
    }
}