using System;

// Problem 12.* Randomize the Numbers 1…N
// • Write a program that enters in integer  n  and prints 
// the numbers  1, 2, …, n  in random order.

public class RandomizeNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int[] output = new int[n];
        int randomNumber = rnd.Next(1, n + 1);
        bool isDuplicate = false;
        output[0] = randomNumber;
        int count = 1;

        Console.Write("{0} ", randomNumber);

        while (count < n)
        {
            randomNumber = rnd.Next(1, n + 1);

            for (int i = 0; i < count; i++)
            {
                if (output[i] == randomNumber)
                {
                    isDuplicate = true;
                    break;
                }              
            }

            if (isDuplicate == false)
            {
                output[count] = randomNumber;
                count++;
                Console.Write("{0} ", randomNumber);
            }

            isDuplicate = false;       
        }

        Console.WriteLine();
    }
}
