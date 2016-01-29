using System;

// Problem 1. Exchange If Greater
// • Write an if-statement that takes two double variables a and b and exchanges their values 
// if the first one is greater than the second one. As a result print the values a and b, separated by a space.

public class ExchangeIfGreater
{
    public static void Main()
    {
        Console.WriteLine("Please enter two numbers.");
        Console.Write("a = ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double numberB = double.Parse(Console.ReadLine());
        double container = 0;

        if (numberA > numberB)
        {
            container = numberA;
            numberA = numberB;
            numberB = container;
        }

        Console.WriteLine(numberA + " " + numberB);
    }
}
