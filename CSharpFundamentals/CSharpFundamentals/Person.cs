// Created by Aurimas A. Nausedas on 08/18/21.
// Updated by Aurimas A. Nausedas on 11/08/21.

using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
