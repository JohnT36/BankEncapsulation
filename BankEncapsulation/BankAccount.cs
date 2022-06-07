using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 200;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double Withdraw(double amount)
        { return balance -= amount; }

        public double GetBalance()

        {
            return balance;

        }
        

    }






}
