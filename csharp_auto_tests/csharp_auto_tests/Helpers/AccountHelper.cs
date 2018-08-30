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

        public void openAccountDetails(Account account)
        {
            string accountId = account.Account_Id;
            PagesFactory.balancePage.submitAccountNo(accountId);
        }
        
        public string getCurrentBalance()
        {
            return PagesFactory.balancePage.getBalanceAmount();            
        }

        public string getAccountType()
        {         
            return PagesFactory.balancePage.getAccountType();
        }
    }
}
