using System;

//Problem 8. Isosceles Triangle
//• Write a program that prints an isosceles triangle of 9 copyright symbols  © 

public class IsoscelesTriangle
{
    public static void Main()
    {
        char copyrightSymbol = '\u00A9';
        Console.WriteLine("   " + copyrightSymbol);
        Console.WriteLine("  " + copyrightSymbol + " " + copyrightSymbol);
        Console.WriteLine(" " + copyrightSymbol + "  " + " " + copyrightSymbol);

        for (int i = 1; i <= 4; i++)
        {
            Console.Write(copyrightSymbol + " ");
        }

        Console.WriteLine();
    }
}
