using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using System.Collections.Generic;

namespace One.Application.Interfaces
{
    public interface IUsuarioOneAppService
    {
        void SalvarAluno(CadastroAlunoViewModel pCadastroAlunoViewModel);

        #region GECidade
        IEnumerable<GECidadeViewModel> ObterPorUF(int pCodigoUF);
        #endregion

        #region GEUF
        IEnumerable<GEUFViewModel> ObterTodasUF(); 
        #endregion

        #region Usuario
        SEGUsuarioViewModel ObterUsuarioPorLogin(string login);
        #endregion

        #region UsuarioPerfil
        IEnumerable<SEGUsuarioPerfilViewModel> ObterUsuarioPerfilPorCodigoUsuario(int CodigoUsuario);
        #endregion
    }
}
