using One.Domain.Entities;
using NUnit.Framework;
using System;
using One.Domain.Specifications.ACAlunoSpecification;
using FluentAssertions;

namespace One.Test.Unit.Domain.Specification
{
    public class DataDeNascimentoDeveSerValidaTest
    {
        private DataDeNascimentoDeveSerValida dataDeNascimentoDeveSerValida;
        private ACAluno aluno;

        [SetUp]
        public void SetUp()
        {
            aluno = new ACAluno(0, 0, "", "", DateTime.Now, 0);
            dataDeNascimentoDeveSerValida = new DataDeNascimentoDeveSerValida();
        }

        [Test]
        public void DeveSerFalsoParaDatasMaioresQueDataAtual()
        {
            aluno.DataNascimento = DateTime.Now.AddDays(1);
            dataDeNascimentoDeveSerValida.IsSatisfiedBy(aluno).Should().BeFalse();
        }

        [Test]
        public void DeveSerVerdadeiroParaDatasMenoresQueDataAtual()
        {
            aluno.DataNascimento = DateTime.Now;
            dataDeNascimentoDeveSerValida.IsSatisfiedBy(aluno).Should().BeTrue();
        }

        [Test]
        public void DeveSerFalsoParaDatasMenoresQue1900()
        {
            aluno.DataNascimento = new DateTime(1899, 12, 31);
            dataDeNascimentoDeveSerValida.IsSatisfiedBy(aluno).Should().BeFalse();
        }

        [Test]
        public void DeveSerVerdadeiroParaDatasIguaisDataAtual()
        {
            aluno.DataNascimento = DateTime.Today;
            dataDeNascimentoDeveSerValida.IsSatisfiedBy(aluno).Should().BeTrue();
        }
    }
}
