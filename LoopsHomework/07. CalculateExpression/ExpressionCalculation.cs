using System;

// Problem 7. Calculate N! / (K! * (N-K)!)
// • In combinatorics, the number of ways to choose  k  different members out of a group of  n  different elements 
// (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways 
// to withdraw 5 cards out of a standard deck of 52 cards.
// • Your task is to write a program that calculates  n! / (k! * (n-k)!)  for given  n  and  k  (1 < k < n < 100). Try to use only two loops.


class ExpressionCalculation
{
    static void Main()
    {
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter k: ");
        int k = int.Parse(Console.ReadLine());

        double output = 0;
        double factN = 1;
        double factK = 1;
        double factNMinK = 1;
        int nMinK = n - k;

        for (int i = 1; i <= n; i++)
        {
            factN = factN * i;
            if (i == k)
            {
                factK = factN;
            }
            if (i == nMinK)
            {
                factNMinK = factN;
            }          
        }
        output = factN / (factK * factNMinK);
        Console.WriteLine("Result = {0}", output);
    }
}
