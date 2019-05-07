using OpenQA.Selenium;

namespace One.Test.Acceptance.Pages
{
    public abstract class BasePage
    {
        public abstract string Url { get; }
        public IWebDriver driver { get => GlobalSetup.driver; }

        public void Navigate() => driver.Navigate().GoToUrl(Url);

        public void SetText(By by, object value)
        {
            driver.FindElement(by).Clear();
            driver.FindElement(by).SendKeys(value.ToString());
        }
    }
}
