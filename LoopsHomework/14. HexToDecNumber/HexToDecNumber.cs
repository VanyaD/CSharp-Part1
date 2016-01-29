using System;

// Problem 15. Hexadecimal to Decimal Number
// • Using loops write a program that converts a hexadecimal integer number to its decimal form.
// • The input is entered as string. The output should be a variable of type long.
// • Do not use the built-in .NET functionality.

public class HexToDecNumber
{
    public static void Main()
    {
        string input = Console.ReadLine();
        long output = 0;
        int code = 0;

        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'A':
                    code = 10;
                    break;
                case 'B':
                    code = 11;
                    break;
                case 'C':
                    code = 12;
                    break;
                case 'D':
                    code = 13;
                    break;
                case 'E':
                    code = 14;
                    break;
                case 'F':
                    code = 15;
                    break;
                default:
                    code = int.Parse(input[i].ToString());
                    break;
            }

            output = output + code * (long)(Math.Pow(16, input.Length - 1 - i));
        }

        Console.WriteLine(output);
    }
}
