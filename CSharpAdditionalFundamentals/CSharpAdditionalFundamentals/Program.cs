using System;
using System.Collections.Generic;

namespace CSharpAdditionalFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };
            var numbersTwo = new List<int>() { 1, 2, 3, 4 };

            // Length
            Console.WriteLine("Length: " + numbers.Length); // Length: 6

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index); // Index of 9: 2

            // Clear()
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
                Console.WriteLine(n); // 0 0 9 2 14 6

            // Copy
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var num in another)
                Console.WriteLine(num); // 0 0 9

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var num in numbers)
                Console.WriteLine(num); // 0 0 2 6 9 14

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n); // 14 9 6 2 0 0

            numbersTwo.Add(1);
            numbersTwo.AddRange(new int[3] { 5, 6, 7 }); // enumerable - array or a list

            foreach (var number in numbersTwo)
                Console.WriteLine(number); // 1 2 3 4 1 5 6 7 

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbersTwo.IndexOf(1)); // Index of 1: 0
            Console.WriteLine("Last Index of 1: " + numbersTwo.LastIndexOf(1)); // Last Index of 1: 4

            Console.WriteLine("Count: " + numbersTwo.Count); // Count: 8

            for (var i = 0; i < numbersTwo.Count; i++)
            {
                if (numbersTwo[i] == 1)
                    numbersTwo.Remove(numbersTwo[i]);
            }
            foreach (var number in numbersTwo)
                Console.WriteLine(number); // 2 3 4 5 6 7 

            numbersTwo.Clear();
            Console.WriteLine("Count: " + numbersTwo.Count); // Count: 0
        }
    }
}
