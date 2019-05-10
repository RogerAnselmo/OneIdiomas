using FluentAssertions;
using One.Test.Acceptance.Pages;

namespace One.Test.Acceptance.Specs
{
    public class LoginTest : GlobalSetup
    {
        private LoginPage loginPage;
        private DashBoardPage dashBoardPage;

        [NUnit.Framework.SetUp]
        public void SetUp()
        {
            loginPage = new LoginPage();
            dashBoardPage = new DashBoardPage();
        }

        [NUnit.Framework.Test]
        public void ShouldLoginInApplication()
        {
            const string login = "cranselmo";
            const string password = "123456";

            loginPage.Navigate();

            loginPage.Login = login;
            loginPage.Password = password;

            loginPage.ClickLoginButton();

            dashBoardPage.IsLoggedIn(login).Should().BeTrue();
        }
    }
}
