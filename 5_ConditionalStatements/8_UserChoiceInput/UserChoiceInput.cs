// 8. Write a program that, depending on the user's choice inputs int, double or string variable. 
// If the variable is integer or double, increases it with 1. 
// If the variable is string, appends "*" at its end. 
// The program must show the value of that variable as a console output. Use switch statement.


using System;

class UserChoiceInput
{
    static void Main()
    {
        int intVariable;
        double doubleVariable;
        string stringVariable;

        Console.Write("Make your choice 1 = int, 2 = double or 3 = string variable\nYour choice : ");
        byte choice = byte.Parse(Console.ReadLine());
        Console.Write("\nYou chose ");

        switch (choice)
        {
            case 1: // int chosen
                Console.Write("an int value. Please enter one: ");
                intVariable = int.Parse(Console.ReadLine());
                Console.WriteLine("Your choice + 1: {0}\n",intVariable+1); break ;
            case 2: // double chosen
                Console.Write("a double value. Please enter one: ");
                doubleVariable = double.Parse(Console.ReadLine());
                Console.WriteLine("Your choice + 1: {0}\n", doubleVariable + 1); break ;
            case 3: // string chosen
                Console.Write("an string value. Please enter one: ");
                stringVariable = Console.ReadLine();
                Console.WriteLine("Your choice with \"*\" in the end: {0}\n", stringVariable + "*" ); break ;
            // none of the above chosen
            default:
                Console.WriteLine("Not what I expected...You should enter a digit from 1 to 3\n"); break;
        }
    }
}