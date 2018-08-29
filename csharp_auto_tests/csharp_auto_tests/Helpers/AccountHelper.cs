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
    public class AccountHelper:IAccountHelper
    {
        
        public string getCurrentBalance(Account account)
        {
            string accountId = account.Account_Id;
            PagesFactory.balancePage.submitAccountNo(accountId);
            return PagesFactory.balancePage.getBalanceAmount();            
        }
    }
}
