using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Services
{
    public class ACTurmaService : IACTurmaService
    {
        private readonly IACTurmaRepository _iACTurmaRepository;

        public ACTurmaService(IACTurmaRepository iACTurmaRepository) => _iACTurmaRepository = iACTurmaRepository;

        public ACTurma Alterar(ACTurma aCTurma)
        {
            if (aCTurma.IsValid())
                _iACTurmaRepository.Alterar(aCTurma);

            return aCTurma;
        }

        public void Dispose()
        {
        }

        public ACTurma Salvar(ACTurma aCTurma)
        {
            if (aCTurma.IsValid())
                _iACTurmaRepository.Salvar(aCTurma);

            return aCTurma;
        }
    }
}
