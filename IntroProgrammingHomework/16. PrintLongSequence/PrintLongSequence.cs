using System;

// Problem 16.* Print Long Sequence
// • Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
// • You might need to learn how to use loops in C# (search in Internet).

class PrintLongSequence
{
    public static void Main()
    {
        int even = 2;
        int odd = -3;
        int currentCount = 0;
        int count = 1000;

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
