using csharp_auto_tests.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Helpers
{
    class TransactionHelper : ITransaction
    {
        public void deposit(string account_id, string amount, string description)
        {
            throw new NotImplementedException();
        }

        public void withdraw(string account_id, string amount, string description)
        {
            throw new NotImplementedException();
        }
    }
}
