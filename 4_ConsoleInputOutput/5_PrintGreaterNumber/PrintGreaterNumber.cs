// 5. Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class PrintGreaterNumber
{
    static void Main()
    {
        Console.Write("Enter two numbers\nFirst: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Second: ");
        int num2 = int.Parse(Console.ReadLine());
        bool firstBigger = num1 > num2; // true if the first number is bigger

        //Print the bigger number
        Console.Write("The bigger number is: ");
        Console.WriteLine(firstBigger ? num1 : num2);
    }
}