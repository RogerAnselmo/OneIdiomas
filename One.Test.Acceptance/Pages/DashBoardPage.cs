using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Test.Acceptance.Pages
{
    public class DashBoardPage : LoggenInBasePage
    {
        public override string Url => "http://localhost:4927/Painel-Controle/Informacao-Geral";

        public void MenuAcademicoClick() 
            => driver.FindElement(By.Id("MenuAcademico")).Click();

        public void SubMenuProfessorClick()
            => driver.FindElement(By.Id("SubMenuProfessor")).Click();
        

        public bool IsLoggedIn(string login) 
            => login.Equals(driver.FindElement(By.ClassName("name")).Text);
    }
}
