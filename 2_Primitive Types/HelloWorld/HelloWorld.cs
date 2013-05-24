//Declare two string variables and assign them with “Hello” and “World”. 
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main()
        {
            string hello = "Hello" ;  
            string world = "World";
            object helloWorld = hello + " " + world ;//Declare the object
            string castObject = (string)helloWorld; //Typecasting the object and turns it into string
            Console.WriteLine("This prints the typecasted string variable: {0}", castObject) ;
            Console.WriteLine("This prints the rest of the variables: {0}, {1}, {2} ", hello, world, helloWorld) ;

        }
    }
}
