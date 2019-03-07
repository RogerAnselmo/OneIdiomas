using One.Application.Adapter;
using One.Application.Interfaces;
using One.Application.UoW;
using One.Application.ViewModels;
using One.Domain.Interfaces.Service;
using One.Infra.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Application.Services
{
    public class GeralAppService : ApplicationServiceTransaction, IGeralAppService
    {

        #region Interface - IoC
        private readonly IGEUFService _iGEUF;
        private readonly IGECidadeService _iGECidadeService;
        private readonly IGEBairroService _iGEBairroService;
        private readonly IGEParentescoService _iGEParentescoService;
        #endregion

        #region Seção: Construtor
        public GeralAppService(IGEUFService iGEUF,
           IGECidadeService iGECidadeService,
           IGEBairroService iGEBairroService,
           IGEParentescoService iGEParentescoService,
           IUnitOfWorkTransaction uow) : base(uow)
        {
            _iGEUF = iGEUF;
            _iGECidadeService = iGECidadeService;
            _iGEBairroService = iGEBairroService;
            _iGEParentescoService = iGEParentescoService;
        }
        #endregion

        #region Seção: GEUF
        public IEnumerable<GEUFViewModel> ObterTodasUF()
        {
            return GEUFAdapter.DomainToViewModel(_iGEUF.ObterTodos());
        }
        #endregion

        #region Seção: GECidade
        public IEnumerable<GECidadeViewModel> ObterCidadesPorUF(int pCodigoUF)
        {
            return GECidadeAdapter.DomainToViewModel(_iGECidadeService.ObterPorUF(pCodigoUF));
        }
        #endregion

        #region Seção: GEBairro
        public IEnumerable<GEBairroViewModel> ObterBairroPorCidade(int CodigoCidade)
        {
            return GEBairroAdapter.DomainToViewModel(_iGEBairroService.ObterBairroPorCidade(CodigoCidade));
        }
        #endregion

        #region Seção: Parentesco
        public IEnumerable<GEParentescoViewModel> ObterTodosParentesco()
        {
            return GEPArentescoAdapter.DomainToViewModel(_iGEParentescoService.ObterTodos());
        } 
        #endregion
    }
}
