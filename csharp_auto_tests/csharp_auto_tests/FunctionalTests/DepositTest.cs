using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace csharp_auto_tests.FunctionalTests
{
    class DepositTest: BasicTest
    {
        [SetUp]
        public void testInitialization()
        {
            app.navigationHelper.openMainPage();
            app.loginHelper.loginToSite(testValidUser);            
        }

        [Test]
        public void UserIsAbleToDepositMoney()
        {
            app.navigationHelper.openBalanceEnquiryViaURL();
            string balance = app.accountHelper.getCurrentBalance(testAccount);
            Assert.AreEqual(testAccount.CurrentAmount, balance);
        }
    }
}
