using csharp_auto_tests.Contracts;
using csharp_auto_tests.Factories;
using csharp_auto_tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Helpers
{
    public class TransactionHelper : ITransaction
    {
        public void deposit(Transaction transaction)
        {
            PagesFactory.depositPage.fillAmountDepositForm(transaction);
        }

        public void withdraw(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
