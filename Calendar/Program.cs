using System;

namespace Calendar
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a year to check if it is a leap year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (LeapYear.IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a Leap Year!");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year!");
            }
        }
    }
}