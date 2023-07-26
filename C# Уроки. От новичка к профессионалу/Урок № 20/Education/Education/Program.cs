using System;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                string msg = Console.ReadLine();

                if (msg == "exit")
                    break;
                
                if (i == 100) 
                    break;

                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}