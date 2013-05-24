// 5. Write program that asks for a digit and depending on the input shows the name of that digit (in English)
// using a switch statement.

using System;

class PrintDigitName
{
    static void Main()
    {
        Console.Write("Enter a digit:\ndigit = ");
        byte digit = byte.Parse(Console.ReadLine());

        switch (digit)
        {
            // check number from 0 to 9
            case 0: Console.WriteLine("{0} = zero", digit); break;
            case 1: Console.WriteLine("{0} = one", digit); break;
            case 2: Console.WriteLine("{0} = two", digit); break;
            case 3: Console.WriteLine("{0} = three", digit); break;
            case 4: Console.WriteLine("{0} = four", digit); break;
            case 5: Console.WriteLine("{0} = five", digit); break;
            case 6: Console.WriteLine("{0} = six", digit); break;
            case 7: Console.WriteLine("{0} = seven", digit); break;
            case 8: Console.WriteLine("{0} = eight", digit); break;
            case 9: Console.WriteLine("{0} = nine", digit); break;

            //default value if the number is bigger than  9
            default: 
                Console.WriteLine("The Number {0} is not in range!", digit); break;
        }
    }
}
