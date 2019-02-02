using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using System.Collections.Generic;

namespace One.Application.Interfaces
{
    public interface IUsuarioOneAppService
    {
        #region Seção: ACAluno
        void SalvarAluno(CadastroAlunoViewModel pCadastroAlunoViewModel); 
        #endregion

        #region Seção: GECidade
        IEnumerable<GECidadeViewModel> ObterCidadesPorUF(int pCodigoUF);
        #endregion

        #region Seção: GEUF
        IEnumerable<GEUFViewModel> ObterTodasUF(); 
        #endregion

        #region SEGUsuarioUsuario
        SEGUsuarioViewModel ObterUsuarioPorLogin(string login);
        #endregion

        #region SEGUsuarioPerfil
        IEnumerable<SEGUsuarioPerfilViewModel> ObterUsuarioPerfilPorCodigoUsuario(int CodigoUsuario);
        #endregion
    }
}
