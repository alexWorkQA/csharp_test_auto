using System;
using NUnit.Framework;
using OpenQA.Selenium;
using csharp_auto_tests.Factories;

namespace csharp_auto_tests
{
    [TestFixture]
    public class SimpleDraftTest
    {
        private const string USER_ID = "mngr151028";
        private const string PASSWORD = "dyhybYq";
        private IWebDriver driver;

        [SetUp]
        public void init()
        {
            driver = WebDriverFactory.getWebDriver("chrome");
        }


        [Test]
        public void TestMethod1()
        {
            driver.Url = "http://demo.guru99.com/v4/";

        }
    }
}
