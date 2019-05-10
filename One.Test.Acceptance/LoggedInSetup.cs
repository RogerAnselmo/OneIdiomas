using NUnit.Framework;
using One.Test.Acceptance.Pages;

namespace One.Test.Acceptance
{
    public class LoggedInSetup : GlobalSetup
    {
        [SetUp]
        public void LoginSetUp()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();
            loginPage.Login = "cranselmo";
            loginPage.Password = "123456";
            loginPage.ClickLoginButton();
        }
    }
}
