using System;

// Problem 11.* Numbers in Interval Dividable by Given Number
// • Write a program that reads two positive integer numbers and prints how many 
// numbers  p  exist between them such that the remainder of the division by  5  is  0.

public class NumInIntDividableByGivenNum
{
    public static void Main()
    {
        Console.WriteLine("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int countNumbers = 0;

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            bool isTrue = i % 5 == 0;

            if (isTrue)
            {
                countNumbers = countNumbers + 1;
            }
        }

        Console.WriteLine("The count of numbers divisable by 5 without remainder in the interval [{0}, {1}] is {2}.", firstNumber, secondNumber, countNumbers);
    }
}
