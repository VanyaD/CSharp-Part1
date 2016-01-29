using System;

// Problem 12.* Randomize the Numbers 1…N
// • Write a program that enters in integer  n  and prints 
// the numbers  1, 2, …, n  in random order.


    class RandomizeNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] output = new int[n];
            int randomNumber = 0;

            for (int i = 0; i < n; i++)
            {
                randomNumber = rnd.Next(1, n);
                output[i] = randomNumber;
                Console.Write("{0} ", output[i]);
                Console.WriteLine();
            }
        }
    }
