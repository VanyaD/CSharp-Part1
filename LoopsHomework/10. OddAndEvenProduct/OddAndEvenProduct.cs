using System;

// Problem 10. Odd and Even Product
// • You are given  n  integers (given in a single line, separated by a space).
// • Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// • Elements are counted from  1  to  n , so the first element is odd, the second is even, etc.


public class OddAndEvenProduct
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] strArr = input.Split(' ');
        int[] nums = new int[strArr.Length];

        for (int i = 0; i < strArr.Length; i++)
        {
            nums[i] = int.Parse(strArr[i]);
        }

        double oddProduct = nums[0];
        double evenProduct = nums[1];

        for (int i = 2; i <= strArr.Length - 1; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct = oddProduct * nums[i];
            }
            else
            {
                evenProduct = evenProduct * nums[i];
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
