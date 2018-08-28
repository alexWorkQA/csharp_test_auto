using csharp_auto_tests.Factories;
using csharp_auto_tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_auto_tests.Helpers
{
    public class LoginHelper
    {
        public void loginToSite(User user)
        {
            PagesFactory.loginPage.loginToSite(user);
        }

    }
}
