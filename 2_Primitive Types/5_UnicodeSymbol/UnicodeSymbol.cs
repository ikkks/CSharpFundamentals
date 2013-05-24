//Declare a character variable and assign it with the symbol that has Unicode code 72. 
//Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

namespace UnicodeSymbol
{
    class UnicodeSymbol
    {
        static void Main()
        {

            int UnicodeSymbol = 0x48;
            Console.WriteLine("The Unicode Symbol for 72 is: " + (char)UnicodeSymbol);
        }
    }
}
