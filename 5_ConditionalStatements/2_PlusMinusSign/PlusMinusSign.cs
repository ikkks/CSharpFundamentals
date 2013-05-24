// 2. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
// Use a sequence of if statements.

using System;

class PlusMinusSign
{
    static void Main()
    {
        // enter numbers
        Console.Write("Enter three real numbers\nfirst = ");
        float firstNum = float.Parse(Console.ReadLine()) ;
        Console.Write("second = ");
        float secondNum = float.Parse(Console.ReadLine()) ;
        Console.Write("third = ");
        float thirdNum = float.Parse(Console.ReadLine());

        Console.WriteLine("\nThe sign of the product of the numbers {0}, {1} and {2} is:\n", firstNum, secondNum, thirdNum);
        string plus = "PLUS (+)\n" ;
        string minus = "MINUS (-)\n";

        //if all numbers are positive
        if ((firstNum > 0) && (secondNum > 0) && (thirdNum > 0))
        {
            Console.WriteLine(plus);
        }
        //if two negative numbers and first number is positive
        else if ((firstNum > 0) && (secondNum < 0) && (thirdNum < 0))
        {
            Console.WriteLine(plus);
        }
        //if two negative numbers and second number is positive
        else if ((firstNum < 0) && (secondNum > 0) && (thirdNum < 0))
        {
            Console.WriteLine(plus);
        }
        //if two negative numbers and third number is positive
        else if ((firstNum < 0) && (secondNum < 0) && (thirdNum > 0))
        {
            Console.WriteLine(plus);
        }
        // if one or three negative numbers
        else
        {
            Console.WriteLine(minus);
        }
    }
}