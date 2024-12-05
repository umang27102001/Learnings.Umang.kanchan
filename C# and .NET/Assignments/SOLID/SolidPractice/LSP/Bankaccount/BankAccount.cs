using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.LSP.Bankaccount
{
    public abstract class BankAccount
    {
        protected double balance;
        public virtual void Deposit(double amount)
        {
            balance += amount;
        }
        public abstract void Withdraw(double amount);
        public double GetBalance()
        {
            return balance;
        }
    }
}
