using System;

// Problem 1. Sum of 3 Numbers
// • Write a program that reads 3 real numbers from the console and prints their sum


public class SumOfThreeNumbers
{
    public static void Main()
    {
        Console.WriteLine("Please enter three real numbers:");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondtNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the numbers you have entered is: {0}", (firstNumber + secondtNumber + thirdNumber));
    }
}
