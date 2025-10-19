using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.InteropServices.Marshalling;
//3 classses, Bank account, savings account, checking account. 
//Bank account must have deposite or withdraw methods/functions
//Savings account must have interest method, 
//Checking account Withdraw method needed
namespace Bank_Stuff
{
    class Bank_Account
    {
        public string Account_Number{get; set;}
        public double Balance{get; set;}

        public Bank_Account(string accountNo, double balance)
        {
            Account_Number = accountNo;
            Balance = balance;
        }

        public virtual void Deposite(double amount)
        {
            Balance += amount;
            Console.WriteLine($"You added deposited {amount}\n\nYour current balance is {Balance}");
        }

        public virtual void Withdraw(double amount)
        {
            if(Balance > amount)
            {
                Balance -= amount;
                Console.WriteLine($"You Withdrew {amount}\n\nRemaining balance is {Balance}");
                
            }
            else
            {
                Console.WriteLine("Impossible to Withdraw");
            }
        }
    }

    class Savings_Account : Bank_Account
    {
        public double InterestRate{get; set;}

        public Savings_Account(double interest, string accNo, double balance) : base(accNo, balance)
        {
            InterestRate = interest;
        }

        public void AddInterest()
        {
            Balance += Balance * InterestRate;
            Console.WriteLine($"Your current balance is {Balance} with the interest of {InterestRate}");
        }
    }

    class Checking_Account : Bank_Account
    {
        public Checking_Account(double balance, string accNum) : base(accNum, balance)
        {}

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Bank_Account house_rent = new Bank_Account("HR", 1000);
            Savings_Account heatlh = new Savings_Account(2.3, "HH", 1023);
            Checking_Account luxury = new Checking_Account(12436, "LUX");

            house_rent.Withdraw(20);

            heatlh.Deposite(100);
            heatlh.AddInterest();

            luxury.Withdraw(50);

        }
    }
}