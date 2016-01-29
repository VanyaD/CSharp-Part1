using System;

// Problem 4. Multiplication Sign
// • Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. 
// ◦ Use a sequence of  if  operators.

public class MultiplicationSign
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter three real numbers.");

            Console.Write("A = ");
            double numberA = double.Parse(Console.ReadLine());

            Console.Write("B = ");
            double numberB = double.Parse(Console.ReadLine());

            Console.Write("C = ");
            double numberC = double.Parse(Console.ReadLine());

            if ((numberA == 0) || (numberB == 0) || (numberC == 0))
            {
                Console.WriteLine("The result of the product of the numbers you have entered is 0.");
            }
            else if ((numberA < 0) && (numberB < 0) && (numberC < 0))
            {
                Console.WriteLine("The sign of the product of these three numbers is -");
            }
            else if ((numberA < 0) && (numberB < 0) && (numberC > 0))
            {
                Console.WriteLine("The sign of the product of these three numbers is +");
            }
            else if ((numberA < 0) && (numberB > 0) && (numberC < 0))
            {
                Console.WriteLine("The sign of the product of these three numbers is +");
            }
            else if ((numberA < 0) && (numberB > 0) && (numberC > 0))
            {
                Console.WriteLine("The sign of the product of these three numbers is -");
            }
            else if ((numberA > 0) && (numberB < 0) && (numberC < 0))
            {
                Console.WriteLine("The sign of the product of these three numbers is +");
            }
            else if ((numberA > 0) && (numberB > 0) && (numberC < 0))
            {
                Console.WriteLine("The sign of the product of these three numbers is +");
            }
            else if ((numberA > 0) && (numberB < 0) && (numberC > 0))
            {
                Console.WriteLine("The sign of the product of these three numbers is +");
            }
            else if ((numberA > 0) && (numberB > 0) && (numberC > 0))
            {
                Console.WriteLine("The sign of the product of these three numbers is +");
            }
        }
    }
}
