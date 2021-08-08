using System;
using System.Collections.Generic;

namespace ProceduralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? "); // What's your name?
            var name = Console.ReadLine(); // Aleksandras
            var reversed = ReverseName(name); 
            Console.WriteLine("Reversed name: " + reversed); // Reversed name: sardnaskelA

            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): "); // Enter a number (or 'Quit' to exit):
                var input = Console.ReadLine(); // Enter a number (or 'Quit' to exit): 1 | Enter a number (or 'Quit' to exit): 4 | Enter a number (or 'Quit' to exit): 77 | Enter a number (or 'Quit' to exit): QUIT
                
                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("Unique numbers:"); // Unique numbers:
            foreach (var number in GetUniqueNumbers(numbers))
            {
                Console.WriteLine(number); // 1 4 77
            }
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return new string(array);
            ;
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            return uniques;
        }
    }
}
