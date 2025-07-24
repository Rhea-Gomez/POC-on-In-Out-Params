using System;

namespace SimplyOutput
{
    class Program
    {
       
        static void ShowValue(in int number)
        {
            Console.WriteLine("Inside ShowValue (in param): " + number);
        }

        
        static void GetResult(out int value)
        {
            value = 100; 
        }

        
        static void TryParseInput(string input)
        {
            if (int.TryParse(input, out int parsedNumber))
            {
                Console.WriteLine("TryParse success: " + parsedNumber);
            }
            else
            {
                Console.WriteLine("TryParse failed for input: " + input);
            }
        }

        
        static void PrintNames(params string[] names)
        {
            Console.WriteLine("Names list using params:");
            foreach (string name in names)
            {
                Console.WriteLine("- " + name);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("------------- Using IN keyword -------------");
            int inNum = 50;
            ShowValue(in inNum);
            Console.WriteLine("Back in Main: " + inNum);

            Console.WriteLine("\n ----------- Using OUT keyword ---------------");
            int outValue;
            GetResult(out outValue);
            Console.WriteLine("Value from out method: " + outValue);

            Console.WriteLine("\n------------ Using TryParse ------------");
            TryParseInput("456");
            TryParseInput("NotANumber");

            Console.WriteLine("\n------------- using Params --------------");
            PrintNames("Alice", "Bob", "Charlie");

            Console.WriteLine("\n=== Console.WriteLine() using params ===");
            string name = "Rhea";
            int age = 25;
            Console.WriteLine("Hello, {0}! You are {1} years old.", name, age);
        }
    }
}

