using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_auto_tests.Models;

namespace csharp_auto_tests.Contracts
{
    interface IAccountHelper
    {
        void openAccountDetails(Account account);
        string getCurrentBalance();
    }
}
