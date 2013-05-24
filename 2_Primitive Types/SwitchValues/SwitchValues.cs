//Declare two integer variables and assign them with 5 and 10 
//After that exchange their values.

using System;

namespace SwitchValues
{
    class SwitchValues
    {
        static void Main()
        {
            int firstNumber, secondNumber;  //Declare Variables
            firstNumber = 5; //Assign Values
            secondNumber = 10;

            //Print initial values
            Console.WriteLine("First number initial value: {0}\nSecond number initial value: {1}", firstNumber, secondNumber);
            
            //Switch values
            if (firstNumber == 5)
            {
                secondNumber = 5;
                firstNumber = 10;
            }

            //Print values after the switch
            Console.WriteLine("First number value after the switch: {0}\nSecond number value after the switch: {1}", firstNumber, secondNumber);

        }
    }
}