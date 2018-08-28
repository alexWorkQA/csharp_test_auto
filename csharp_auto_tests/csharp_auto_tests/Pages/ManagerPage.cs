using csharp_auto_tests.Contracts;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Pages
{
    class ManagerPage:BasePage,IPage
    {
        [FindsBy(How = How.XPath, Using = ".//td[contains(text(),'Manger Id')]")]
        private IWebElement managerId;


        public string getManagerId()
        {
            return managerId.Text;
        }

    }
}
