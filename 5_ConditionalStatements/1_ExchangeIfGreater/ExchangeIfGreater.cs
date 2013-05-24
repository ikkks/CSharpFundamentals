// 1. Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter two numbers:\nFirst = ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Second = ");
        int second = int.Parse(Console.ReadLine());

        if (first > second)
        {
            Console.WriteLine("The first number is bigger!\n");
            int saveNumber = first;
            first = second;
            second = saveNumber;
            Console.WriteLine("First number now is {0}\nSecond number now is {1}\n\n", first, second);
        }
        else 
        {
            Console.WriteLine("The second number is bigger! Values are not switched.");
        }

    }
}