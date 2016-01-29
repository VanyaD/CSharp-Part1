using System;

// Problem 1. Declare Variables
// • Declare five variables choosing for each of them the most appropriate of the types 
// byte, sbyte, short, ushort, int, uint, long, ulong  to represent the following values:  52130, -115, 4825932, 97, -10000 .
// • Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

public class VariablesDeclaration
{
    public static void Main(string[] args)
    {

        sbyte b = -115;
        byte d = 97;
        short f = -10000;
        ushort a = 52130;
        uint c = 4825932;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(f);
    }
}
