using System;

// Problem 6. The Biggest of Five Numbers
// • Write a program that finds the biggest of five numbers by using only five if statements.


public class TheBiggestOfFiveNumbers
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter five numbers.");

            Console.Write("A = ");
            double numberA = double.Parse(Console.ReadLine());

            Console.Write("B = ");
            double numberB = double.Parse(Console.ReadLine());

            Console.Write("C = ");
            double numberC = double.Parse(Console.ReadLine());

            Console.Write("D = ");
            double numberD = double.Parse(Console.ReadLine());

            Console.Write("E = ");
            double numberE = double.Parse(Console.ReadLine());

            if ((numberA >= numberB) && (numberA >= numberC) && (numberA >= numberD) && (numberA >= numberE))
            {
                Console.WriteLine("The biggest number is {0}", numberA);
            }
            else if ((numberB >= numberA) && (numberB >= numberC) && (numberB >= numberD) && (numberB >= numberE))
            {
                Console.WriteLine("The biggest number is {0}", numberB);
            }
            else if ((numberC >= numberB) && (numberC >= numberA) && (numberC >= numberD) && (numberC >= numberE))
            {
                Console.WriteLine("The biggest number is {0}", numberC);
            }
            else if ((numberD >= numberB) && (numberD >= numberC) && (numberD >= numberA) && (numberD >= numberE))
            {
                Console.WriteLine("The biggest number is {0}", numberD);
            }
            else if ((numberE >= numberB) && (numberE >= numberC) && (numberE >= numberD) && (numberE >= numberA))
            {
                Console.WriteLine("The biggest number is {0}", numberE);
            }
        }
    }
}
