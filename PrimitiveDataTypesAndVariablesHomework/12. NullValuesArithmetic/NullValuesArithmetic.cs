using System;

/* Problem 12. Null Values Arithmetic
• Create a program that assigns null values to an integer and to a double variable. 
• Try to print these variables at the console. 
• Try to add some number or the null literal to these variables and print the result.
*/

public class NullValuesArithmetic
{
    public static void Main()
    {
        int? a = null;
        double? b = null;
        double? c = 1.555;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
