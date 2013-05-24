// 10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumCalcAccuracy
{
    static void Main()
    {
        decimal sum = 1;
        decimal devideBy = 2;
        int plusMinus = 1;

        while (devideBy <= 1000)
        {
            sum = sum + (1 / (plusMinus * devideBy));
            devideBy = devideBy + 1;
            plusMinus = plusMinus * (-1); // switch sign
        }

        Console.WriteLine("{0:0.000}", sum); // print result
    }
}
