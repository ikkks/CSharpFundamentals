using System;

class MyAge
{
    static void Main()
    {
        Console.Write("Your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age in 10 years will be: {0}", age + 10);
    }
}