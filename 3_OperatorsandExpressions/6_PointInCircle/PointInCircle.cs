//6. Write an expression that checks if given point (x,  y) is within a circle K(O, 5)

using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter x:"); //enter x coordinate 
        int xPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter y:"); // enter y coordinate
        int yPosition = int.Parse(Console.ReadLine());

        int circleRadius = 5;

        if ((Math.Pow(xPosition, 2) + Math.Pow(yPosition, 2)) <= (Math.Pow(circleRadius, 2))) //check if the pint is within the circle 
        {
            Console.WriteLine("The given point is within a circle with radius 5");
        }
        else
        {
            Console.WriteLine("The given point is not within a circle with radius 5!");
        }
    }
}