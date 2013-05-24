// 7. Write a program that finds the greatest of given 5 variables.

using System;

class GreatestOfFive
{
    static void Main()
    {
        //enter variables
        Console.Write("Enter five numbers:\n\nfirst = ");
        int first = int.Parse(Console.ReadLine()); 
        Console.Write("second = ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("third = ");
        int third = int.Parse(Console.ReadLine());
        Console.Write("forth = ");
        int forth = int.Parse(Console.ReadLine());
        Console.Write("fifth = ");
        int fifth = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe biggest of those 5 numbers is:\n");

        //compare  variables
        if ((first > second) && (first > third) && (first > forth) && (first > fifth))
        {
            Console.WriteLine("fisrt - {0}\n",first);
        }
        else if ((second > first) && (second > third) && (second > forth) && (second > fifth))
        {
            Console.WriteLine("second - {0}\n", second);
        }
        else if ((third > first) && (third > second) && (third > forth) && (third > fifth))
        {
            Console.WriteLine("third - {0}\n", third);
        }
        else if ((forth > first) && (forth > second) && (forth > third) && (forth > fifth))
        {
            Console.WriteLine("forth - {0}\n", forth);
        }
        else
        {
            Console.WriteLine("fifth - {0}\n", fifth);
        }
    }
}
