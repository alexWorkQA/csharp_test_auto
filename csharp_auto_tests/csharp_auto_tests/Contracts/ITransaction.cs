using csharp_auto_tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Contracts
{
    interface ITransaction
    {
        void deposit(Transaction transaction);
        void withdraw(Transaction transaction);
    }
}
