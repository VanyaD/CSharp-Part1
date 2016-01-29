using System;

// Problem 6. Calculate N! / K!
// • Write a program that calculates  n! / k!  for given  n  and  k  (1 < k < n < 100).
// • Use only one loop.

    class CalculateNFactDividedByKFact
    {
        static void Main()
        {
            Console.WriteLine("Please enter n and k, where 1 < k < n < 100.");

            Console.Write("n = ");
            int numberN = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int numberK = int.Parse(Console.ReadLine());

            int factN = 1;
            int factK = 1;


            for (int i = 1; i <= numberN; i ++ )
            {
                factN = factN * i;
                if (i == numberK)
                {
                    factK = factN;
                }
            }
            Console.WriteLine("{0}!/{1}! = {2}", numberN, numberK, factN / factK);
        }
    }
