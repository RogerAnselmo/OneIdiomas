using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Services
{
    public class GETelefoneService : IGETelefoneService
    {
        #region Interface - IoC
        private readonly IGETelefoneRepository _iGETelefoneRepository;
        #endregion

        #region Construtor
        public GETelefoneService(IGETelefoneRepository iGETelefoneRepository)
        {
            _iGETelefoneRepository = iGETelefoneRepository;
        }
        #endregion

        #region Serviços
        public void Dispose()
        {
        }

        public GETelefone SalvarTelefone(GETelefone GETelefone)
        {
            if (GETelefone.IsValid())
                _iGETelefoneRepository.Salvar(GETelefone);

            return GETelefone;
        }
        #endregion
    }
}
