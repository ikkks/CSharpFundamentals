//Write a program that safely compares floating-point numbers with precision of 0.000001. 
//Examples:(5.3 ; 6.01) > false;  (5.00000001 ; 5.00000003) > true

using System;

namespace FloatingPoint
{
    class FloatingPoint
    {
        static void Main()
        {
            Console.WriteLine("First number: ");
            decimal first = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            decimal second = decimal.Parse(Console.ReadLine());
            bool compare = (Math.Abs(first - second) < 0.000001m); //Compare 
            Console.WriteLine(compare);
        }
    }
}
