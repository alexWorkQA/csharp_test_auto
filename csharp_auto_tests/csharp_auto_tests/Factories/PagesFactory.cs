using csharp_auto_tests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace csharp_auto_tests.Factories
{
    class PagesFactory
    {
        static LoginPage loginPage;
        static MainPage mainPage;

        public static void initialization()
        {
            IWebDriver driver = WebDriverFactory.getWebDriver("chrome");
            PageFactory.InitElements(driver, loginPage);
            PageFactory.InitElements(driver, mainPage);
        }

    }
}
