//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//Use Windows Character Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly.

using System;
using System.Text;

namespace CopyrightTriangle
{
    class CopyrightTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            char copySymbol = '\u00A9'; 
	    
            //In order to see the copyright symbol you need to set your console font to Lucida Console
	        Console.WriteLine("   {0}\n  {1} {2}\n {3}   {4}\n{5} {6} {7} {8}",copySymbol, copySymbol, copySymbol,copySymbol,copySymbol,copySymbol,copySymbol,copySymbol,copySymbol);
        }
    }
}
