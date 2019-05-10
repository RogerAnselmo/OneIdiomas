using OpenQA.Selenium;
using System;

namespace One.Test.Acceptance.Pages
{
    public class ListaProfessoresPage: LoggenInBasePage
    {
        public override string Url => "http://localhost:4927/Gerenciar-Professor/Lista-Professor";

        public string NomeProfessor
        {
            get => driver.FindElement(By.Id("NomeProfessor")).GetAttribute("value");
            set => SetText(By.Id("NomeProfessor"), value);
        }

        public void PesquisarResponsavelClick() 
            => driver.FindElement(By.Id("btPesquisar")).Click();

        public void NovoProfessorClick()
            => driver.FindElement(By.Id("btNovoProfessor")).Click();

    }
}
