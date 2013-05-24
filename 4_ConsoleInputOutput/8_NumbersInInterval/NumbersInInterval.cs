// 8. Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.Write("Enter number range:\nnumber = ");
        int number = int.Parse(Console.ReadLine());
        int numInRange = 0;

        // print all the numbers in range
        for (int i = 0; i < number; i++) 
        {
            numInRange = ++numInRange; // next number in range
            Console.WriteLine(numInRange);
        } 
    }
}