using csharp_auto_tests.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Helpers
{
    public class NavigationHelper
    {
        public void openMainPage()
        {
            WebDriverFactory.getWebDriver("chrome").Url = "http://demo.guru99.com/v4/";
        }

    }
}
