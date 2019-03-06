using One.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Application.Interfaces
{
    public interface ISegurancaAppService
    {
        #region Seção: SEGUsuario
        void SalvarUsuario(SEGUsuarioViewModel usuarioViewModel);

        SEGUsuarioViewModel ObterUsuarioPorLogin(string login);
        #endregion

        #region Seção: SEGUsuarioPerfil
        IEnumerable<SEGUsuarioPerfilViewModel> ObterUsuarioPerfilPorCodigoUsuario(int CodigoUsuario);
        #endregion
    }
}
