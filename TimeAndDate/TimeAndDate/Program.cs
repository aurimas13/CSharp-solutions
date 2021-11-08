// Created by Aurimas A. Nausedas on 08/08/21.
// Updated by Aurimas A. Nausedas on 11/08/21.

using System;

namespace TimeAndDate
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1); // Datetime immutable in C#
            var now = DateTime.Now;
            var today = DateTime.Today;


            Console.WriteLine("Hour: " + now.Hour); // Hour: 21
            Console.WriteLine("Minute: " + now.Minute); // Minute: 42

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString()); // Saturday, August 7, 2021
            Console.WriteLine(now.ToShortDateString()); // 8/7/2021
            Console.WriteLine(now.ToLongTimeString()); // 9:42:59 PM
            Console.WriteLine(now.ToShortTimeString()); // 9:42 PM
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm")); // 2021-08-07 21:42

            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration); // Duration: 00:02:00.0000030

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes); // Minutes: 2
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // Total Minutes: 62.05

            // Add & Subtract
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // Add Example: 01:10:03
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2))); // Add Example: 01:00:03

            // ToString
            Console.WriteLine("ToString: " + timeSpan.ToString()); // ToString: 01:02:03

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03")); // Parse: 01:02:03

        }
    }
}
