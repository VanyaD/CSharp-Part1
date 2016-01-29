using System;

// Problem 3. Min, Max, Sum and Average of N Numbers
// • Write a program that reads from the console a sequence of n integer numbers 
// and returns the minimal, the maximal number, the sum and the average of all numbers 
// (displayed with 2 digits after the decimal point).
// • The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.


public class MinMaxSumAndAverageOfNNumbers
{
    public static void Main()
    {
        Console.WriteLine("Please enter N (the count of the numbers), followed by the numbers themselves:");

        int count = int.Parse(Console.ReadLine());
        int currentNumber = int.Parse(Console.ReadLine());
        int minNumber = currentNumber;
        int maxNumber = currentNumber;
        double average = 0.0;
        int sum = currentNumber;

        for (int i = 1; i < count; i++)
        {
            currentNumber = int.Parse(Console.ReadLine());

            if (minNumber > currentNumber)
            {
                minNumber = currentNumber;
            }
            else if (maxNumber < currentNumber)
            {
                maxNumber = currentNumber;
            }

            sum = sum + currentNumber;
            average = ((double)sum) / count;
        }

        Console.WriteLine("The minimal number is {0:#.##}.", minNumber);
        Console.WriteLine("The maximal number is {0:#.##}.", maxNumber);
        Console.WriteLine("The sum of all numbers is {0:#.##}.", sum);
        Console.WriteLine("The average of all numbers is {0:#.##}.", average);
    }
}
