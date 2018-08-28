using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace csharp_auto_tests.Factories
{
    class WebDriverFactory
    {
        public static IWebDriver driver;

        public static IWebDriver getWebDriver(string typeofDriver)
        {
            if (driver != null) return driver; else
            {
                driver = new ChromeDriver();
                return driver;
            }
        }
    }
}
