using System;

// Problem 8. Square Root
// • Create a console application that calculates and prints the square root of the number 12345.
// • Find in Internet “how to calculate square root in C#”.

public class SquareRootCalculation
{
    public static void Main()
    {
        double sqrtNumber = Math.Sqrt(12345);
        Console.WriteLine("The Square Root of 12345 is {0}.", sqrtNumber);
    }
}
