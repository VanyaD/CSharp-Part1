using System;

// Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
// • Write a program that, for a given two integer numbers  n  and  x , calculates the sum  S = 1 + 1!/x + 2!/x2 + … + n!/xn .
// • Use only one loop. Print the result with 5 digits after the decimal point.

public class Calculation
{
    public static void Main()
    {
        Console.WriteLine("Please enter two numbers.");

        Console.Write("n = ");
        int numberN = int.Parse(Console.ReadLine());

        Console.Write("x = ");
        int numberX = int.Parse(Console.ReadLine());

        double factorial = 1;
        double sum = 1;

        for (int i = 1; i <= numberN; i++)
        {
            factorial = factorial * i;
            sum = sum + factorial / (Math.Pow(numberX, i));
        }

        Console.WriteLine("Result = {0:f5}", sum);
    }
}
