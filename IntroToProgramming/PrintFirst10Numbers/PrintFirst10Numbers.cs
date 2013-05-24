using System;

class PrintFirst10Numbers
{
    static void Main()
    {
        int[] numArray = { 2, -3, 4, -5, 6, -7, 8, -9, 10, -11, 12, -13, 14 };

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(numArray[i]);
        }
    }
}

