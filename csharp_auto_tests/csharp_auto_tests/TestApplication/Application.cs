using csharp_auto_tests.Contracts;
using csharp_auto_tests.Factories;
using csharp_auto_tests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.TestApplication
{
    public class Application:IApplication
    {
        public NavigationHelper navigationHelper = new NavigationHelper();
        public LoginHelper loginHelper = new LoginHelper();
        public TransactionHelper transactionHelper = new TransactionHelper();
        public AccountHelper accountHelper = new AccountHelper();

        public void start()
        {
            PagesFactory.initialization();
            
        }

        public void finish()
        {
            PagesFactory.closeWebClient();
        }
    }
}
