using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Labs7.Task1
{
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;

        //Принимает аргумент и заполнение данными
        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
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

        //Перевод денег с одного счета на другой
        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
            {
                this.Deposit(amount);
            }
        }
    }
}
