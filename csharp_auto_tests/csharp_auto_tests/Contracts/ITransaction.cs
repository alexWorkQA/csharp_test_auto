using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Contracts
{
    interface ITransaction
    {
        void deposit(string account_id, string amount, string description);
        void withdraw(string account_id, string amount, string description);
    }
}
