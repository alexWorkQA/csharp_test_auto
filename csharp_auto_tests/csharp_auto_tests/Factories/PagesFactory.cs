using csharp_auto_tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace csharp_auto_tests.Factories
{
    class PagesFactory
    {

        static IWebDriver driver;
        static WebDriverWait wait; 

        public static LoginPage loginPage = new LoginPage();
        public static ManagerPage mainPage = new ManagerPage();
        public static BalanceEnquiryPage balancePage = new BalanceEnquiryPage();

        public static void initialization()
        {
            driver = WebDriverFactory.getWebDriver("chrome");
              
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            wait = new WebDriverWait(driver, new TimeSpan(2));

            PageFactory.InitElements(driver, loginPage);
            PageFactory.InitElements(driver, mainPage);
            PageFactory.InitElements(driver, balancePage);
        }

        public static void closeWebClient()
        {
            driver.Quit();
            //driver.Close();
        }

    }
}
