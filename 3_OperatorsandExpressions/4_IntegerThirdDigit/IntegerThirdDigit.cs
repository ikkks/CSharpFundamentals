//4.Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 > true.

using System;

class IntegerThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter an int number:");
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = (number / 100) % 10; //This is the remain of the initial number. In this case this is the third digit from the initial number entered

        //Check if the third number right to left is 7
        if (thirdDigit == 7) 
        {
            Console.WriteLine("Yes!\nThe third digit right to left of this numer is 7");
        }
        else
        {
            Console.WriteLine("No!\nThe third digit right to left of this numer is not 7");
        }
    }
}