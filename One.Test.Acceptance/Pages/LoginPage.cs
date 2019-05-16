using OpenQA.Selenium;

namespace One.Test.Acceptance.Pages
{
    public class LoginPage : BasePage
    {
        public override string Url => "localhost:4927";
        public string Login
        {
            get => driver.FindElement(By.Name("Login")).GetAttribute("value");
            set => SetText(By.Name("Login"), value);
        }
        public string Password
        {
            get => driver.FindElement(By.Name("Senha")).GetAttribute("value");
            set => SetText(By.Name("Senha"), value);
        }

        public string PasswordText
        {
            get => driver.FindElement(By.Name("Senha")).Text;
        }

        public void ClickLoginButton() 
            => driver.FindElement(By.CssSelector(".btnEntrar")).Click();
    }
}
