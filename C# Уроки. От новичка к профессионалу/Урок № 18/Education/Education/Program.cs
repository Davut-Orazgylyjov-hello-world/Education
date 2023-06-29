using System;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // int i = 0;
            //
            // for ( new Program().Function(), new Program().Function(); //дествие которое выполняется перед началом цикла
            //     i < 5 && i > -1; //проверка, можно ли выполнить цикл
            //     i++, new Program().Function()) //действие которое выполняется после каждого цикла
            // {
            //     Console.WriteLine(i);
            // }

            // for (;;)
            // {
            //     Console.WriteLine("for is working");
            //     System.Threading.Thread.Sleep(300);
            //    // break;
            // }

            // int i = int.Parse(Console.ReadLine());
            // for (; i >= 0; i--)
            // {
            //     Console.WriteLine(i);
            // }

            for (int i = 0, j = 10;i <10 ;i++, j--)
            {
                Console.WriteLine("I:"+i);
                Console.WriteLine("J:"+j);
            }
        }

        public void Function()
        {
            Console.WriteLine("Function Activated");
        }
    }
}