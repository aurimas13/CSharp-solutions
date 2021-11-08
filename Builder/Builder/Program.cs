// Created by Aurimas A. Nausedas on 08/08/21.
// Updated by Aurimas A. Nausedas on 08/11/21.

using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder); // ----------d++++++++++
                                        // Header
                                        //++++++++++

            Console.WriteLine("First Char: " + builder[0]); // First Char: -
        }
    }
}
