using System;

// Problem 1. Numbers from 1 to N
// • Write a program that enters from the console a positive integer  n  and prints
// all the numbers from  1  to  n , on a single line, separated by a space.

public class NumbersFrom1ToN
{
    public static void Main()
    {
        Console.Write("Please enter a positive number: ");
        uint number = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.Write("{0} ", i);
        }

        Console.WriteLine();
    }
}
