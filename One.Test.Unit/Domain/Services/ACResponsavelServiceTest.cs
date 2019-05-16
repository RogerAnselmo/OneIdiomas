using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using One.Domain.Services;

namespace One.Test.Unit.Domain.Services
{
    public class ACResponsavelServiceTest
    {
        protected IACResponsavelService _iACResponsavelService;
        protected ACResponsavel resposnsavel;

        protected IACResponsavelRepository _iACResponsavelRepository;
        protected IGEEnderecoRepository _iGEEnderecoRepository;


        [SetUp]
        public void SetUp()
        {
            _iACResponsavelRepository = A.Fake<IACResponsavelRepository>();
            _iGEEnderecoRepository = A.Fake<IGEEnderecoRepository>();
            _iACResponsavelService = new ACResponsavelService(_iACResponsavelRepository, _iGEEnderecoRepository);
        } 
            

        public class SalvarTest: ACResponsavelServiceTest
        {
            [SetUp]
            public void SetUp() => resposnsavel = A.Fake<ACResponsavel>();

            [Test]
            public void DeveRetornarMesmoObjeto() 
                => _iACResponsavelService.Salvar(resposnsavel).Should().Be(resposnsavel);

            [Test]
            public void DeveChamarResponsavelRepositorioQuandoIsValidTrue()
            {
                A.CallTo(() => resposnsavel.IsValid()).Returns(true);
                _iACResponsavelService.Salvar(resposnsavel);
                A.CallTo(() => _iACResponsavelRepository.Salvar(resposnsavel)).MustHaveHappenedOnceExactly();
            }

            [Test]
            public void NaoDeveChamarResponsavelRepositorioQuandoIsValidFalse()
            {
                A.CallTo(() => resposnsavel.IsValid()).Returns(false);
                _iACResponsavelService.Salvar(resposnsavel);
                A.CallTo(() => _iACResponsavelRepository.Salvar(resposnsavel)).MustNotHaveHappened();
            }
        }
    }
}
