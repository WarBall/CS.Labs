﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Labs8.Task2
{
    class CreateAccount
    {
        static void Main()
        {
            BankAccount acc1;

            acc1 = new BankAccount();

            acc1.Deposit(100);
            acc1.Deposit(200);
            acc1.Withdraw(150);

            Write(acc1);
        }

        static void Write(BankAccount acc)
        {
            Console.WriteLine("Account number is {0}", acc.Number());
            Console.WriteLine("Account balance is {0}", acc.Balance());
            Console.WriteLine("Account type is {0}", acc.Type());
            
            Console.WriteLine("Ttransctions:");
            foreach (BankTransaction tran in acc.Transactions())
            {
                Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
            }
            Console.WriteLine();
        }
    }
}
