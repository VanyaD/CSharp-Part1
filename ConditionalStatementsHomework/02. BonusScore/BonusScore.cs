using System;

// Problem 2. Bonus Score
// • Write a program that applies bonus score to given score in the range  [1…9]  by the following rules: 
// ◦ If the score is between  1  and  3 , the program multiplies it by  10 .
// ◦ If the score is between  4  and  6 , the program multiplies it by  100 .
// ◦ If the score is between  7  and  9 , the program multiplies it by  1000 .
// ◦ If the score is  0  or more than  9 , the program prints  “invalid score” .


public class BonusScore
{
    public static void Main()
    {
        Console.Write("Please enter your current score: ");
        int currentScore = int.Parse(Console.ReadLine());
        int newScore = 0;

        if ((currentScore >= 1) && (currentScore <= 3))
        {
            newScore = currentScore * 10;
            Console.WriteLine("Your new score is: {0}", newScore);
        }
        else if ((currentScore > 3) && (currentScore <= 6))
        {
            newScore = currentScore * 100;
            Console.WriteLine("Your new score is: {0}", newScore);
        }
        else if ((currentScore >= 7) && (currentScore <= 9))
        {
            newScore = currentScore * 1000;
            Console.WriteLine("Your new score is: {0}", newScore);
        }
        else if ((currentScore > 9) || (currentScore == 0))
        {
            Console.WriteLine("Invalid score");
        }
    }
}
