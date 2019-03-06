using System.Collections.Generic;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;

namespace One.Domain.Services
{
    public class GEBairroService : IGEBairroService
    {
        #region Seção: Interface - IoC
        private readonly IGEBairroRepository _iGEBairroRepository;
        #endregion

        #region Seção: Construtor
        public GEBairroService(IGEBairroRepository iGEBairroRepository)
        {
            _iGEBairroRepository = iGEBairroRepository;
        }
        #endregion

        #region Seção: Dispose
        public void Dispose()
        {
        }
        #endregion

        #region Seção: Services - Read
        public IEnumerable<GEBairro> ObterBairroPorCidade(int CodigoCidade)
        {
            return _iGEBairroRepository.ObterBairroPorCidade(CodigoCidade);
        } 
        #endregion
    }
}
