// Declare two string variables and assign them with following value: 
// The "use" of quotations causes difficulties
// Do the above in two different ways: with and without using quoted strings.

using System;

namespace Quotations
{
    class QuotationsProgram
    {
        static void Main()
        {
            string quotedString = "The \"use\" of quotations causes difficulties" ; 
            string notQuoted = @"The ""use"" of quotations causes difficulties" ; 
            Console.WriteLine("Quoted string:\n{0}\n\nDone using @:\n{1}", quotedString, notQuoted) ; //Print the two strings

        }
    }
}
