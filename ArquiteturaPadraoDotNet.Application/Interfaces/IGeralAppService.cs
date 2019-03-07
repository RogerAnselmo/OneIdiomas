using One.Application.ViewModels;
using System.Collections.Generic;

namespace One.Application.Interfaces
{
    public interface IGeralAppService
    {
        #region Seção: GEUF
        IEnumerable<GEUFViewModel> ObterTodasUF();
        #endregion

        #region Seção: GECidade
        IEnumerable<GECidadeViewModel> ObterCidadesPorUF(int pCodigoUF);
        #endregion

        #region Seção: GEBairro
        IEnumerable<GEBairroViewModel> ObterBairroPorCidade(int CodigoCidade);
        #endregion

        #region Seção: GEParentesco
        IEnumerable<GEParentescoViewModel> ObterTodosParentesco(); 
        #endregion
    }
}
