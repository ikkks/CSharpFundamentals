// 7. Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumCalculation
{
    static void Main()
    {
        Console.Write("Write total numbers for summing:\nn = ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        // enter the number to sum 
        Console.Write("Input the first number for summing:\nnumber = ");
        int number = int.Parse(Console.ReadLine());

        // calculate the sum for n times 
        for (int i = 0 ; i < n ; i++) 
        {
            sum = sum + number;
        }

        // print the final sum
        Console.WriteLine("The sum  for {0} times summing {1} is {2}", n, number, sum);
    }
}