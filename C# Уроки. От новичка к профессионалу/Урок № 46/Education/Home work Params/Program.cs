using System;
using System.Linq;

namespace Home_work_Params
{
    internal class Program
    {
        private static int Sum(params int[] parameters)
        {
            return parameters.Sum();
        }
        
        private static int FindMin(params int[] parameters)
        {
            var minIndex = -1;
            var minValue = int.MaxValue;
            if (parameters == null) return minValue;
            
            for (var i = 0; i < parameters.Length; i++)
            {
                if (minValue <= parameters[i]) continue;
                
                minValue = parameters[i];
                minIndex = i;
            }

            return minIndex;
        }

        private static string GenerateSentences(params string[] parameters)
        {
            var sentence = parameters[0];
            
            for (var i = 1; i < parameters.Length; i++)
                sentence += " " + parameters[i];
            
            return sentence;
        }
        
        
        public static void Main(string[] args)
        {
            Console.WriteLine(FindMin(3,4,64,63,2,34));

            Console.WriteLine(GenerateSentences("Привет", "как", "дела?"));
        }
    }
}