using System;

// Problem 5. Third Digit is 7?
// • Write an expression that checks for given integer if its third digit from right-to-left is 7.

public class ThirdDigitIs7
{
    public static void Main()
    {
        while (true)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int countOfDigits = input.ToString().Length;

            if (countOfDigits >= 3)
            {
                int thirdDigit = countOfDigits - 3;
                char a = Convert.ToChar(input[thirdDigit]);
                if (a == '7')
                {
                    Console.WriteLine(a);
                    Console.WriteLine("Third digit = 7 --> " + (a == '7'));
                }
                else
                    Console.WriteLine("Third digit = 7 --> " + (a == '7'));
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}