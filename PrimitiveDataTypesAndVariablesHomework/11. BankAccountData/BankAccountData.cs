using System;

// Problem 11. Bank Account Data
// • A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
// bank name, IBAN, 3 credit card numbers associated with the account.
// • Declare the variables needed to keep the information for a single bank account using the appropriate data types 
// and descriptive names.

public class BankAccountData
{
    public static void Main()
    {
        string firstName = "Vanya";
        string middleName = "Dobreva";
        string lastName = "Karaasenova";
        string holderName = firstName + " " + middleName + " " + lastName;
        decimal accountBalance = 1000.58m;
        string bankName = "DSK";
        string iban = "BG aa12 vv21 3311 2351";
        string creditCardNumber1 = "3782822463100051";
        string creditCardNumber2 = "3782822463100061";
        string creditCardNumber3 = "3782822463100071";

        Console.WriteLine("Holder Name: {0}", holderName);
        Console.WriteLine("Balance: {0}", accountBalance);
        Console.WriteLine("Bank Name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit Card Number 1: {0}", creditCardNumber1);
        Console.WriteLine("Credit Card Number 2: {0}", creditCardNumber2);
        Console.WriteLine("Credit Card Number 3: {0}", creditCardNumber3);
    }
}
