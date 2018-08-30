using csharp_auto_tests.Contracts;
using csharp_auto_tests.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Pages
{
    class DepositPage:BasePage,IPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@name='accountno']")]
        private IWebElement accountId;

        [FindsBy(How = How.XPath, Using = ".//input[@name='ammount']")]
        private IWebElement accountAmount;

        [FindsBy(How = How.XPath, Using = ".//input[@name='desc']")]
        private IWebElement descriptionField;

        [FindsBy(How = How.XPath, Using = ".//input[@value='Submit']")]
        private IWebElement submitButton;


        public DepositPage fillAmountDepositForm(Transaction transaction) 
        {
            accountId.SendKeys(transaction.AccountNo);
            accountAmount.SendKeys(transaction.AmountCredited);
            descriptionField.SendKeys(transaction.Description);
            submitButton.Click();
            return this;
        }
        
    }
}
