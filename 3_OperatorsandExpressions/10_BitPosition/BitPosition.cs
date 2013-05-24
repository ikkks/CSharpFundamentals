// 10. Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 > false.

using System;

class BitPosition
{
    static void Main()
    {
        Console.Write("Number: ");
        int v = int.Parse(Console.ReadLine()); // number
        Console.Write("Bit position: ");
        int p = int.Parse(Console.ReadLine()); // bit position

        int helpElement = 1; //1 is equal to 0000 0001
        helpElement = helpElement << p ; //the bit at position p is 1 now

        int compareBits = v & helpElement; //compare bits
        bool result = compareBits != 0;  // True for compareBits equal to 1 and False for compareBits equal to 0

        if (compareBits != 0)
        {
            Console.WriteLine("{0}: The bit on position {1} is 1", result, p);
        }
        else
        {
            Console.WriteLine("{0}: The bit on position {1} is 0", result, p); 
        }
    }
}