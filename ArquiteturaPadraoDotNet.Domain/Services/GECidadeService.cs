using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Services
{
    public class GECidadeService : IGECidadeService
    {
        private readonly IGECidadeRepository _iGECidadeRepository;

        public GECidadeService(IGECidadeRepository iGECidadeRepository)
        {
            _iGECidadeRepository = iGECidadeRepository;
        }
        public void Dispose()
        {
        }

        public IEnumerable<GECidade> ObterPorUF(int pCodigoUF)
        {
            return _iGECidadeRepository.ObterPorUF(pCodigoUF);
        }
    }
}
