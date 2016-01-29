using System;

// Problem 7. Sort 3 Numbers with Nested Ifs
// • Write a program that enters 3 real numbers and prints them sorted in descending order. 
// ◦ Use nested  if  statements.

// Note: Don’t use arrays and the built-in sorting functionality.

public class Sort3NumbersWithNestedIfs
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter three numbers.");

            Console.Write("A = ");
            double numberA = double.Parse(Console.ReadLine());

            Console.Write("B = ");
            double numberB = double.Parse(Console.ReadLine());

            Console.Write("C = ");
            double numberC = double.Parse(Console.ReadLine());


            if ((numberA >= numberB) && (numberA >= numberC))
            {
                if (numberB >= numberC)
                {
                    Console.WriteLine(numberA + " " + numberB + " " + numberC);
                }
                else
                {
                    Console.WriteLine(numberA + " " + numberC + " " + numberB);
                }
            }
            else if ((numberB >= numberA) && (numberB >= numberC))
            {
                if (numberA >= numberC)
                {
                    Console.WriteLine(numberB + " " + numberA + " " + numberC);
                }
                else
                {
                    Console.WriteLine(numberB + " " + numberC + " " + numberA);
                }
            }
            else if ((numberC >= numberA) && (numberC >= numberB))
            {
                if (numberA >= numberB)
                {
                    Console.WriteLine(numberC + " " + numberA + " " + numberB);
                }
                else
                {
                    Console.WriteLine(numberC + " " + numberB + " " + numberA);
                }
            }
        }
    }
}
