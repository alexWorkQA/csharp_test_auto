using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using csharp_auto_tests.Models;

namespace csharp_auto_tests.FunctionalTests
{
    class DepositTest: BasicTest
    {
        private Transaction transaction;

        [SetUp]
        public void testInitialization()
        {
            app.navigationHelper.openMainPage();
            app.loginHelper.loginToSite(testValidUser);

            transaction = new Transaction();
            transaction.AccountNo = "48596";
            transaction.AmountCredited = "1000";
            transaction.Description = "Test add 1000";
               
        }

        [Test]
        public void UserIsAbleToDepositMoney()
        {
            app.navigationHelper.openBalanceEnquiryViaURL();
            app.accountHelper.openAccountDetails(testAccount);
            string balance = app.accountHelper.getCurrentBalance();
            Assert.AreEqual(testAccount.CurrentAmount, balance);
            string accountType = app.accountHelper.getAccountType();
            Assert.AreEqual(testAccount.Account_type, accountType);
            app.navigationHelper.openDepositPageViaUrl();
            app.transactionHelper.deposit(transaction);
        }
    }
}
