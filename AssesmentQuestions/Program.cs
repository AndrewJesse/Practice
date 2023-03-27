using System;
using System.Linq;

public class SecondLowestAndHighest
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int result = SumOfSecondLowestAndSecondHighest(numbers);
        Console.WriteLine("The sum of the second-lowest and second-highest values is: " + result);
    }

    public static int SumOfSecondLowestAndSecondHighest(int[] numbers)
    {
        if (numbers.Length < 4)
        {
            throw new ArgumentException("The input array must have at least 4 elements.");
        }

        int[] sortedNumbers = (int[])numbers.Clone();
        Array.Sort(sortedNumbers);

        int secondLowest = sortedNumbers[1];
        int secondHighest = sortedNumbers[sortedNumbers.Length - 2];

        return secondLowest + secondHighest;
    }
}
