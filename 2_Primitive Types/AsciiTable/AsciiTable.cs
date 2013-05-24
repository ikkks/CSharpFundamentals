//Find online more information about ASCII (American Standard Code for Information Interchange)
//Write a program that prints the entire ASCII table of characters on the console.

using System;

namespace AsciiTable
{
    class AsciiTable
    {
        static void Main()
        {
            Console.WriteLine("This is the entire ASCII Table  of characters:\n");
           
            // Initialize a FOR loop in order to print all the ASCII symbols
            for (int asciiSymbol = 0; asciiSymbol < 256; asciiSymbol++)
            {
                Console.WriteLine("{0} = {1}", asciiSymbol, (char)asciiSymbol);
            }
        }
    }
}
