using System;

// Problem 8. Prime Number Check
// • Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

public class PrimeNumberCheck
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            double maxNum = Math.Sqrt(number);

            for (int i = 2; i <= maxNum + 1; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("The given number is not prime");
                    return;
                }
                else
                {
                    if (i >= maxNum)
                    {
                        Console.WriteLine("The given number is prime");
                    }
                }
            }
        }           
    }
}
