//7.Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a positive number:");
        int n = int.Parse(Console.ReadLine());

        if ((n > 1) && (n <= 100))
        {
            if (n == 2 || n == 3 || n == 5 || n == 7)
            {
                Console.WriteLine("The number {0} is prime!", n);
            }
            else
            {
                if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0 || n % 7 == 0) //If the number devides to one of those with no remain it means that it is not prime
                {
                    Console.WriteLine("The number {0} is not prime!", n);
                }
                else
                {
                    Console.WriteLine("The number {0} is prime!", n);
                }
            }
        }
        else 
        {
            Console.WriteLine("The number {0} is not in the range 1-100", n);
        }
    }
}