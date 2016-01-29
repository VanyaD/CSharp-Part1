using System;

// Problem 5. The Biggest of 3 Numbers
// • Write a program that finds the biggest of three numbers.

public class TheBiggestOf3Numbers
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

            if ((numberA > numberB) && (numberA > numberC))
            {
                Console.WriteLine("The biggest number is {0}", numberA);
            }
            else if ((numberB > numberA) && (numberB > numberC))
            {
                Console.WriteLine("The biggest number is {0}", numberB);
            }
            else if ((numberC > numberA) && (numberC > numberB))
            {
                Console.WriteLine("The biggest number is {0}", numberC);
            }
            else if ((numberA == numberB) && (numberA > numberC))
            {
                Console.WriteLine("The bigest number is {0}", numberA);
            }
            else if ((numberA == numberC) && (numberA > numberB))
            {
                Console.WriteLine("The biggest number is {0}", numberA);
            }
            else if ((numberB == numberC) && (numberB > numberA))
            {
                Console.WriteLine("The biggest number is {0}", numberB);
            }
            else if ((numberA == numberB) && (numberA == numberC))
            {
                Console.WriteLine("The biggest number is {0}", numberC);
            }
        }
    }
}
