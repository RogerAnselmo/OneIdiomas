using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Services
{
    public class ACResponsavelService : IACResponsavelService
    {
        private readonly IACResponsavelRepository _iACResponsavelRepository;

        public ACResponsavelService(IACResponsavelRepository iACResponsavelRepository)
        {
            _iACResponsavelRepository = iACResponsavelRepository;
        }

        public void Dispose()
        {
        }

        public ACResponsavel SalvarResponsavel(ACResponsavel ACResponsavel)
        {
            if(ACResponsavel.                )
            _iACResponsavelRepository.Salvar(ACResponsavel);
        }
    }
}
