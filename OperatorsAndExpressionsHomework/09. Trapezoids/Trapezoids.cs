using System;

// Problem 9. Trapezoids
// • Write an expression that calculates trapezoid's area by given sides  a  and  b  and height  h.

public class Trapezoids
{
    public static void Main()
    {
        Console.WriteLine("Please enter trapezoid's side A: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter trapezoid's side B: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter trapezoid's height: ");
        double height = double.Parse(Console.ReadLine());

        double area = ((sideA + sideB) * height) / 2;
        Console.WriteLine("The area of the trapezoid is {0}.", area);
    }
}
