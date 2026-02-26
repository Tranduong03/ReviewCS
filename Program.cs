using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            if (args.Length > 0)
            {
                foreach (var item in args)
                {
                    Console.WriteLine(item);
                }
            }
            
            bool isValid = int.TryParse(Console.ReadLine(), out int result);
            Console.WriteLine(result + " " + isValid);

            if (isValid)
            {
                Console.WriteLine($"Your value entered: {result}");
            } 
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
