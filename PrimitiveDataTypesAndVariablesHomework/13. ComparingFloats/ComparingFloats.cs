using System;

/*
Problem 13.* Comparing Floats
• Write a program that safely compares floating-point numbers (double) with precision  eps = 0.000001 .
Note: Two floating-point numbers  a  and  b  cannot be compared directly by  a == b  
because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are 
equal if they are more closely to each other than a fixed constant  eps.
*/

public class ComparingFloats
{
    public static void Main()
    {
        double a = 5.00000001;
        double b = 5.00000003;
        double c = Math.Abs(a - b);
        float eps = 0.000001f;

        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", a);

        if (c < eps)
        {
            Console.WriteLine("Difference is {0:f10} --> the numbers are equal", c);
        }
        else
        {
            Console.WriteLine("Difference is {0:f10} --> the numbers are not equal", c);
        }
    }
}
