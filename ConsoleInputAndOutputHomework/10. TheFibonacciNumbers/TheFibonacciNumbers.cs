using System;

// Problem 10. Fibonacci Numbers
// • Write a program that reads a number  n  and prints on the console the first  n  members of the Fibonacci sequence
// (at a single line, separated by comma and space -  , ) :  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … .

// Note: You may need to learn how to use loops.

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n + 1];

        nums[0] = 0;
        nums[1] = 1;

        for (int i = 2; i < n; i++)
        {
            nums[i] = nums[i - 1] + nums[i - 2];
        }

        if (n == 0)
        {
            Console.WriteLine("");
        }
        else if (n == 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.Write("0, 1");
            for (int i = 2; i < n; i++)
            {
                Console.Write(", {0}", nums[i]);
            }
        }

        Console.WriteLine();
    }
}

