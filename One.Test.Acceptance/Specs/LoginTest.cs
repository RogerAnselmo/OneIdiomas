using One.Test.Acceptance.Pages;

namespace One.Test.Acceptance.Specs
{
    public class LoginTest: GlobalSetup
    {
        private LoginPage loginPage;

        [NUnit.Framework.SetUp]
        public void SetUp() 
            => loginPage = new LoginPage();

        [NUnit.Framework.Test]
        public void ShouldLoginInApplication()
        {
            loginPage.Navigate();

            loginPage.Login = "canselmo";
            loginPage.Password = "123456";

            loginPage.ClickLoginButton();
        }
    }
}
