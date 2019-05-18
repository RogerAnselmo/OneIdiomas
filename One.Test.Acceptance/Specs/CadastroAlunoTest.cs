using NUnit.Framework;
using One.Test.Acceptance.Enum;
using One.Test.Acceptance.Pages;
using System;

namespace One.Test.Acceptance.Specs
{
    public class CadastroAlunoTest: LoggedInSetup
    {
        private ListaAlunoPage listaAlunoPage;
        private CadastroAlunoPage cadastroAlunoPage;

        [SetUp]
        public void SetUp()
        {
            cadastroAlunoPage = new CadastroAlunoPage();
            listaAlunoPage = new ListaAlunoPage();

            listaAlunoPage.ClickMenu(Menu.Acadêmico);
            listaAlunoPage.ClickMenu(Menu.Alunos);
        }

        [Test]
        public void DeveCadastrarUmAluno()
        {
            listaAlunoPage.NovoAlunoClick();

            cadastroAlunoPage.NomeCompleto = faker.Person.FullName;
            cadastroAlunoPage.DataNascimento = faker.Date.Between(new DateTime(1900, 1, 1), new DateTime(2015, 1, 1));
            cadastroAlunoPage.Telefone = faker.Phone.PhoneNumber("(00)0000-0000");
            cadastroAlunoPage.RG = "4998314";
            cadastroAlunoPage.CPF = "123456798";
            cadastroAlunoPage.CEP = "6605652";
            cadastroAlunoPage.Logradouro = "professor joão arruda";
            cadastroAlunoPage.Numero = "234";
            cadastroAlunoPage.CodigoBairro = 1;

            cadastroAlunoPage.BotaoSalvarClick();
        }

        [Test]
        public void DeveEditarUmAluno()
        {
            listaAlunoPage.EditarAlunoClick();

            cadastroAlunoPage.NomeCompleto = "Teste Editado - " + DateTime.Now;
            cadastroAlunoPage.DataNascimento = new DateTime(1989, 1, 1);
            cadastroAlunoPage.Telefone = "(91)111111";
            cadastroAlunoPage.RG = "963696";
            cadastroAlunoPage.CPF = "88888";
            cadastroAlunoPage.CEP = "2222222";
            cadastroAlunoPage.Logradouro = "professor joão arruda editado";
            cadastroAlunoPage.Numero = "60";
            cadastroAlunoPage.CodigoBairro = 10;

            cadastroAlunoPage.BotaoSalvarClick();
        }
    }
}
