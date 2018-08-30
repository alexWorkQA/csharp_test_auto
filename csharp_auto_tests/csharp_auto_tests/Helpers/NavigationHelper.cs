using csharp_auto_tests.Factories;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Helpers
{
    public class NavigationHelper
    {
        IWebDriver driver; 
        public NavigationHelper()
        {
            driver = WebDriverFactory.getWebDriver("chrome");
        }


        public void openMainPage()
        {
            driver.Url = "http://demo.guru99.com/v4/";
        }

        public void openBalanceEnquiryViaURL()
        {
            driver.Url = "http://demo.guru99.com/v4/manager/BalEnqInput.php";
        }

        public void openDepositPageViaUrl()
        {
            driver.Url = "http://demo.guru99.com/v4/manager/DepositInput.php";
        }

    }
}
