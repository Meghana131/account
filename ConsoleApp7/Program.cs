 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment2
{
    public class Account
    {
        double accountNo;
        string customerName;
        string accountType;
        string transactiontype;
        double amount;
        double balance = 25000;
        public Account(double accountNo, string customerName, string accountType)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;

        }
        public void credit(double amount)
        {
            if (amount > 0)
            {
                this.balance = this.balance + amount;
                this.amount = amount;
                this.transactiontype = "credit";
                Console.WriteLine("Amount:{0} has been credited  to your account,available balance:{1}", amount, balance);
            }
            else
            {
                Console.WriteLine("please enter valid  amount");
            }
        }
        public void debit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("please enter valid amount:");
            }
            else if (amount > balance)
            {
                Console.WriteLine("insufficient fund,available balance:{0}", balance);
            }
            else
            {
                balance = balance - amount;
                this.amount = amount;
                this.transactiontype = "Debit";
                Console.WriteLine("amount:{0} has been debited from your account,available balance:{1}", amount, balance);
            }
        }
        public void displayBalance()
        {
            Console.WriteLine("current balance:{0}", balance);
        }
        public void displayDetails()
        {
            Console.WriteLine("accountdetails");
            Console.WriteLine("_____________");
            Console.WriteLine("customer name:{0}", customerName);
            Console.WriteLine("account no: {0}", accountNo);
            Console.WriteLine("account type:{0}", accountType);
            Console.WriteLine("available balance : {0}", balance);
            Console.WriteLine("last transaction type : {0}", transactiontype);
            Console.WriteLine("last transaction amount : {0}", amount);

        } 
    }
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter customer name :");
            string customerName = Console.ReadLine();
            Console.WriteLine("enter account no: ");
            double accountNo= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter account type :");
            string accounttype = Console.ReadLine();

            Account acc = new Account(accountNo, customerName, accounttype);
            double amount;

            int ch;
            do
            {
                Console.WriteLine("------------------");
                Console.WriteLine("select operation:\n1.view account balance.\n2.credit amount\n3.withdraw amount\n4.display all details\n5.Exit");
                Console.WriteLine("----------------------");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        acc.displayBalance();
                        break;
                    case 2:
                        Console.WriteLine("enter amount to credit :");
                        amount = Convert.ToDouble(Console.ReadLine());
                        acc.credit(amount);
                        break;
                    case 3:
                        Console.WriteLine("enter amount to debit");
                        amount = Convert.ToDouble(Console.ReadLine());
                        acc.debit(amount);
                        break;
                    case 4:
                        acc.displayDetails();
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;


                }
            }
            while (ch != 5);


        }
    }
}
