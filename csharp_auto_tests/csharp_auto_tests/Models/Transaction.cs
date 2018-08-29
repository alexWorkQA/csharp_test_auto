using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Models
{
    class Transaction
    {
        public string TransactionID { get; set; }
        public string AccountNo { get; set; }
        public string AmountCredited { get; set; }
        public string TypeOfTransaction { get; set; }
        public string Description { get; set; }
        public string Balance { get; set; }
    }
}
