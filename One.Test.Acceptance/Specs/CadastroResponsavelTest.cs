using NUnit.Framework;
using One.Test.Acceptance.Enum;
using One.Test.Acceptance.Pages;
using System;

namespace One.Test.Acceptance.Specs
{
    public class CadastroResponsavelTest: LoggedInSetup
    {
        private CadastroResponsavelPage cadastroResponsavelPage = new CadastroResponsavelPage();

        [SetUp]
        public void SetUp()
        {
            cadastroResponsavelPage.ClickMenu(Menu.Acadêmico);
            cadastroResponsavelPage.ClickMenu(Menu.Responsáveis);
            cadastroResponsavelPage.NovoResponsavelClick();
        }

        [Test]
        public void DeveCadastrarUmResponsavel()
        {
            cadastroResponsavelPage.NomeCompleto = "Teste - " + DateTime.Now;
            cadastroResponsavelPage.DataNascimento = new DateTime(1980,1,1);
            cadastroResponsavelPage.CodigoBairro = 1;
            cadastroResponsavelPage.CPF = "123456798";
            cadastroResponsavelPage.Logradouro = "professor joão arruda";
            cadastroResponsavelPage.Numero = "234";
            cadastroResponsavelPage.RG = "4998314";
            cadastroResponsavelPage.CEP = "6605652";
            cadastroResponsavelPage.Telefone = "(91)9999999";

            cadastroResponsavelPage.BotaoSalvarClick();
        }
    }
}
