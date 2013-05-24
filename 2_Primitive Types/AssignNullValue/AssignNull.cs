//Create a program that assigns null values to an integer and to double variables. 
//Try to print them on the console
//Try to add some values or the null literal to them and see the result.

using System;

namespace AssignNullValue
{
    class AssignNull
    {
        static void Main()
        {
            //Assign null values
	        int? a=null;
	        double? b=null;

	        //Print on the console
	        Console.WriteLine("Integer: {0}\nDouble: {1}", a, b);

	        //Add values
	        a += null;
	        b += 257;
	
	        //Print on the console after adding values
	        Console.WriteLine("Print variables after adding null or other values.\nNull added: {0}\nSomething else added:{1}", a, b);
        }
    }
}
