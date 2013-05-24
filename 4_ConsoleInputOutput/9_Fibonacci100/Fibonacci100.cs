// 9. Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class Fibonacci100
{
    static void Main()
    {
        // initial values of number 1 and 2
        uint num1 = 0;
        uint num2 = 1;

        for (int i = 0; i < 50; i++)
        {
            Console.Write("{0}, ", num1); // num1 = 0
            Console.Write("{0}, ", num2); // num2 = 1
            num1 = num1 + num2; //  num1 = 0 + 1 = 1
            num2 = num1 + num2; // num2 = 1 + 1 = 2
        }
    }
}

   /*   Another variation of Exercice 9 
    
        for (int i = 0; i < 100 ; i++) 
        {
            Console.Write("{0}, ", num1);
            uint sum = num1 + num2;
            num1 = num2; 
            num2 = sum; 
         }
    */