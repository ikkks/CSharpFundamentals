// 1. Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class Print3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers:");
        int number1 = Int32.Parse(Console.ReadLine());
        int number2 = Int32.Parse(Console.ReadLine());
        int number3 = Int32.Parse(Console.ReadLine());
        int sum = number1 + number2 + number3;

        Console.WriteLine("The sum of the three numbers above is: {0}", sum);
    }
}