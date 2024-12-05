using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.LSP.Bankaccount
{
    public class FixedTermDepositAccount : BankAccount
    {
        public override void Withdraw(double amount)
        {
            throw new InvalidOperationException("Cannot withdraw from a fixed term deposit account until term ends");
        }
    }
}
