//2.Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class Devidedby5and7
{
    static void Main()
    {
        Console.WriteLine("Enter Number:");
        int number = int.Parse(Console.ReadLine());

        //If statement that checks if the number is odd or Even
        if ((number % 5 == 0) && (number % 7 == 0))
        {
            Console.WriteLine("Cool! The number can be divided by 5 and 7 with no remainder!");
        }
        else
        {
            Console.WriteLine("The number can not be divided by 5 and 7 at the same time!");

            // Checks if the number can be divided by at least one of the numbers
            if (number % 5 == 0)
            {
                Console.WriteLine("Yet it divides by 5!");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Yet it divides by 7!");
            }
            else
            {
            }
        }
    }
}
