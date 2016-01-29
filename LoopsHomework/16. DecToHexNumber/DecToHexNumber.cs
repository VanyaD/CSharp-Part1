using System;

// Problem 16. Decimal to Hexadecimal Number
// • Using loops write a program that converts an integer number to its hexadecimal representation.
// • The input is entered as long. The output should be a variable of type string.
// • Do not use the built-in .NET functionality.


class DecToHexNumber
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string output = string.Empty;
        string finalOutput = string.Empty;

        int remainder = 0;

        for (int i = 1; input > 0; i++)
        {
            remainder = input % 16;

            if (remainder >= 10)
            {
                switch (remainder)
                {
                    case 10:
                        output = "A";
                        break;
                    case 11:
                        output = "B";
                        break;
                    case 12:
                        output = "C";
                        break;
                    case 13:
                        output = "D";
                        break;
                    case 14:
                        output = "E";
                        break;
                    case 15:
                        output = "F";
                        break;
                }
            }
            else
            {
                output = remainder.ToString();
            }
            finalOutput = output + finalOutput;
            input = input / 16;
        }
        Console.WriteLine(finalOutput);
    }
}


