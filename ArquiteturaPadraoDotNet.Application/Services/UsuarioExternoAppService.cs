using One.Application.Adapter;
using One.Application.Interfaces;
using One.Application.UoW;
using One.Application.ViewModels;
using One.Domain.Interfaces.Service;
using One.Infra.Data.Interface;

namespace One.Application.Services
{
    public class UsuarioExternoAppService: ApplicationServiceTransaction, IUsuarioExternoAppservice
    {
        #region Interface - IoC
        private readonly ISEGUsuarioService _iSEGUsuarioService;
        #endregion

        #region Construtor
        public UsuarioExternoAppService(ISEGUsuarioService iSEGUsuarioService, IUnitOfWorkTransaction uow): base(uow)
        {
            _iSEGUsuarioService = iSEGUsuarioService;
        }
        #endregion

        #region Services
        public void SalvarUsuario(SEGUsuarioViewModel usuarioViewModel)
        {
            BeginTransaction();
            _iSEGUsuarioService.SalvarUsuario(SEGUsuarioAdapter.ViewModelToDomain(usuarioViewModel));
            SaveChange();
            Commit();
        }
        #endregion
    }
}
