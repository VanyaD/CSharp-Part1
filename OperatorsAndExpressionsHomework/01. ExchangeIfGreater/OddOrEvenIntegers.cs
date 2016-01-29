using System;

// Problem 1. Odd or Even Integers
// • Write an expression that checks if given integer is odd or even.


public class OddOrEvenIntegers
{
    public static void Main()
    {
        Console.Write("Please enter a number: ");
        int OddOrEvenNumber = int.Parse(Console.ReadLine());

        if (OddOrEvenNumber % 2 == 1)
        {
            Console.WriteLine("The number you have entered is odd.");
        }
        else
        {
            Console.WriteLine("The number you have entered is even.");
        }
    }
}