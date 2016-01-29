using System;

// Problem 4. Print a Deck of 52 Cards
// • Write a program that generates and prints all possible cards from a standard deck of 52 cards 
// (without the jokers). The cards should be printed using the classical notation 
// (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds). 
// ◦ The card faces should start from 2 to A.
// ◦ Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
// Use 2 nested for-loops and a switch-case statement.


public class PrintADeckOf52Cards
{
    public static void Main()
    {
        string letters = "JQKA";

        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
        }

        for (int j = 0; j < 4; j++)
        {
            switch (letters[j])
            {
                case 'A':
                    Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                    break;
                case 'J':
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    break;
                case 'Q':
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    break;
                case 'K':
                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                    break;
                default:
                    break;
            }
        }
    }
}
