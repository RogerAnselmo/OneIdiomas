using OpenQA.Selenium;

namespace One.Test.Acceptance.Pages
{
    class ListaAlunoPage : LoggenInBasePage
    {
        public override string Url => "http://localhost:4927/Gerenciar-Aluno/Lista-Aluno";

        public void NovoAlunoClick() => driver.FindElement(By.Id("btNovoAluno")).Click();

        public void EditarAlunoClick() 
            => driver.FindElement(By.XPath("//table[@id='tableAlunos']//a[@class='btn btn-editar btn-primary']")).Click();
    }
}
