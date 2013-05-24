// 3. Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestOfThree
{
    static void Main()
    {
        Console.Write("Enter three integer numbers:\nfirst = ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("second = ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("third = ");
        int third = int.Parse(Console.ReadLine());

        //check if  first is bigger
        if (first > second)
        {
            //check if third is bigger than first
            if (first > third)
            {
                Console.WriteLine("The first number ({0}) is the biggest!\n", first);
            }
            else
            {
                Console.WriteLine("The third number ({0}) is the biggest!\n", third);
            }
        }

        // if second is bigger
        else 
        {
            // check if third is bigger than second
            if (second > third)
            {
                Console.WriteLine("The second number ({0}) is the biggest!\n", second);
            }
            else 
            {
                Console.WriteLine("The third number ({0}) is the biggest!\n", third);
            }
        }
    }
}