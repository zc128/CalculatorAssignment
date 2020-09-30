using System;
using CalculatorLibrary;
using System.IO;
using Newtonsoft.Json;

namespace CalculatorProgram
{   
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false; 

            Console.WriteLine("Console Calculator in C#");

            Calculator calculator = new Calculator();

            while (!endApp) 
            {
                 
                string Input1 = "";
                string Input2 = "";
                double result = 0;

                 
                Console.Write("Type a number, and then press Enter: ");
                Input1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(Input1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    Input1 = Console.ReadLine();
                }

              
                Console.Write("Type another number, and then press Enter: ");
                Input2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(Input2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    Input2 = Console.ReadLine();
                }

            
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine();
                Console.WriteLine("\ta : Add");
                Console.WriteLine("\ts : Subtract");
                Console.WriteLine("\tm : Multiply");
                Console.WriteLine("\td : Divide");
                Console.WriteLine();
                Console.Write("What is your option? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op); //changed to "C"
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
                                               
                Console.Write("Press 'c' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "c") endApp = true; 

            }
            // And call to close the JSON writer before return
            calculator.Finish();
            return;
        }
     
    }
}