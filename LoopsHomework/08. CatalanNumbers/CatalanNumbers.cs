using System;

// In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula 
// • Write a program to calculate the  nth  Catalan number by given  n  (1 < n < 100). 

public class CatalanNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double fact2N = 1;
        double factNPlus1 = 1;
        double factN = 1;
        double output = 0;
        double factorial = 1;

        for (int i = 1; i <= 2 * n; i++)
        {
            factorial = factorial * i;

            if (i == n)
            {
                factN = factorial;
            }

            if (i == 2 * n)
            {
                fact2N = factorial;
            }

            if (i == n + 1)
            {
                factNPlus1 = factorial;
            }
        }

        output = fact2N / (factNPlus1 * factN);
        Console.WriteLine(output);
    }
}
