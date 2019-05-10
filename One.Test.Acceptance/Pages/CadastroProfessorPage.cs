using One.Test.Acceptance.Enum;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace One.Test.Acceptance.Pages
{
    public class CadastroProfessorPage : LoggenInBasePage
    {
        public override string Url => "http://localhost:4927/Gerenciar-Professor/Cadastro-Professor/";

        public string NomeProfessor
        {
            get => driver.FindElement(By.Id("NomeProfessor")).GetAttribute("value");
            set => SetText(By.Id("NomeProfessor"), value);
        }

        public DateTime DataNascimento
        {
            get => DateTime.ParseExact(driver.FindElement(By.Id("DataNascimento")).GetAttribute("value"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            set => SetText(By.Id("DataNascimento"), value.ToString("dd/MM/yyyy"));
        }

        public string RG
        {
            get => driver.FindElement(By.Id("RG")).GetAttribute("value");
            set => SetText(By.Id("RG"), value);
        }

        public string CPF
        {
            get => driver.FindElement(By.Id("CPF")).GetAttribute("value");
            set => SetText(By.Id("CPF"), value);
        }

        public void NovoProfessorClick() 
            => driver.FindElement(By.Id("btNovoProfessor")).Click();
    }
}
