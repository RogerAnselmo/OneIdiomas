using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Services
{
    public class ACProfessorService : IACProfessorService
    {
        private readonly IACProfessorRepository _iACProfessorRepository;

        public ACProfessorService(IACProfessorRepository iACProfessorRepository)
        {
            _iACProfessorRepository = iACProfessorRepository;
        }

        public ACProfessor Alterar(ACProfessor ACProfessor)
        {
            if (ACProfessor.IsValid())
                _iACProfessorRepository.Alterar(ACProfessor);

            return ACProfessor;
        }

        public void Dispose()
        {

        }

        public ACProfessor Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public ACProfessor ObterProfessorParaEdicao(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ACProfessor> ObterProfessorPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public ACProfessor Salvar(ACProfessor ACProfessor)
        {
            if (ACProfessor.IsValid())
                _iACProfessorRepository.Salvar(ACProfessor);

            return ACProfessor;
        }
    }
}
