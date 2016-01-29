using System;

// Problem 15.* Age after 10 Years
// • Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

public class AgeAfterTenYearsCalculation
{
    public static void Main()
    {
        Console.Write("Please enter your birthday (MM/DD/YYYY): ");
        string input = Console.ReadLine();
        int age;
        int ageAfterTenYears;
        DateTime dateOfBirth = Convert.ToDateTime(input);
        DateTime today = DateTime.Today;

        if ((today.Month > dateOfBirth.Month) ||
            (today.Month == dateOfBirth.Month && today.Day > dateOfBirth.Day))
        {
            age = today.Year - dateOfBirth.Year;
            ageAfterTenYears = age + 10;
        }
        else
        {
            age = today.Year - dateOfBirth.Year - 1;
            ageAfterTenYears = age + 10;
        }

        Console.WriteLine("You are {0} years old.", age);
        Console.WriteLine("After 10 years you will be {0} years old.", ageAfterTenYears);
    }
}
