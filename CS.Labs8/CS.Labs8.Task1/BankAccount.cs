using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Labs8.Task1
{
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo;

        public BankAccount()
        {
            accNo = NextNumber();
            accBal = 0;
            accType = AccountType.Checking;
        }

        public BankAccount(AccountType aType)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = 0;
        }

        public BankAccount(decimal aBal)
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = aBal;
        }

        public BankAccount(AccountType aType, decimal aBal)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = aBal;
        }
        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
        public string Type()
        {
            return accType.ToString();
        }
        private static long NextNumber()
        {
            return nextAccNo++;
        }
        //Прибовление к балансу счета
        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            return accBal;
        }
        //Проверка на возможность снятия средст со чета и их сняти в случае положительнй проверки
        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;

            if (sufficientFunds)
            {
                accBal -= amount;
            }
            return sufficientFunds;
        }

    }
}
