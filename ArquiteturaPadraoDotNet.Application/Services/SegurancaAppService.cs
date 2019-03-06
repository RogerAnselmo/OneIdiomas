using One.Application.Adapter;
using One.Application.Interfaces;
using One.Application.UoW;
using One.Application.ViewModels;
using One.Domain.Interfaces.Service;
using One.Infra.Data.Interface;
using System.Collections.Generic;

namespace One.Application.Services
{
    public class SegurancaAppService : ApplicationServiceTransaction, ISegurancaAppService
    {
        #region Interface - IoC
        private readonly ISEGUsuarioService _iSEGUsuarioService;
        private readonly ISEGUsuarioPerfilService _iSEGUsuarioPerfilService;
        #endregion

        #region Seção: Construtor
        public SegurancaAppService(ISEGUsuarioService iSEGUsuarioService,
                                   ISEGUsuarioPerfilService iSEGUsuarioPerfilService,
                                   IUnitOfWorkTransaction uow) : base(uow)
        {
            _iSEGUsuarioService = iSEGUsuarioService;
            _iSEGUsuarioPerfilService = iSEGUsuarioPerfilService;
        }
        #endregion

        #region Seção: SEGUsuario
        public void SalvarUsuario(SEGUsuarioViewModel usuarioViewModel)
        {
            BeginTransaction();
            _iSEGUsuarioService.SalvarUsuario(SEGUsuarioAdapter.ViewModelToDomain(usuarioViewModel));
            SaveChange();
            Commit();
        }

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
