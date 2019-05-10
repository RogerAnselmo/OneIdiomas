using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Globalization;

namespace One.Test.Acceptance.Pages
{
    public class CadastroAlunoPage : LoggenInBasePage
    {
        public override string Url => "http://localhost:4927/Gerenciar-Aluno/Cadastro-Aluno/";

        public string NomeCompleto
        {
            get => driver.FindElement(By.Id("NomeCompleto")).GetAttribute("value");
            set => SetText(By.Id("NomeCompleto"), value);
        }

        public DateTime DataNascimento
        {
            get => DateTime.ParseExact(driver.FindElement(By.Id("DataNascimento")).GetAttribute("value"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            set => SetText(By.Id("DataNascimento"), value.ToString("dd/MM/yyyy"));
        }

        public string Telefone
        {
            get => driver.FindElement(By.Id("Telefone")).GetAttribute("value");
            set => SetText(By.Id("Telefone"), value);
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

        public string CEP
        {
            get => driver.FindElement(By.Id("CEP")).GetAttribute("value");
            set => SetText(By.Id("CEP"), value);
        }

        public string Logradouro
        {
            get => driver.FindElement(By.Id("Logradouro")).GetAttribute("value");
            set => SetText(By.Id("Logradouro"), value);
        }

        public string Numero
        {
            get => driver.FindElement(By.Id("Numero")).GetAttribute("value");
            set => SetText(By.Id("Numero"), value);
        }

        public int CodigoBairro
        {
            get => Convert.ToInt32(driver.FindElement(By.Id("CodigoBairro")).GetAttribute("value"));
            set => new SelectElement(driver.FindElement(By.Id("CodigoBairro"))).SelectByValue(value.ToString());
        }
    }
}
