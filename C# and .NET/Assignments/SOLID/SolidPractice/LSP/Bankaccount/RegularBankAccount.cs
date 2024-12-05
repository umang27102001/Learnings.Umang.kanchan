using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.LSP.Bankaccount
{
    public class RegularDepositAccount : BankAccount
    {
        public override void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds");
            }
        }
    }
}
