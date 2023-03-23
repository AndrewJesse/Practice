using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.WriteLine("Original list of numbers:");
            Display(numbers);

            Console.WriteLine("\nEven numbers:");
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Display(evenNumbers);

            Console.WriteLine("\nNumbers greater than 50:");
            var greaterThanFifty = numbers.Where(n => n > 50);
            Display(greaterThanFifty);

            Console.WriteLine("\nNumbers squared:");
            var squaredNumbers = numbers.Select(n => n * n);
            Display(squaredNumbers);


            Console.WriteLine("\nNumbers in reverse");
            // Create a new list from the original one
            List<int> reverseNumbers = numbers.ToList();
            // Reverse the new list in-place
            reverseNumbers.Reverse(); 
            Display(reverseNumbers);

            Console.ReadLine();

        }

        static void Display(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
