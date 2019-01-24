using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Services
{
    public class GEUFService : IGEUFService
    {
        private readonly IGEUFRepository _iGEUFRepository;
        public GEUFService(IGEUFRepository iGEUFRepository)
        {
            _iGEUFRepository = iGEUFRepository;
        }
        public void Dispose()
        {
        }

        public IEnumerable<GEUF> ObterTodos()
        {
            return _iGEUFRepository.ObterTodos();
        }
    }
}
