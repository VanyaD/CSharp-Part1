using System;
using System.Globalization;

// Problem 10.* Beer Time
// • A beer time is after  1:00 PM  and before  3:00 AM .
// • Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
// a minute in range [00…59] and AM / PM designator) and prints  beer time  or  non-beer time 
// according to the definition above or  invalid time  if the time cannot be parsed. 
// Note: You may need to learn how to parse dates and times

public class BeerTime
{
    public static void Main(string[] args)
    {
        Console.Write("Please enter a time in the following format hh:mm tt: ");
        string input = Console.ReadLine();

        DateTime dateTime1 = DateTime.ParseExact(input, "hh:mm tt", CultureInfo.InvariantCulture);
        Console.WriteLine(dateTime1);

        try
        {
            DateTime dateTime = DateTime.ParseExact(input, "hh:mm tt", CultureInfo.InvariantCulture);
            Console.WriteLine(dateTime);

            TimeSpan time = dateTime.TimeOfDay;
            TimeSpan startTime = new TimeSpan(13, 0, 0);
            TimeSpan endTime = new TimeSpan(03, 0, 0);

            if ((time >= startTime) || (time <= endTime))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("invalid time");
        }
    }
}
