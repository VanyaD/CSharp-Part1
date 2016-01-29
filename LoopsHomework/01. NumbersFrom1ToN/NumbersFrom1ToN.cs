using System;

// Problem 1. Numbers from 1 to N
// • Write a program that enters from the console a positive integer  n  and prints
// all the numbers from  1  to  n , on a single line, separated by a space.


    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("Please enter a positive number: ");
            uint number = uint.Parse(Console.ReadLine());

            uint nextNumber = 1;
            Console.Write("{0} ", nextNumber);

            for (int i = 2; i <= number; i ++)
            {
                nextNumber = nextNumber + 1;
                Console.Write("{0} ", nextNumber);
            }
        }
    }
