using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using One.Domain.Services;

namespace One.Test.Unit.Domain.Services
{
    public class ACProfessorServiceTest
    {
        IACProfessorRepository fakeACProfessorRepository;
        IACProfessorService _iACProfessorService;

        int fakeId;
        ACProfessor fakeACProfessor;

        [SetUp]
        public void ACProfessorServiceTestSetUp()
        {
            fakeACProfessorRepository = A.Fake<IACProfessorRepository>();
            _iACProfessorService = new ACProfessorService(fakeACProfessorRepository);
        }

        public class AlterarTest: ACProfessorServiceTest
        {
            [SetUp]
            public void SetUp() => fakeACProfessor = A.Fake<ACProfessor>();

            [Test]
            public void DeveRetornarMesmoObjetoPassadoPorParametro() 
                => _iACProfessorService.Alterar(fakeACProfessor).Should().Be(fakeACProfessor);

            [Test]
            public void DeveChamarRepositorioAlterarExatamenteUmaVezQuandoIsValidTrue()
            {
                A.CallTo(() => fakeACProfessor.IsValid()).Returns(true);
                _iACProfessorService.Alterar(fakeACProfessor);
                A.CallTo(() => fakeACProfessorRepository.Alterar(fakeACProfessor)).MustHaveHappenedOnceExactly();
            }

            [Test]
            public void NaoDeveChamarRepositorioAlterarQuandoIsValidFalse()
            {
                A.CallTo(() => fakeACProfessor.IsValid()).Returns(false);
                _iACProfessorService.Alterar(fakeACProfessor);
                A.CallTo(() => fakeACProfessorRepository.Alterar(fakeACProfessor)).MustNotHaveHappened();
            }
        }
    }
}
