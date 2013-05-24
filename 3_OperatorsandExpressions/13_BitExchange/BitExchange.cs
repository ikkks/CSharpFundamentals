// 13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitExchange
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number to exchange bits of: ");
        uint number = uint.Parse(Console.ReadLine());
        uint firstBit, secondBit, changedNumber;

        // Inital bit positions
        byte bitPosition1 = 3;
        byte bitPosition2 = 24;

        uint helpElement = 1; // 0000 0001

        for (byte i = 1; i <= 3; i++, bitPosition1++, bitPosition2++)
        {
            // Exchange first bit position
            helpElement = helpElement << bitPosition1;
            firstBit = (helpElement & number) >> bitPosition1;
            helpElement = 1 ;

            // Exchange second bit position
            helpElement = helpElement << bitPosition2;
            secondBit = (helpElement & number) >> bitPosition2;
            helpElement = 1 ;

            if (firstBit != secondBit)
            {
                if (firstBit == 1)
                {
                    changedNumber = number | (helpElement << bitPosition1);  // Example: 001 | 010 => 011
                    number = changedNumber ^ (helpElement << bitPosition2);
                }
                else
                {
                    changedNumber = number ^ (helpElement << bitPosition1); // Example: 001 ^ 101 => 100
                    number = changedNumber | (helpElement << bitPosition2);
                }
            }
        }

        Console.WriteLine("The number after the exchange of bits 3, 4 and 5 with 24, 25 and 26 is:\n{0}" , number);

    }
}