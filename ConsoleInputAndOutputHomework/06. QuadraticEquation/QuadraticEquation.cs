using System;

// Problem 6. Quadratic Equation
// • Write a program that reads the coefficients  a ,  b  and  c  of a quadratic equation ax2 + bx + c = 0 
// and solves it (prints its real roots).

public class QuadraticEquation
{
    public static void Main()
    {
        Console.WriteLine("Please enter the values of coefficients a, b and c: ");
        double coeffA = double.Parse(Console.ReadLine());
        double coeffB = double.Parse(Console.ReadLine());
        double coeffC = double.Parse(Console.ReadLine());

        double expressionUnderSqrt = (coeffB * coeffB) - (4 * coeffA * coeffC);

        if (expressionUnderSqrt < 0)
        {
            Console.WriteLine("This quadratic equation has no real roots.");
        }
        else
        {
            double rootX1 = (-coeffB + Math.Sqrt(expressionUnderSqrt)) / (2 * coeffA);
            double rootX2 = (-coeffB - Math.Sqrt(expressionUnderSqrt)) / (2 * coeffA);
            Console.WriteLine("The real roots of this quadratic equation are: x1 = {0} and x2 = {1}", rootX1, rootX2);
        }
    }
}
