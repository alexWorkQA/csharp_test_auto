using System;
using NUnit.Framework;
using csharp_auto_tests.Models;

namespace csharp_auto_tests.FunctionalTests
{
    [TestFixture]
    public class BasicTest
    {
        User testValidUser;

        [SetUp]
        public void setUpTests()
        {
            testValidUser = new User();
            testValidUser.UserId = "test";
            testValidUser.UserPassword = "test";
        }
    }
}
