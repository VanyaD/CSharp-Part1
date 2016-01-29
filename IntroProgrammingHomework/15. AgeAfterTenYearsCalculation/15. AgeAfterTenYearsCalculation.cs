using System;

// Problem 15.* Age after 10 Years
// • Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.


    class AgeAfterTenYearsCalculation
    {
        static void Main()
        {
            Console.Write("Please enter your birthday (DD/MM/YYYY): ");
            string birthday = Console.ReadLine();
            DateTime dt = Convert.ToDateTime(birthday);
            DateTime today = DateTime.Today;
            int age = today.Year - dt.Year;
            int newage = (today.Year - dt.Year) + 10;
            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("After 10 years you will be {0} years old.", newage);
        }
    }
 