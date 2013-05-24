//1. Write an expression that checks if given integer is odd or even.

using System;

class OddorEven
{
    static void Main()
    {

        Console.WriteLine("Enter an Odd or Even Number:");
        int number = int.Parse(Console.ReadLine());

        //If statement that checks if the number is odd or Even
        if (number % 2 == 0)
        {
            Console.WriteLine("The number you entered is Even!");
        }
        else
        {
            Console.WriteLine("The number you entered is Odd!");
        }

    }
}

