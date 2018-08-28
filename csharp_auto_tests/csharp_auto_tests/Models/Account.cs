using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Models
{
    class Account
    {
        const string ACCOUNT_ID = "48596";
        const string CUSTOMER_ID = "94792";
        const string CUSTOMER_NAME = "AlexTest";
        const string EMAIL = "test@valid.com";
        const string ACCOUNT_TYPE = "Savings";
        const string DATE_OF_OPENING = "2018-08-28";
        const string CURRENT_AMOUNT = "2000";

        public string Account_Id {get;set;}
        public string Account_type { get; set; }
        public string DateOfOpening { get; set; }
        public string CurrentAmount { get; set; }
    }
}
