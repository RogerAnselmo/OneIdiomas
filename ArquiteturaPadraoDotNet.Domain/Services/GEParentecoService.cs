using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Services
{
    public class GEParentecoService : IGEParentescoService
    {
        #region Seção: Interface - IoC
        private readonly IGEParentescoRepository _iGEParentescoRepository;
        #endregion

        #region Seção: Contrutor - Dispose
        public GEParentecoService(IGEParentescoRepository iGEParentescoRepository)
        {
            _iGEParentescoRepository = iGEParentescoRepository;
        }
        public void Dispose()
        {
        }
        #endregion

        #region Seção: Serviços
        public IEnumerable<GEParentesco> ObterTodos()
        {
            return _iGEParentescoRepository.ObterTodosParentesco();
        } 
        #endregion
    }
}
