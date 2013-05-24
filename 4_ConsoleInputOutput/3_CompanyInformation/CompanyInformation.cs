// 3. A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. 
// Write a program that reads the information about a company and its manager and prints them on the console.


using System;

class CompanyInformation
{
    static void Main()
    {
        string company, address, website, manager, firstName, lastName;
        byte age;
        uint companyPhone, managerPhone, fax;

        // Declare sample company information
        company = "Cool Company Ltd";
        address = "bul. Carigradsko Shosee 110 G";
        website = "www.cool.com";
        firstName = "Stoyan";
        lastName = "Georgiev";
        manager = firstName + " " + lastName;
        age = 45;
        fax = 24423615 ;
        companyPhone = 24423618 ;
        managerPhone = 878456874 ;

        // Print company information on the console
        Console.WriteLine("Company Information for:\n\n{0}\nAdress: {1}\nWebsite: {2}\nPhone number: {3:(0#) ### ## ##}\nFax: {4:(0#) ### ## ##}\n\nCompany Manager: {5}\nAge: {6}\nPhone: {7:0### ### ###}\n\n", company, address, website, companyPhone, fax, manager, age, managerPhone);
             
    }
}