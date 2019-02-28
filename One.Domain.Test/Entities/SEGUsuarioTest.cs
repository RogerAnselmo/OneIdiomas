using NUnit.Framework;
using One.Domain.Entities;
using One.Domain.Specifications.SEGUsuarioSpecification;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Test.Entities
{
    [TestFixture]
    public class SEGUsuarioTest
    {
        SEGUsuario usuario = new SEGUsuario();

        [SetUp]
        public void SetUp()
        {
            usuario = new SEGUsuario {
                NomeCompleto = "Carlos Rogério Campos Anselmo",
                Login = "carlos.anselmo",
                CodigoUsuario = 0,
                flAtivo = "A"
            };
        }

        #region Teste com o Nome
        [Test]
        public void DeveTerUmNomeValido()
        {
            //Arrange -> //Act
            var test = new NomeDeveSerValido().IsSatisfiedBy(usuario);

            //assert
            Assert.IsTrue(test);
        }

        [Test]
        public void NomeDeveTerAte200Caracteres()
        {
            //Arrange -> //Act
            var test = new NomeDeveTerAte200Caracteres().IsSatisfiedBy(usuario);

            //assert
            Assert.IsTrue(test);
        }

        [Test]
        public void NomeDeveTerAte200Caracteres()
        {
            //Arrange -> //Act
            var test = new NomeDeveTerMinimo3Caracteres().IsSatisfiedBy(usuario);

            //assert
            Assert.IsTrue(test);
        }
        #endregion
    }
}
