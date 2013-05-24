// 9. We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
// Example: 3, -2, 1, 1, 8 ==> 1+1-2=0.


using System;

class SumSubset
{
    static void Main()
    {
        Console.Write("Enter 5 integer numbers:\nfirst = ");
        int firstNum = int.Parse(Console.ReadLine()) ;
        Console.Write("second = ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("third = ");
        int thirdNum = int.Parse(Console.ReadLine());
        Console.Write("forth = ");
        int forthNum = int.Parse(Console.ReadLine());
        Console.Write("fifth = ");
        int fifthNum = int.Parse(Console.ReadLine());

        // check first number
        if (firstNum + secondNum + thirdNum == 0) 
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, secondNum, thirdNum);
        }
        else if (firstNum + forthNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, forthNum, fifthNum);
        }
        else if (firstNum + secondNum + forthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, secondNum, forthNum);
        }
        else if (firstNum + secondNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, secondNum, fifthNum);
        }
        else if (firstNum + thirdNum + forthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, thirdNum, forthNum);
        }
        else if (firstNum + thirdNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNum, thirdNum, fifthNum);
        }

        //check second number
        if (secondNum + thirdNum + forthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNum, thirdNum, forthNum);
        }
        else if (secondNum + forthNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNum, forthNum, fifthNum);
        }

        else if (secondNum + thirdNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNum, thirdNum, fifthNum);
        }

        //check third number
        else if (thirdNum + forthNum + fifthNum == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", thirdNum, forthNum, fifthNum);
        }
    }
}