using System;
using System.Linq;
using System.Collections.Generic;


namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create data set
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // From the array above, return the numbers greater than 6
            var newLinq = numbers.Where(n => n > 6);

            // Instead of a for each loop
            newLinq.ToList().ForEach(n => Console.WriteLine(n));

            // What the above method accomplishes
            foreach (var n in newLinq)
            {
                Console.WriteLine(n);
            }
        }
    }
}
