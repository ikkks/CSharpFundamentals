//5. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class ThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int helpElement = 1; // 1 is equal to 0000 0001
        helpElement = helpElement << 3; //the third bit of the help element now is equal to 1


        int compareBits = number & helpElement; //compare bits

        if (compareBits != 0)
        {
            Console.WriteLine("The third bit is 1");
        }
        else
        {
            Console.WriteLine("The third bit is 0") ; 
        }
    }
}
