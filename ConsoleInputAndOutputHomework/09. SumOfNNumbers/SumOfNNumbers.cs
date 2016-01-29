using System;

// Problem 9. Sum of n Numbers
// • Write a program that enters a number  n  and after that enters more  n  numbers and calculates 
// and prints their  sum. Note: You may need to use a for-loop. 


public class SumOfNNumbers
{
    public static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another {0} numbers:", number);

        double sum = 0;

        for (int i = 1; i <= number; i++)
        {
            double anotherNumber = double.Parse(Console.ReadLine());
            sum = sum + anotherNumber;
        }

        Console.WriteLine("The sum of all numbers is: {0}", sum);
    }
}
