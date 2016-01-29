using System;

// Problem 2. Print Company Information
// • A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name,
// age and a phone number.
// • Write a program that reads the information about a company and its manager and prints it back on the console.


public class PrintCompanyInformation
{
    public static void Main()
    {
        Console.WriteLine("Please enter the following information:");
        Console.Write("Company Name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company Address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone Number: ");
        double companyPhoneNumber = double.Parse(Console.ReadLine());

        Console.Write("Fax Number: ");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Web Site: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Manager First Name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager Last Name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager Age: ");
        int managerAge = int.Parse(Console.ReadLine());

        Console.Write("Manager Phone: ");
        double managerPhone = double.Parse(Console.ReadLine());

        string managerFullName = (managerFirstName + " " + managerLastName);

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0:+359 ### ## ## ###}", companyPhoneNumber);

        if (companyFaxNumber == "")
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}", companyFaxNumber);
        }

        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager: {0} (age: {1}, tel. {2:+359 # ### ###})", managerFullName, managerAge, managerPhone);
    }
}
