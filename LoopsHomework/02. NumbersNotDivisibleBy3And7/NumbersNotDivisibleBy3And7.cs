﻿using System;

// Problem 2. Numbers Not Divisible by 3 and 7
// • Write a program that enters from the console a positive integer  n  and prints all the numbers 
// from  1  to  n  not divisible by  3  and  7 , on a single line, separated by a space.

public class NumbersNotDivisibleBy3And7
{
    public static void Main()
    {
        Console.Write("Please enter a positive number: ");
        uint number = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if ((i % 3 > 0) && (i % 7 > 0))
            {
                Console.Write("{0} ", i);
            }
        }

        Console.WriteLine();
    }
}
