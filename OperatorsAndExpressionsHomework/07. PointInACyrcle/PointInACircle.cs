using System;

// Problem 7. Point in a Circle
// • Write an expression that checks if given point (x, y) is inside a circle  K({0, 0}, 2).


public class PointInACircle
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter point coordinates:");
            Console.Write("x = ");
            double pointX = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            Console.WriteLine();
            double pointY = double.Parse(Console.ReadLine());
            double diagonalSqrt = Math.Sqrt((pointX * pointX) + (pointY * pointY));

            if (diagonalSqrt > 2)
            {
                Console.WriteLine("Point with coordinates x = {0} and y = {1} is not inside circle K.", pointX, pointY);
            }
            else
            {
                Console.WriteLine("Point with coordinates x = {0} and y = {1} is inside circle K.", pointX, pointY);
            }
        }
    }
}
