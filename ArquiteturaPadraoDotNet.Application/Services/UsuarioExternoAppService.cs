using One.Application.Interfaces;
using One.Domain.Interfaces.Service;

namespace One.Application.Services
{
    public class UsuarioExternoAppService: IUsuarioExternoAppservice
    {
        #region Interface - IoC
        private readonly ISEGUsuarioService _iSEGUsuarioServico;
        #endregion

        #region Construtor
        public UsuarioExternoAppService(ISEGUsuarioService iSEGUsuarioServico)
        {
            _iSEGUsuarioServico = iSEGUsuarioServico;
        } 
        #endregion

        public void SalvarNovoUsuario()
        {

        }
    }
}
