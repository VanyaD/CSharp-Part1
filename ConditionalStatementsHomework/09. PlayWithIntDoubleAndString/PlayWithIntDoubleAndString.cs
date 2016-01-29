using System;

// Problem 9. Play with Int, Double and String
// • Write a program that, depending on the user’s choice, inputs an  int ,  double  or  string  variable. 
// ◦ If the variable is  int  or  double , the program increases it by one.
// ◦ If the variable is a  string , the program appends  *  at the end.

//• Print the result at the console. Use switch statement

public class PlayWithIntDoubleAndString
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            byte choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Please enter an integer number:");
                    int inputChoiceInt = int.Parse(Console.ReadLine());
                    int resultChoiceInt = inputChoiceInt + 1;
                    Console.WriteLine(resultChoiceInt);
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write("Please enter a double number:");
                    double inputChoiceDouble = double.Parse(Console.ReadLine());
                    double resultChoiceDouble = inputChoiceDouble + 1;
                    Console.WriteLine(resultChoiceDouble);
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("Please enter string variable:");
                    string inputChoiceString = Console.ReadLine();
                    string resultChoiceString = inputChoiceString + '*';
                    Console.WriteLine(resultChoiceString);
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }
    }
}
