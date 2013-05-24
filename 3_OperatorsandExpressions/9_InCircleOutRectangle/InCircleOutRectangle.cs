// 9. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class InCircleOutRectangle
{
    static void Main()
    {
        int circleRadius = 3;
        int circleCoordinates = 1; 
        
        Console.WriteLine("Enter x:"); //x coordinate 
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter y:"); //y coordinate
        int y = int.Parse(Console.ReadLine()) ; 

        //Bool statements Circle and Rectangle
        bool withinCircle = Math.Pow((x - circleCoordinates), 2) + Math.Pow((y - circleCoordinates), 2) <= Math.Pow(circleRadius, 2) ;
        bool withinRectangle = ((x > 1)&&(x < 7))&&((y < -1)&&(y > -3));

        if ((withinCircle == true) && (withinRectangle == false)) //check if the point is within the circle and out of the rectangle 
        {
            Console.WriteLine("The point IS within the circle and out of the rectangle");
        }
        else
        {
            Console.WriteLine("The point IS NOT within the circle and out of the rectangle");
        }

    }
}


 
