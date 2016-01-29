using System;

// Problem 11. Random Numbers in Given Range
// • Write a program that enters  3  integers  n ,  min  and  max  ( min != max ) and 
// prints  n  random numbers in the range  [min...max] 

public class RandomNumbersInGivenRange
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();

        for (int i = 1; i <= n; i++)
        {
            int output = rnd.Next(min, max);
            Console.Write("{0} ", output);
        }

        Console.WriteLine();
    }
}
