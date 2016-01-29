using System;

// Problem 7. Sum of 5 Numbers
// • Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

public class SumOf5Numbers
{
    public static void Main()
    {
        Console.Write("Please enter five numbers, separated by space: ");

        string input = Console.ReadLine();
        double sum = 0;
        string[] strArr = input.Split(' ');

        for (int i = 0; i < 5; i++)
        {
            sum = sum + double.Parse(strArr[i]);
        }

        Console.WriteLine("Sum = {0}", sum);
    }
}
