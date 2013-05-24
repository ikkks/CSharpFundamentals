// 8.Write an expression that calculates trapezoid's area by given sides a and b and height h

using System;

class TrapezoidsArea
{
    static void Main()
    {
        Console.WriteLine("Enter  trapezoid's parameters!");
        Console.WriteLine("Side a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Side b:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Height:");
        int h = int.Parse(Console.ReadLine());

        int area = ((a + b) / 2) * h; //Trapezoid area formula
        Console.WriteLine("The area of a trapezoid with sides a: {0}, b: {1} and h: {2} is {3}", a,b,h,area);
    }
}