using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using One.Domain.Validation;
using System.Collections.Generic;

namespace One.Domain.Services
{
    public class ACResponsavelService : IACResponsavelService
    {
        #region Seção: Interface -IoC
        private readonly IACResponsavelRepository _iACResponsavelRepository;
        #endregion

        #region Seção: Construtor
        public ACResponsavelService(IACResponsavelRepository iACResponsavelRepository) => _iACResponsavelRepository = iACResponsavelRepository;
        #endregion

        #region Seção: Dispose
        public void Dispose()
        {
        }
        #endregion

        #region Seção: Servicos
        public ACResponsavel Salvar(ACResponsavel ACResponsavel)
        {
            if (ACResponsavel.IsValid())
                _iACResponsavelRepository.Salvar(ACResponsavel);

            return ACResponsavel;
        }

        public ACResponsavel Alterar(ACResponsavel ACResponsavel)
        {
            if (ACResponsavel.IsValid())
                _iACResponsavelRepository.Alterar(ACResponsavel);

            return ACResponsavel;
        }

        public ACResponsavel Excluir(int id)
        {
            ACResponsavel ACResponsavel = _iACResponsavelRepository.ObterPorId(id);
            ACResponsavel.flAtivo = "I";
            _iACResponsavelRepository.Alterar(ACResponsavel);
            ACResponsavel.ValidationResult = new ValidationResults(true, "Responsável excluído com sucesso");
            return ACResponsavel;
        }

        public IEnumerable<ACResponsavel> ObterPorNome(string nome) => _iACResponsavelRepository.ObterPorNome(nome);

        public ACResponsavel ObterPorId(int id) => _iACResponsavelRepository.ObterPorId(id);
        #endregion
    }
}
