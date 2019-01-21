using One.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Application.Interfaces
{
    public interface IUsuarioOneAppService
    {
        #region Usuario
        SEGUsuarioViewModel ObterUsuarioPorLogin(string login);
        #endregion

        #region UsuarioPerfil
        IEnumerable<SEGUsuarioPerfilViewModel> ObterUsuarioPerfilPorCodigoUsuario(int CodigoUsuario);
        #endregion
    }
}
