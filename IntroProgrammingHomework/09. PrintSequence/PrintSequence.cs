using System;

// Problem 9. Print a Sequence
// • Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ... 

public class PrintSequence
{
    public static void Main()
    {
        int even = 2;
        int odd = -3;
        int currentCount = 0;
        int count = 10;

        while (currentCount < count)
        {
            Console.WriteLine(even);
            currentCount += 1;

            if (currentCount >= count)
            {
                break;
            }

            currentCount += 1;
            Console.WriteLine(odd);
            even += 2;
            odd -= 2;
        }
    }
}
