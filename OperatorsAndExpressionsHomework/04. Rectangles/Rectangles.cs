using System;

// Problem 4. Rectangles
// • Write an expression that calculates rectangle’s perimeter and area by given width and height.

public class Rectangles
{
    public static void Main()
    {
        while (true)
        {
            Console.Write("Please enter rectangle width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Please enter rectangle height: ");
            double height = double.Parse(Console.ReadLine());

            double parameter = (2 * width) + (2 * height);
            double area = width * height;

            Console.WriteLine("The perimeter of the rectangle is: " + parameter);
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}
