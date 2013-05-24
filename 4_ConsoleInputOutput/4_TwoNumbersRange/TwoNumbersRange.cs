// 4. Write a program that reads two positive integer numbers and prints how many numbers p 
// exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class TwoNumbersRange
{
    static void Main()
    {
        Console.Write("Enter two numbers:\nFisrt: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Second: ");
        int num2 = int.Parse(Console.ReadLine());

        // check for range first < second number
        if (num1 < num2)
        {
            int countP = 0;
            for (int i = num1; i <= num2; i++)
            {
                if (i % 5 == 0)
                {
                    countP++;
                }
            }
            Console.WriteLine("In the range {0} - {1} there is {2} numbers that can devide by 5 with no remain.", num1, num2, countP);
        }

        // check for range first > second number
        else
        {
            int countP = 0;
            for (int i = num2; i <= num1; i++)
            {
                if (i % 5 == 0)
                {
                    countP++;
                }
            }
            Console.WriteLine("In the range {0} - {1} there is {2} numbers that can devide by 5 with no remain.", num2, num1, countP);
        }
    }
}