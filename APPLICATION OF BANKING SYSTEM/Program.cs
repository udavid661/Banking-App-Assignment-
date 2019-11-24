using System;
using System.Reflection.Metadata.Ecma335;

namespace Banking_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname;
            string lname;
            string gender;
            string accountType;
            string currency;
            int transaction;
            Customer cust1 = new Customer();
            Console.WriteLine("Enter Customer First Name");
            fname = Console.ReadLine();
            Console.WriteLine("Enter Customer Second Name");
            lname = Console.ReadLine();
            Console.WriteLine("Enter Customer's gender");
            gender = Console.ReadLine();
            cust1.SetFirstName(fname);
            cust1.SetLastName(lname);
            cust1.SetGender(gender);
           Console.WriteLine("Enter Account Type Either Fixed or Current");
           accountType = Console.ReadLine();
           Console.WriteLine("Enter Currencies You Want To Use Either rwf,usd,euro");
           currency = Console.ReadLine();
           BankAccount account =new BankAccount(accountType,currency);
           Console.WriteLine($"Your Account Number is {account.AccountNumber} ");
           Console.WriteLine("choose 1 for making deposit to your account or 2 to withdraw on your account");
           transaction = Convert.ToInt32(Console.ReadLine());
           switch (transaction)
           {
               case 1:
                   int depositAmount;
                   Console.WriteLine("Enter amount to deposit to your account ");
                   depositAmount = Convert.ToInt32(Console.ReadLine());
                   account.MakeDeposit(depositAmount);
                   break;
               case 2:
                   int withdrawAmount;
                   Console.WriteLine("Enter amount to withdraw on your account ");
                   withdrawAmount = Convert.ToInt32(Console.ReadLine());
                   account.MakeWithdraw(withdrawAmount);
                   break;
               default:
                   Console.WriteLine("Choose the Right Transaction");
                   break;
           }
           

        }
    }
}
