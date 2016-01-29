using System;

// Problem 3. Circle Perimeter and Area
// • Write a program that reads the radius  r  of a circle and prints its perimeter and area formatted 
// with  2  digits after the decimal point.

public class CirclePerimeterAndArea
{
    public static void Main()
    {
        Console.Write("Please enter r (radius of the circle):");
        double radius = double.Parse(Console.ReadLine());

        double area = radius * radius * Math.PI;
        double perimeter = 2 * radius * Math.PI;

        Console.WriteLine("Area: {0: #.##}", area);
        Console.WriteLine("Perimeter: {0: #.##}", perimeter);
    }
}
