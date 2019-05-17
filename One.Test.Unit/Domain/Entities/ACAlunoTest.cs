using FluentAssertions;
using NUnit.Framework;
using One.Domain.Entities;
using System;

namespace One.Test.Unit.Domain.Entities
{
    public class ACAlunoTest
    {
        private ACAluno aluno;
        [SetUp]
        public void SetUp() => aluno = new ACAluno(0, 0, null, null, DateTime.Today, 0);


        [Test]
        public void DeveCalcularIdadeCorretamente()
        {
            aluno.DataNascimento = new DateTime(1989, 9, 4);
            aluno.Idade(new DateTime(2019, 5, 18)).Should().Be(29);
        }

        [Test]
        public void DeveCalcularIdadeCorretamenteParaNacimentosEmAnosBissextos()
        {
            aluno.DataNascimento = new DateTime(2000, 3, 15);
            aluno.Idade(new DateTime(2020, 2, 29)).Should().Be(19);
        }
    }
}
