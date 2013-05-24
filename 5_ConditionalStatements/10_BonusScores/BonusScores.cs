// 10. Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. 
// If the digit is between 1 and 3, the program multiplies it by 10; 
// if it is between 4 and 6, multiplies it by 100; 
// if it is between 7 and 9, multiplies it by 1000. 
// If it is zero or if the value is not a digit, the program must report an error.
// Use a switch statement and at the end print the calculated new value in the console.

using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Enter score from 1 to 9:\nScore = ");
        byte score = byte.Parse(Console.ReadLine());
        Console.Write("Bonus score = ");
        int bonus = (int)score;

        // options according the score chosen
        switch (score) 
        {
            case 1:
            case 2:
            case 3:
                score *= 10;
                Console.WriteLine(score); break ;
            case 4:
            case 5:
            case 6:
                bonus *= 100; 
                Console.WriteLine(bonus); break;
            case 7:
            case 8:
            case 9:
                bonus *= 1000; 
                Console.WriteLine(bonus); break ;

            // if the score entered is not valid
            default:
                Console.WriteLine("Error! The number enterd is 0 or bigger than 9"); break ;
        }
    }
}