using System;

// Problem 5. Formatting Numbers
// • Write a program that reads 3 numbers: 
// ◦ integer  a  (0 <= a <= 500)
// ◦ floating-point  b  
// ◦ floating-point  c  

// • The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. 
// ◦ The number  a  should be printed in hexadecimal, left aligned
// ◦ Then the number  a  should be printed in binary form, padded with zeroes
// ◦ The number  b  should be printed with 2 digits after the decimal point, right aligned
// ◦ The number c should be printed with 3 digits after the decimal point, left aligned. 

public class FormattingNumbers
{
    public static void Main()
    {
        Console.WriteLine("Please enter three numbers: ");
        short firstNumber = short.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        string binary = Convert.ToString(firstNumber, 2).PadLeft(10, '0');

        Console.Write("{0,-10:X}|{1, 10}|{2,10:F2}|{3,-10:F3}", firstNumber, binary, secondNumber, thirdNumber);
    }
}
