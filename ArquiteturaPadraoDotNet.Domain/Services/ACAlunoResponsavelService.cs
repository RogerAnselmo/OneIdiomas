using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Services
{
    public class ACAlunoResponsavelService : IACAlunoReponsavelService
    {
        private readonly IACAlunoResponsavelRepository _iACAlunoResponsavelRepository;

        public ACAlunoResponsavelService(IACAlunoResponsavelRepository iACAlunoResponsavelRepository)
        {
            _iACAlunoResponsavelRepository = iACAlunoResponsavelRepository;
        }

        public void Dispose()
        {
        }

        public void SalvarAlunoReponsavel(ACAlunoResponsavel ACAlunoResponsavel)
        {
            _iACAlunoResponsavelRepository.Salvar(ACAlunoResponsavel);
        }
    }
}
