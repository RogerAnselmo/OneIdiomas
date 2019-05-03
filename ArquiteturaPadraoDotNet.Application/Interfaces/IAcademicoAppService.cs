using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using One.Application.ViewModels.ACResponsavelVM;
using One.Domain.Validation;
using System.Collections.Generic;

namespace One.Application.Interfaces
{
    public interface IAcademicoAppService
    {
        #region Seção: ACAluno
        ValidationResults SalvarAluno(CadastroAlunoViewModel CadastroAlunoViewModel);
        ValidationResults AlterarAluno(EditarAlunoViewModel editarAlunoViewModel);
        ValidationResults ExcluirAluno(int id);
        IEnumerable<ACAlunoViewModel> ObterAlunosPorNome(string nome);
        EditarAlunoViewModel ObterAlunoParaEdicao(int id);
        #endregion

        #region Seção: ACResponsavel
        ValidationResults AlterarResponsavel(CadastroResponsavelViewModel cadastroResponsavelViewModel);
        ValidationResults SalvarResponsavel(CadastroResponsavelViewModel cadastroResponsavelViewModel);
        ValidationResults ExcluirResponsavel(int id);
        IEnumerable<ACResponsavelViewModel> ObterPorResponsavelNome(string nome);
        CadastroResponsavelViewModel ObterResponsavelParaEdicao(int id);
        #endregion
    }
}
