//A marketing firm wants to keep record of its employees. 
//Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
//Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

namespace EmployeeRecords
{
    class EmployeeRecord
    {
        static void Main()
        {
            //Declare the variables needed
            string firstName, familyName; 
            char employeeGender;
            byte employeeAge; 
            int idNumber; 
            ushort employeeNumber;

            //Assign sample values 
            firstName ="Stoyan";
            familyName ="Georgiev";
            employeeGender = 'm';
            employeeAge = 20;
            idNumber = 734530253;
            employeeNumber = 4512;

            Console.WriteLine("This is the employee file for:\n{0} {1}\nGender: {2}\nAge: {3}\nID Number: {4}\nUnique Employee Number: {5}", firstName, familyName, employeeGender,employeeAge,  idNumber, 27560000+ employeeNumber); //Print the employee record of Stoyan
        }
    }
}
