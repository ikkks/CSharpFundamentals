// 2. Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CircleRadius
{
    static void Main()
    {
        Console.Write("Enter circle radius: ");
        double r = double.Parse(Console.ReadLine());
        double circlePerimeter = 2 * Math.PI * r;
        double circleArea = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("Area: {0}\nPerimeter: {1}", circleArea, circlePerimeter);
    }
}