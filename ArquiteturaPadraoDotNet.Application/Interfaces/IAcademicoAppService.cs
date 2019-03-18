using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using System.Collections.Generic;

namespace One.Application.Interfaces
{
    public interface IAcademicoAppService
    {
        #region Seção: ACAluno
        void SalvarAluno(CadastroAlunoViewModel pCadastroAlunoViewModel);

        IEnumerable<ACAlunoViewModel> ObterAlunosPorNome(string nome);
        #endregion
    }
}
