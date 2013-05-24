// 4. Sort 3 real values in descending order using nested if statements.

using System;

class DescendingOrder
{
    static void Main()
    {
        Console.Write("Enter three real numbers\nfirst = ");
        float first = float.Parse(Console.ReadLine());
        Console.Write("second = ");
        float second = float.Parse(Console.ReadLine());
        Console.Write("third = ");
        float third = float.Parse(Console.ReadLine());

        Console.WriteLine("\nDescending order of the three numbers above:\n");

        //check if first number is the biggest of all three
        if ((first > second) && (first > third))
        {
            Console.Write("{0}, ",first);
            if (second > third)
            {
                Console.Write("{0}, ", second);
                Console.Write("{0}\n\n", third);
            }
            else 
            {
                Console.Write("{0}, ", third);
                Console.Write("{0}\n\n", second);
            }
        }

        //check if second number is the biggest of all three
        else if ((second > first) && (second > third))
        {
            Console.Write("{0}, ", second);
            if (first > third)
            {
                Console.Write("{0}, ", first);
                Console.Write("{0}\n\n", third);
            }
            else
            {
                Console.Write("{0}, ", third);
                Console.Write("{0}\n\n", first);
            }
        }

        //check if third number is the biggest of all three
        else
        {
            Console.Write("{0}, ", third);
            if (first > second)
            {
                Console.Write("{0}, ", first);
                Console.Write("{0}\n\n", second);
            }
            else
            {
                Console.Write("{0}, ", second);
                Console.Write("{0}\n\n", first);
            }
        }
    }
}