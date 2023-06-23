using System;

namespace Education
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //CalculatorSwitch();
           CalculatorIfElse();

            void CalculatorSwitch()
            {
                double result = 0f;
            
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Результат{result}");

                    string consoleKey =  GetKeyFunction();
                    
                    Console.WriteLine("Укажите число");
             
                    double valueDo;
                    
                    try
                    {
                        valueDo = double.Parse(Console.ReadLine() ?? string.Empty);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Не верно указано число");
                        continue;
                    }
        
                    switch (consoleKey)
                    {
                        case "/":
                            result /= valueDo;
                            break;
                
                        case "+":
                            result += valueDo;
                            break;
                
                        case "-":
                            result -= valueDo;
                            break;
                
                        case "*":
                            result *= valueDo;
                            break;
                    }

                }
            }
            
            void CalculatorIfElse()
            {
                double result = 0f;

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Результат{result}");

                    
                    string consoleKey =  GetKeyFunction();
                    
                    Console.WriteLine("Укажите число");

                    double valueDo;
                    
                    try
                    {
                         valueDo = double.Parse(Console.ReadLine() ?? string.Empty);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Не верно указано число");
                        continue;
                    }
                  
                
                    if (consoleKey == "/")
                        result /= valueDo;
                    else if (consoleKey == "+")
                        result += valueDo;
                    else if (consoleKey == "-")
                        result -= valueDo;
                    else if (consoleKey == "*")
                        result *= valueDo;
                }
            }

            string GetKeyFunction()
            {
                Console.WriteLine("Укажите действие");
                string consoleKey = Console.ReadLine();
                
                switch (consoleKey)
                {
                    case "/":
                    case "+":
                    case "*":
                    case "-":
                        return consoleKey;
                      
                    default:
                        return GetKeyFunction();
                }
            }
        }
    }
}