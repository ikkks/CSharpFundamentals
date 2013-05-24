// 6. Write a program that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0
// and calculates and prints its real roots. 
// Note that quadratic equations may have 0, 1 or 2 real roots.


using System;

class EnterCoefficients
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        double d = Math.Pow(b, 2) - (4 * a * c);
        if (d < 0)
        {
            Console.WriteLine("No real roots of this equation!");
        }
        else if (d == 0)
        {
            d = Math.Sqrt(d);
            double x = (-b + d) / (2 * a);
            Console.WriteLine("Equation have 1 real root x = " + x);
        }
        else
        {
            d = Math.Sqrt(d);
            double x1 = (-b + d) / (2 * a);
            double x2 = (-b - d) / (2 * a);
            Console.WriteLine("Equation have 2 real roots \nx1 = {0:0.000}\nx2 = {1:0.000}", x1, x2);
        }
    }
}