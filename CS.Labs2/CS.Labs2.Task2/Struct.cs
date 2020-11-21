using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Labs2.Task2
{
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    class Struct
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accNo = 0;
            goldAccount.accType = AccountType.Cheking;
            goldAccount.accBal = (decimal)3200.00;

            try
            {
                Console.Write("Enter Account number:");
                goldAccount.accNo = long.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("*Account Summary*");
            Console.WriteLine("Account number: {0}", goldAccount.accNo);
            Console.WriteLine("Account Type: {0}", goldAccount.accType);
            Console.WriteLine("Account Balabc: {0}", goldAccount.accBal);

            Console.ReadLine();
        }
    }
}
