using System;

class NumberAsWords
{
    static void Main()
    {
        string n = Console.ReadLine();
        int number = int.Parse(n);
        int[] nums = new int[n.Length];
        string output = string.Empty;
        string output1 = string.Empty;
        string output3 = string.Empty;
        string output2 = string.Empty;
        string output4 = string.Empty;

        for (int i = 0; i < n.Length; i++)
        {
            nums[i] = n[i] - 48;
        }

        if (n.Length == 3)
        {
            switch (nums[0])
            {
                case 1:
                    output1 = "one";
                    break;
                case 2:
                    output1 = "two";
                    break;
                case 3:
                    output1 = "three";
                    break;
                case 4:
                    output1 = "four";
                    break;
                case 5:
                    output1 = "five";
                    break;
                case 6:
                    output1 = "six";
                    break;
                case 7:
                    output1 = "seven";
                    break;
                case 8:
                    output1 = "eight";
                    break;
                case 9:
                    output1 = "nine";
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
            switch (nums[1])
            {
                case 2:
                    output = "twenty";
                    break;
                case 3:
                    output = "thirty";
                    break;
                case 4:
                    output = "fourty";
                    break;
                case 5:
                    output = "fifty";
                    break;
                case 6:
                    output = "sixty";
                    break;
                case 7:
                    output = "seventy";
                    break;
                case 8:
                    output = "eighty";
                    break;
                case 9:
                    output = "ninty";
                    break;
                case 0:
                    break;
                case 1:
                    {
                        switch (nums[2])
                        {
                            case 0:
                                output2 = "ten";
                                break;
                            case 1:
                                output = "eleven";
                                break;
                            case 2:
                                output = "twelve";
                                break;
                            case 3:
                                output = "thirdteen";
                                break;
                            case 4:
                                output = "fourteen";
                                break;
                            case 5:
                                output = "fifteen";
                                break;
                            case 6:
                                output = "sixteen";
                                break;
                            case 7:
                                output = "seventeen";
                                break;
                            case 8:
                                output = "eighteen";
                                break;
                            case 9:
                                output = "nineteen";
                                break;
                        }
                        output4 = output1 + " " + "hundred and " + output;
                        Console.WriteLine(output4);
                        break;
                    }
            }

            if (nums[1] != 1)
            {
                switch (nums[2])
                {
                    case 2:
                        output2 = "two";
                        break;
                    case 3:
                        output2 = "three";
                        break;
                    case 4:
                        output2 = "four";
                        break;
                    case 5:
                        output2 = "five";
                        break;
                    case 6:
                        output2 = "six";
                        break;
                    case 7:
                        output2 = "seven";
                        break;
                    case 8:
                        output2 = "eight";
                        break;
                    case 9:
                        output2 = "nine";
                        break;
                }
                output3 = output1 + " " + "hundred and " + output + " " + output2;
                Console.WriteLine(output3);
            }
        }

        else if (n.Length == 2)
        {
            if ((number < 20) && (number > 9))
            {
                switch (n)
                {
                    case "10":
                        Console.WriteLine("ten");
                        break;
                    case "11":
                        Console.WriteLine("eleven");
                        break;
                    case "12":
                        Console.WriteLine("twelve");
                        break;
                    case "13":
                        Console.WriteLine("thirdteen");
                        break;
                    case "14":
                        Console.WriteLine("fourteen");
                        break;
                    case "15":
                        Console.WriteLine("fifteen");
                        break;
                    case "16":
                        Console.WriteLine("sixteen");
                        break;
                    case "17":
                        Console.WriteLine("seventeen");
                        break;
                    case "18":
                        Console.WriteLine("eighteen");
                        break;
                    case "19":
                        Console.WriteLine("nineteen");
                        break;
                    case "20":
                        Console.WriteLine("twenty");
                        break;
                }
            }
            else
            {

                switch (nums[1])
                {
                    case 1:
                        output1 = "one";
                        break;
                    case 2:
                        output1 = "two";
                        break;
                    case 3:
                        output1 = "three";
                        break;
                    case 4:
                        output1 = "four";
                        break;
                    case 5:
                        output1 = "five";
                        break;
                    case 6:
                        output1 = "six";
                        break;
                    case 7:
                        output1 = "seven";
                        break;
                    case 8:
                        output1 = "eight";
                        break;
                    case 9:
                        output1 = "nine";
                        break;
                    default:
                        output1 = "zero";
                        break;
                }
                switch (nums[0])
                {
                    case 2:
                        output = output + "twenty" + " " + output1;
                        break;
                    case 3:
                        output = output + "thirty" + " " + output1;
                        break;
                    case 4:
                        output = output + "fourty" + " " + output1;
                        break;
                    case 5:
                        output = output + "fifty" + " " + output1;
                        break;
                    case 6:
                        output = output + "sixty" + " " + output1;
                        break;
                    case 7:
                        output = output + "seventy" + " " + output1;
                        break;
                    case 8:
                        output = output + "eighty" + " " + output1;
                        break;
                    case 9:
                        output = output + "ninty" + " " + output1;
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
                Console.WriteLine(output);
            }
        }
        else if (n.Length == 1)
        {
            switch (n)
            {
                case "1":
                    Console.WriteLine("one");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "3":
                    Console.WriteLine("three");
                    break;
                case "4":
                    Console.WriteLine("four");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;
                case "6":
                    Console.WriteLine("six");
                    break;
                case "7":
                    Console.WriteLine("seven");
                    break;
                case "8":
                    Console.WriteLine("eight");
                    break;
                case "9":
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("zero");
                    break;
            }
        }
    }
}
