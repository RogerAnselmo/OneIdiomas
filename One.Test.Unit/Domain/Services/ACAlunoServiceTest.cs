using Bogus;
using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using One.Domain.Services;

namespace One.Test.Unit.Domain.Services
{
    public class ACAlunoServiceTest
    {
        protected IACAlunoService _iACAlunoService;
        protected Faker faker;

        #region Seção: Fake Intefaces
        protected IACAlunoRepository fakeACAlunoRepository;
        protected IGEEnderecoRepository fakeGEEnderecoRepository;
        protected IGETelefoneRepository fakeGETelefoneRepository;
        #endregion

        [SetUp]
        public void ACAlunoServiceSetUp()
        {
            faker = new Faker();
            fakeACAlunoRepository = A.Fake<IACAlunoRepository>();
            _iACAlunoService = new ACAlunoService(fakeACAlunoRepository, fakeGEEnderecoRepository, fakeGETelefoneRepository);
        }

        public class SalvarTest : ACAlunoServiceTest
        {
            ACAluno fakeACAluno;

            [SetUp]
            public void SetUp() => fakeACAluno = A.Fake<ACAluno>();

            [Test]
            public void DeveRetornarAlunoPassadoPorParametro()
            {
                A.CallTo(() => fakeACAluno.IsValid()).Returns(true);
                _iACAlunoService.Salvar(fakeACAluno).Should().Be(fakeACAluno);
            }

            [Test]
            public void DeveChamarRepositorioSomenteUmaVezQuandoIsValidTrue()
            {
                A.CallTo(() => fakeACAluno.IsValid()).Returns(true);
                _iACAlunoService.Salvar(fakeACAluno);
                A.CallTo(() => fakeACAlunoRepository.Salvar(fakeACAluno)).MustHaveHappenedOnceExactly();
            }

            [Test]
            public void NaoDeveChamarRepositorioQuandoIsValidFalse()
            {
                A.CallTo(() => fakeACAluno.IsValid()).Returns(false);
                _iACAlunoService.Salvar(fakeACAluno);
                A.CallTo(() => fakeACAlunoRepository.Salvar(fakeACAluno)).MustNotHaveHappened();
            }
        }

        public class AlterarTest : ACAlunoServiceTest
        {
            ACAluno fakeACAluno;

            [SetUp]
            public void SetUp() => fakeACAluno = A.Fake<ACAluno>();

            [Test]
            public void DeveRetornarAlunoPassadoPorParametro()
            {
                A.CallTo(() => fakeACAluno.IsValid()).Returns(true);
                _iACAlunoService.Alterar(fakeACAluno).Should().Be(fakeACAluno);
            }

            [Test]
            public void DeveChamarRepositorioSomenteUmaVezQuandoIsValidTrue()
            {
                A.CallTo(() => fakeACAluno.IsValid()).Returns(true);
                _iACAlunoService.Alterar(fakeACAluno);
                A.CallTo(() => fakeACAlunoRepository.Alterar(fakeACAluno)).MustHaveHappenedOnceExactly();
            }

            [Test]
            public void NaoDeveChamarRepositorioQuandoIsValidFalse()
            {
                A.CallTo(() => fakeACAluno.IsValid()).Returns(false);
                A.CallTo(() => fakeACAlunoRepository.Alterar(A<ACAluno>._)).MustNotHaveHappened();
            }
        }

        public class ExcluitTest : ACAlunoServiceTest
        {
            ACAluno fakeAluno;
            int fakeId;

            [SetUp]
            public void SetUp()
            {
                fakeAluno = A.Fake<ACAluno>();
                fakeId = faker.Random.Int();
            }

            [Test]
            public void DeveRetornarObjetoComflAtivoI()
            {
                A.CallTo(() => fakeACAlunoRepository.ObterPorId(A<int>._)).Returns(A.Fake<ACAluno>());
                _iACAlunoService.Excluir(fakeId).flAtivo.Should().Be("I");
            }

            [Test]
            public void DeveRetornarValidationResultFalseQuandoObterPorIdRetornarNull()
            {
                A.CallTo(() => fakeACAlunoRepository.ObterPorId(fakeId)).Returns(null);
                _iACAlunoService.Excluir(fakeId).ValidationResult.IsValid.Should().BeFalse();
            }

            [Test]
            public void DeveRetornarValidationResultTrueQuandoOpterPorIdRetornarACAluno()
            {
                A.CallTo(() => fakeACAlunoRepository.ObterPorId(fakeId)).Returns(A.Fake<ACAluno>());
                _iACAlunoService.Excluir(fakeId).ValidationResult.IsValid.Should().BeTrue();
            }

            [Test]
            public void DeveChamarRepositorioAlterarExatamenteUmaVez()
            {
                A.CallTo(() => fakeACAlunoRepository.ObterPorId(fakeId)).Returns(fakeAluno);
                _iACAlunoService.Excluir(fakeId);
                A.CallTo(() => fakeACAlunoRepository.Alterar(fakeAluno)).MustHaveHappenedOnceExactly();
            }
        }
    }
}
