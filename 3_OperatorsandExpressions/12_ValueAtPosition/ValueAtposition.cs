/* We are given integer number n, value v (v= 0 or 1) and a position p. 
 * Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.	
 * Example: n = 5 (00000101), p=3, v=1 > 13 (00001101)
 * n = 5 (00000101), p=2, v=0 > 1 (00000001)
 */

using System;

class ValueAtposition
{
    static void Main()
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());
        Console.Write("Value to change (0 or 1): ");
        byte v = byte.Parse(Console.ReadLine());

        int helpElement = 1; // 0000 0001
        helpElement = helpElement << bitPosition;

        if (v == 0)
        {
            int changedNumber = ~(helpElement) & number; // Example: helpElement = 1 becomes 1111 1110
            Console.WriteLine("The result is {0}. Int {1}", Convert.ToString(changedNumber, 2), changedNumber);
        }
        else
        {
            int changedNumber = helpElement | number; // Example: x = 001 , y = 100 => result = 101
            Console.WriteLine("The result is {0}. Int {1}", Convert.ToString(changedNumber, 2), changedNumber);
        }
    }
}