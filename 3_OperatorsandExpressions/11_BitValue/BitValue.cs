// 11. Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 > value=1.

using System;

class BitValue
{
    static void Main()
    {
        Console.Write("Number: "); 
        int i = int.Parse(Console.ReadLine()); // number
        Console.Write("Bit position: ");
        int b = int.Parse(Console.ReadLine()); // bit position

        int helpElement = 1; // 1 = 0000 0001
        helpElement = helpElement << b;

        int compareBits = helpElement & i;

        if (compareBits != 0)
        {
            Console.WriteLine("value = 1");
        }
        else
        {
            Console.WriteLine("value = 0");
        }
    }
}