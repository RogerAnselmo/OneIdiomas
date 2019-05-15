using OpenQA.Selenium;

namespace One.Test.Acceptance.Pages
{
    public class ListaTurmasPage: LoggenInBasePage
    {
        public override string Url => "http://localhost:4927/Gerenciar-Turma/Lista-Turma";

        public void BotaoPerquisarClick() => driver.FindElement(By.Id("btPesquisar")).Click();
        public void BotaoNovaTurmaClick() => driver.FindElement(By.Id("btNovaTurma")).Click();
    }
 }
