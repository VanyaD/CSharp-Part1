using System;

// Problem 4. Number Comparer
// • Write a program that gets two numbers from the console and prints the greater of them.
// • Try to implement this without if statements.

public class NumberComparer
{
    public static void Main()
    {
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        bool firstIsBigger = firstNumber > secondNumber;

        switch (firstIsBigger)
        {
            case true:
                Console.WriteLine("The bigger number is {0}", firstNumber);
                break;
            case false:
                Console.WriteLine("The bigger number is {0}", secondNumber);
                break;
        }
    }
}
