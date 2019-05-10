using FluentAssertions;
using NUnit.Framework;
using One.Test.Acceptance.Enum;
using One.Test.Acceptance.Pages;
using System;

namespace One.Test.Acceptance.Specs
{
    public class CadastroProfessorTest : LoggedInSetup
    {
        public CadastroProfessorPage cadastroProfessorPage { get; set; }

        [SetUp]
        public void SetUp()
        {
            cadastroProfessorPage = new CadastroProfessorPage();
            cadastroProfessorPage.ClickMenu(Menu.Acadêmico);
            cadastroProfessorPage.ClickMenu(Menu.Professores);
            cadastroProfessorPage.NovoProfessorClick();
        }

        [Test]
        public void DeveCadastrarUmAluno()
        {
            cadastroProfessorPage.NomeProfessor = "nome do professor";
            cadastroProfessorPage.DataNascimento = new DateTime(1989, 9, 4);
            cadastroProfessorPage.RG = "4998314";
            cadastroProfessorPage.CPF = "8358357272";

            cadastroProfessorPage.BotaoSalvarClick().Should().Be(AlertFeedback.Success);
        }
    }
}
