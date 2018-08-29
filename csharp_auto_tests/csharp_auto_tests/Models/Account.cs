using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Models
{
    public class Account
    {
        const string ACCOUNT_ID = "48596";
        const string CUSTOMER_ID = "94792";
        const string CUSTOMER_NAME = "AlexTest";
        const string EMAIL = "test@valid.com";
        const string ACCOUNT_TYPE = "Savings";
        const string DATE_OF_OPENING = "2018-08-28";
        const string CURRENT_AMOUNT = "4000";

        public string Account_Id {get;set;}
        public string Account_type { get; set; }
        public string DateOfOpening { get; set; }
        public string CurrentAmount { get; set; }

        public static Account getDafaultAccount()
        {
            Account account = new Account();
            account.Account_Id = ACCOUNT_ID;
            account.Account_type = ACCOUNT_TYPE;
            account.DateOfOpening = DATE_OF_OPENING;
            account.CurrentAmount = CURRENT_AMOUNT;
            return account;
        }
    }
}
