using System;

// Problem 13. Binary to Decimal Number
// • Using loops write a program that converts a binary integer number to its decimal form.
// • The input is entered as string. The output should be a variable of type long.
// • Do not use the built-in .NET functionality.

public class BinaryToDecNumber
{
    public static void Main()
    {
        string input = Console.ReadLine();

        long output = 0L;

        for (int i = 0; i < input.Length; i++)
        {
            output = output + (long.Parse(input[i].ToString()) * (long)(Math.Pow(2, input.Length - 1 - i)));
        }

        Console.WriteLine(output);
    }
}
