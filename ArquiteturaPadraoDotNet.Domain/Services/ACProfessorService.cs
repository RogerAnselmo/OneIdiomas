using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using One.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Services
{
    public class ACProfessorService : IACProfessorService
    {
        #region Seção: Interface - IoC
        private readonly IACProfessorRepository _iACProfessorRepository;
        #endregion

        #region Seção: Construtor
        public ACProfessorService(IACProfessorRepository iACProfessorRepository)
            => _iACProfessorRepository = iACProfessorRepository;
        #endregion

        #region Seção: Dispose
        public void Dispose() { }
        #endregion

        #region Seção: Serviços
        public ACProfessor Alterar(ACProfessor ACProfessor)
        {
            if (ACProfessor.IsValid())
                _iACProfessorRepository.Alterar(ACProfessor);

            return ACProfessor;
        }

        public ACProfessor Excluir(int id)
        {
            ACProfessor ACProfessor = _iACProfessorRepository.ObterPorId(id);
            ACProfessor.flAtivo = "I";
            _iACProfessorRepository.Alterar(ACProfessor);
            ACProfessor.ValidationResult = new ValidationResults(true, "Professor excluído com sucesso");
            return ACProfessor;
        }

        public ACProfessor ObterProfessorParaEdicao(int id)
        {
            return _iACProfessorRepository.ObterPorId(id);
        }

        public IEnumerable<ACProfessor> ObterProfessorPorNome(string nome)
            => _iACProfessorRepository.ObterProfessorPorNome(nome);

        public ACProfessor Salvar(ACProfessor ACProfessor)
        {
            if (ACProfessor.IsValid())
                _iACProfessorRepository.Salvar(ACProfessor);

            return ACProfessor;
        } 
        #endregion
    }
}
