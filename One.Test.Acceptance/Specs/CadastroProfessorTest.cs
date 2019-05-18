using FluentAssertions;
using NUnit.Framework;
using One.Test.Acceptance.Enum;
using One.Test.Acceptance.Pages;
using System;

namespace One.Test.Acceptance.Specs
{
    public class CadastroProfessorTest : LoggedInSetup
    {
        private CadastroProfessorPage cadastroProfessorPage { get; set; }

        [SetUp]
        public void SetUp()
        {
            cadastroProfessorPage = new CadastroProfessorPage();
            cadastroProfessorPage.ClickMenu(Menu.Acadêmico);
            cadastroProfessorPage.ClickMenu(Menu.Professores);
            cadastroProfessorPage.NovoProfessorClick();
        }

        [Test]
        public void DeveCadastrarUmProfessor()
        {
            cadastroProfessorPage.NomeProfessor = faker.Person.FullName;
            cadastroProfessorPage.DataNascimento = faker.Date.Between(new DateTime(1900, 1, 1), new DateTime(2015, 1, 1));
            cadastroProfessorPage.RG = "4998314";
            cadastroProfessorPage.CPF = "8358357272";

            cadastroProfessorPage.BotaoSalvarClick().Should().Be(AlertFeedback.Success);
        }
    }
}
