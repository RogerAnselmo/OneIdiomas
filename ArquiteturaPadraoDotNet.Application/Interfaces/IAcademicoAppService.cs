using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using One.Domain.Validation;
using System.Collections.Generic;

namespace One.Application.Interfaces
{
    public interface IAcademicoAppService
    {
        #region Seção: ACAluno
        ValidationResults SalvarAluno(CadastroAlunoViewModel CadastroAlunoViewModel);
        IEnumerable<ACAlunoViewModel> ObterAlunosPorNome(string nome);
        EditarAlunoViewModel ObterAlunoParaEdicao(int id);
        void AlterarAluno(EditarAlunoViewModel editarAlunoViewModel);
        void ExcluirAluno(int id);
        #endregion
    }
}
