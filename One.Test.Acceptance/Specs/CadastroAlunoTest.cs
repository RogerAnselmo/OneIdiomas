using NUnit.Framework;
using One.Test.Acceptance.Enum;
using One.Test.Acceptance.Pages;
using System;
using Bogus;

namespace One.Test.Acceptance.Specs
{
    public class CadastroAlunoTest: LoggedInSetup
    {
        private ListaAlunoPage listaAlunoPage;
        private CadastroAlunoPage cadastroAlunoPage;
        private Faker faker;

        [SetUp]
        public void SetUp()
        {
            cadastroAlunoPage = new CadastroAlunoPage();
            listaAlunoPage = new ListaAlunoPage();
            faker = new Faker();

            listaAlunoPage.ClickMenu(Menu.Acadêmico);
            listaAlunoPage.ClickMenu(Menu.Alunos);
        }

        [Test]
        public void DeveCadastrarUmAluno()
        {
            listaAlunoPage.NovoAlunoClick();

            ArrangeCadastroAlunoPage();

            cadastroAlunoPage.BotaoSalvarClick();
        }

        [Test]
        public void DeveEditarUmAluno()
        {
            listaAlunoPage.EditarAlunoClick();

            ArrangeCadastroAlunoPage();

            cadastroAlunoPage.BotaoSalvarClick();
        }

        private void ArrangeCadastroAlunoPage()
        {
            cadastroAlunoPage.NomeCompleto = faker.Person.FullName;
            cadastroAlunoPage.DataNascimento = faker.Date.Between(new DateTime(1900, 1, 1), new DateTime(2015, 1, 1));
            cadastroAlunoPage.Telefone = faker.Phone.PhoneNumber("(00)0000-0000");
            cadastroAlunoPage.RG = faker.Random.AlphaNumeric(7);
            cadastroAlunoPage.CPF = faker.Random.AlphaNumeric(11);
            cadastroAlunoPage.CEP = faker.Random.AlphaNumeric(8);
            cadastroAlunoPage.Logradouro = faker.Address.Locale;
            cadastroAlunoPage.Numero = faker.Random.AlphaNumeric(3);
            cadastroAlunoPage.CodigoBairro = 1;
        }
    }
}
