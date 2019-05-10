using One.Test.Acceptance.Enum;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace One.Test.Acceptance.Pages
{
    public abstract class LoggenInBasePage : BasePage
    {
        public void ClickMenu(Menu menu)
        {
            driver
                .FindElement(By.XPath(
                $"//nav[@id='menu']//span[text()='{menu.ToString()}'] | " +
                $"//nav[@id='menu']//ul//a[normalize-space(text())='{menu.ToString()}']"))
                .Click();

            VerificaLoading();
        }

        public void VerificaLoading()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(x => x.FindElements(By.Id("dvLoading"))?
                  .FirstOrDefault(y => y.Displayed) == null);
        }
    }
}
