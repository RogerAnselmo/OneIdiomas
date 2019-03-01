using NUnit.Framework;
using One.Domain.Entities;
using One.Domain.Specifications.SEGUsuarioSpecification;
using One.Domain.Validations.SEGUsuarioValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Test.Entities
{
    [TestFixture]
    public class SEGUsuarioTest
    {
        SEGUsuario SEGUsuario = new SEGUsuario();

        [SetUp]
        public void SetUp()
        {
            SEGUsuario = new SEGUsuario {
                NomeCompleto = "Carlos Rogério Campos Anselmo",
                Login = "carlos.anselmo",
                CodigoUsuario = 0,
                flAtivo = "A"
            };
        }

        [Test]
        public void SEGUsuarioConsistente()
        {
            //Arrange -> //Act
            var test = SEGUsuario.IsValid();

            //assert
            Assert.IsTrue(test);
        }

        [Test]
        public void SEGUsuarioConsistente_false()
        {
            //Arrange
            SEGUsuario = new SEGUsuario();

            //Act
            var test = SEGUsuario.IsValid();

            //assert
            Assert.IsFalse(test);
        }

        [Test]
        public void DeveTerUmNomeValido()
        {
            //Arrange -> //Act
            var test = new NomeDeveSerValido().IsSatisfiedBy(SEGUsuario);

            //assert
            Assert.IsTrue(test);
        }

        [Test]
        public void NomeDeveTerAte200Caracteres()
        {
            //Arrange -> //Act
            var test = new NomeDeveTerAte200Caracteres().IsSatisfiedBy(SEGUsuario);

            //assert
            Assert.IsTrue(test);
        }

        [Test]
        public void NomeDeveTerMinimo3Caracteres()
        {
            //Arrange -> //Act
            var test = new NomeDeveTerMinimo3Caracteres().IsSatisfiedBy(SEGUsuario);

            //assert
            Assert.IsTrue(test);
        }
    }
}
