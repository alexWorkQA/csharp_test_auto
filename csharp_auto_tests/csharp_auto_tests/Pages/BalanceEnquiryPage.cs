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
    class BalanceEnquiryPage:BasePage,IPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@name='accountno']")]
        private IWebElement accountNoField;

        [FindsBy(How = How.XPath, Using = ".//input[@name='AccSubmit']")]
        private IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = ".//td[contains(text(),'Balance')]/following-sibling::td")]
        private IWebElement balanceAmount;
        
        public BalanceEnquiryPage submitAccountNo(string accountNo)
        {
            accountNoField.SendKeys(accountNo);
            submitButton.Click();
            return this;
        }
        
        public string getBalanceAmount()
        {
            return balanceAmount.Text;
        } 

    }
}
