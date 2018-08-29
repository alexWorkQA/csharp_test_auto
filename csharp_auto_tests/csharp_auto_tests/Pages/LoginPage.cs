using csharp_auto_tests.Contracts;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using csharp_auto_tests.Models;

namespace csharp_auto_tests.Pages
{
    class LoginPage:BasePage,IPage
    {
        [FindsBy(How = How.XPath,Using = ".//input[@name='uid']")]
        public IWebElement loginField;

        [FindsBy(How = How.XPath, Using = ".//input[@name='password']")]
        public IWebElement passwordField;

        [FindsBy(How = How.XPath, Using = ".//input[@value='LOGIN']")]
        public IWebElement loginButton;


        public IPage loginToSite(User user)
        {
            loginField.SendKeys(user.UserId);
            passwordField.SendKeys(user.UserPassword);
            loginButton.Click();
            return new ManagerPage();
        }

    }
}
