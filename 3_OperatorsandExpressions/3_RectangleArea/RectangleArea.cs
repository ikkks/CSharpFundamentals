//3.Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter width:");
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter height:");
        int height = int.Parse(Console.ReadLine());

        int area = width * height;
        Console.WriteLine("The area of rectangle with width {0} and height {1} is: {2}", width, height, area);

    }
}
