using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using One.Domain.Services;

namespace One.Test.Unit.Domain.Services
{
    public class ACAlunoResponsavelServiceTest
    {
        protected IACAlunoResponsavelService _iACAlunoResponsavelService;
        protected IACAlunoResponsavelRepository fakeACAlunoResponsavelRepository;
        protected ACAlunoResponsavel fakeACAlunoResponsavel;

        [SetUp]
        public void SetUp()
        {
            fakeACAlunoResponsavelRepository = A.Fake<IACAlunoResponsavelRepository>();
            _iACAlunoResponsavelService = new ACAlunoResponsavelService(fakeACAlunoResponsavelRepository);
            fakeACAlunoResponsavel = A.Fake<ACAlunoResponsavel>();
        }

        [Test]
        public void DeveRetornarMesmoObjetoPassadoPorParametro()
        {
            A.CallTo(() => fakeACAlunoResponsavel.IsValid()).Returns(true);
            _iACAlunoResponsavelService.Salvar(fakeACAlunoResponsavel).Should().Be(fakeACAlunoResponsavel);
        }


        [Test]
        public void DeveChamarRepositorioSalvarExatamenteUmaVezQuandoIsValidRetornarTrue()
        {
            A.CallTo(() => fakeACAlunoResponsavel.IsValid()).Returns(true);
            _iACAlunoResponsavelService.Salvar(fakeACAlunoResponsavel);
            A.CallTo(() => fakeACAlunoResponsavelRepository.Salvar(fakeACAlunoResponsavel)).MustHaveHappenedOnceExactly();
        }

        [Test]
        public void NaoDeveChamarRepositorioSalvarQuandoIsValidRetornarFalse()
        {
            A.CallTo(() => fakeACAlunoResponsavel.IsValid()).Returns(false);
            _iACAlunoResponsavelService.Salvar(fakeACAlunoResponsavel);
            A.CallTo(() => fakeACAlunoResponsavelRepository.Salvar(fakeACAlunoResponsavel)).MustNotHaveHappened();
        }
    }
}
