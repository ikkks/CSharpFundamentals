// 11.* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
// Examples:
// 0 > "Zero"
// 273 > "Two hundred seventy three"
// 400 > "Four hundred"
//	501 > "Five hundred and one"
//	711 > "Seven hundred and eleven"

using System;

class NumberToString
{
    static void Main()
    {
        Console.Write("Enter a number from 0 to 999:\nNumber = ");
        int number = int.Parse(Console.ReadLine());
 

        string[] single = new String[] { "Zero", "One", "Two", "Three", "Tour", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] tens = new String[] {"twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] other = new String[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        // if number is from 0 to 9
        if ((number >= 0) && (number <= 9))
        {
            switch (number) 
            {
                case 0: Console.WriteLine("{0} = {1}", number, single[0]); break;
                case 1: Console.WriteLine("{0} = {1}", number, single[1]); break;
                case 2: Console.WriteLine("{0} = {1}", number, single[2]); break;
                case 3: Console.WriteLine("{0} = {1}", number, single[3]); break;
                case 4: Console.WriteLine("{0} = {1}", number, single[4]); break;
                case 5: Console.WriteLine("{0} = {1}", number, single[5]); break;
                case 6: Console.WriteLine("{0} = {1}", number, single[6]); break;
                case 7: Console.WriteLine("{0} = {1}", number, single[7]); break;
                case 8: Console.WriteLine("{0} = {1}", number, single[8]); break;
                case 9: Console.WriteLine("{0} = {1}", number, single[9]); break;
            }
        }
        // if number is from 10 to 19
        else if ((number >= 10) && (number <= 19))
        {
            switch (number)
            {
                case 10: Console.WriteLine("{0} = {1}", number, other[0]); break;
                case 11: Console.WriteLine("{0} = {1}", number, other[1]); break;
                case 12: Console.WriteLine("{0} = {1}", number, other[2]); break;
                case 13: Console.WriteLine("{0} = {1}", number, other[3]); break;
                case 14: Console.WriteLine("{0} = {1}", number, other[4]); break;
                case 15: Console.WriteLine("{0} = {1}", number, other[5]); break;
                case 16: Console.WriteLine("{0} = {1}", number, other[6]); break;
                case 17: Console.WriteLine("{0} = {1}", number, other[7]); break;
                case 18: Console.WriteLine("{0} = {1}", number, other[8]); break;
                case 19: Console.WriteLine("{0} = {1}", number, other[9]); break;
            }
        }

        // if number is 20, 30, 40, 50, 60, 70 ,80 or 90
        else if ((number >= 20) && (number <= 99))
        {
            switch (number)
            {
                case 20: Console.WriteLine("{0} = {1}", number, tens[0]); break;
                case 30: Console.WriteLine("{0} = {1}", number, tens[1]); break;
                case 40: Console.WriteLine("{0} = {1}", number, tens[2]); break;
                case 50: Console.WriteLine("{0} = {1}", number, tens[3]); break;
                case 60: Console.WriteLine("{0} = {1}", number, tens[4]); break;
                case 70: Console.WriteLine("{0} = {1}", number, tens[5]); break;
                case 80: Console.WriteLine("{0} = {1}", number, tens[6]); break;
                case 90: Console.WriteLine("{0} = {1}", number, tens[7]); break;
            }
        }

        // if number is from 100 - 999
        else if ((number >= 100) && (number <= 999))
        {
        }


    }
}
