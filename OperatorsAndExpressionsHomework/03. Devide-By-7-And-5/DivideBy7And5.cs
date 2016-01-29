using System;

// Problem 3. Divide by 7 and 5
// • Write a Boolean expression that checks for given integer if it can be divided (without remainder) by  7  and  5  at the same time.

public class DivideBy7And5
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if ((number % 5 == 0) && (number % 7 == 0))
            {
                Console.WriteLine("The number you have entered can be divided by 5 and 7 without remainder.");
            }
            else
            {
                Console.WriteLine("The number you have entered cannot be divided by 5 and 7 without remainder.");
            }
        }
    }
}

