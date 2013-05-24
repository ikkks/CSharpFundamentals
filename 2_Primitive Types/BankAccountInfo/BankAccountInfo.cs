//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

namespace BankAccountInfo
{
    class BankAccountInfo
    {
        static void Main()
        {
            string firstName, middleName, lastName, names, bankName, iban, bic, currency ;
	        ulong creditCard, creditCard2, creditCard3 ;
            decimal balance;

	        firstName = "Dragomir" ;
	        middleName = "Petrov" ;
	        lastName = "Mladenov" ; 
	        names = firstName + " " + middleName + " " + lastName ;

	        bankName = "UnicreditBulbank" ;
	        iban = "BG38 UNCR 9660 1051 8766 81" ;
	        bic = "UNCRBGSF" ;
	        balance = 1930.50m ;
	        currency = "lv" ;
	        creditCard = 1253739009287628 ;
	        creditCard2 = 1253739009284628 ;
	        creditCard3 = 1253739009287958 ;

	        Console.WriteLine("Bank Account of:\n\n{0}\nBank: {1}\nIBAN: {2}\nBIC: {3}\nBalance: {4}{5}\nCredit Cards:\n{6}\n{7}\n{8}", names,bankName, iban, bic, balance, currency, creditCard, creditCard2, creditCard3 );
        }
    }
}
