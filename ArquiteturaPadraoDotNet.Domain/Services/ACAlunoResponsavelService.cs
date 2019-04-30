using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Services
{
    public class ACAlunoResponsavelService : IACAlunoResponsavelService
    {
        private readonly IACAlunoResponsavelRepository _iACAlunoResponsavelRepository;

        public ACAlunoResponsavelService(IACAlunoResponsavelRepository iACAlunoResponsavelRepository) => _iACAlunoResponsavelRepository = iACAlunoResponsavelRepository;
        public void Dispose() { }
        public ACAlunoResponsavel SalvarAlunoReponsavel(ACAlunoResponsavel ACAlunoResponsavel)
        {
            if (ACAlunoResponsavel.IsValid())
                _iACAlunoResponsavelRepository.Salvar(ACAlunoResponsavel);

            return ACAlunoResponsavel;
        }
    }
}
