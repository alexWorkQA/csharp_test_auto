using System;
using NUnit.Framework;
using csharp_auto_tests.Models;
using csharp_auto_tests.TestApplication;

namespace csharp_auto_tests.FunctionalTests
{
    [TestFixture]
    public class BasicTest
    {
        public User testValidUser;
        public  Application app;

        [SetUp]
        public void setUpTests()
        {
            testValidUser = new User();
            testValidUser.UserId = "mngr151028";
            testValidUser.UserPassword = "dyhybYq";

            app = new Application();

            app.start();
        }

        [TearDown]
        public void completeTest()
        {
            app.finish();
        }
    }
}
