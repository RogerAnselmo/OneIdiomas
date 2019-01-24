using One.Application.Adapter;
using One.Application.Interfaces;
using One.Application.UoW;
using One.Application.ViewModels;
using One.Domain.Interfaces.Service;
using One.Infra.Data.Interface;
using System.Collections.Generic;

namespace One.Application.Services
{
    public class UsuarioOneAppService : ApplicationServiceTransaction, IUsuarioOneAppService
    {
        #region Interface - IoC
        private readonly IGEUFService _iGEUF;
        private readonly IGECidadeService _iGECidadeService;
        private readonly ISEGUsuarioService _iSEGUsuarioService;
        private readonly ISEGUsuarioPerfilService _iSEGUsuarioPerfilService;
        #endregion

        #region Construtor
        public UsuarioOneAppService(IGEUFService iGEUF,
            IGECidadeService iGECidadeService,
            ISEGUsuarioService iSEGUsuarioService,
            ISEGUsuarioPerfilService iSEGUsuarioPerfilService,
            IUnitOfWorkTransaction uow) : base(uow)
        {
            _iGEUF = iGEUF;
            _iGECidadeService = iGECidadeService;
            _iSEGUsuarioService = iSEGUsuarioService;
            _iSEGUsuarioPerfilService = iSEGUsuarioPerfilService;
        }
        #endregion

        #region Seção: GEUF
        public IEnumerable<GEUFViewModel> ObterTodasUF()
        {
            return GEUFAdapter.DomainToViewModel(_iGEUF.ObterTodos());
        }
        #endregion

        public IEnumerable<GECidadeViewModel> ObterPorUF(int pCodigoUF)
        {
            return GECidadeAdapter.DomainToViewModel(_iGECidadeService.ObterPorUF(pCodigoUF));
        }

        #region Seção: SEGUsuario
        public IEnumerable<SEGUsuarioPerfilViewModel> ObterUsuarioPerfilPorCodigoUsuario(int CodigoUsuario)
        {
            return SEGUsuarioPerfilAdapter.DomainToViewModel(_iSEGUsuarioPerfilService.ObterUsuarioPerfilPorCodigoUsuario(CodigoUsuario));
        }

        public SEGUsuarioViewModel ObterUsuarioPorLogin(string login)
        {
            return SEGUsuarioAdapter.DomainToViewModel(_iSEGUsuarioService.ObterUsuarioPorLogin(login));
        }
        #endregion
    }
}
