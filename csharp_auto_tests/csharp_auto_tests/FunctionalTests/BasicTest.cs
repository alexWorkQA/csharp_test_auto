using System;
using NUnit.Framework;
using csharp_auto_tests.Models;
using csharp_auto_tests.TestApplication;

namespace csharp_auto_tests.FunctionalTests
{
    [TestFixture]
    public class BasicTest
    {
        User testValidUser;
        public  Application app;

        [SetUp]
        public void setUpTests()
        {
            testValidUser = new User();
            testValidUser.UserId = "test";
            testValidUser.UserPassword = "test";

            app = new Application();

            app.start();
        }
    }
}
