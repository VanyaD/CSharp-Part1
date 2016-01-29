using System;

// Problem 14. Decimal to Binary Number
// • Using loops write a program that converts an integer number to its binary representation.
// • The input is entered as long. The output should be a variable of type string.
// • Do not use the built-in .NET functionality.


class DecimalToBinaryNumber
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string output = string.Empty;
        long remainder;

        while (input > 0)
        {
            remainder = input % 2;
            input = input / 2;
            output = remainder.ToString() + output;
        }
        Console.WriteLine(output);
    }
}
