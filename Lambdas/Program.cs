using System;
using System.Linq;


namespace Lambdas
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Lambda expression to filter even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            var newLinq = numbers.Sum(n => n);

            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(newLinq);
        }

    }
}
