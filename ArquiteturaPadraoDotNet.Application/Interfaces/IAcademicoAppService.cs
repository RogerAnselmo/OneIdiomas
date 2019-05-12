using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using One.Application.ViewModels.ACProfessorVM;
using One.Application.ViewModels.ACResponsavelVM;
using One.Application.ViewModels.ACTurmaVM;
using One.Domain.Validation;
using System.Collections.Generic;

namespace One.Application.Interfaces
{
    public interface IAcademicoAppService
    {
        #region Seção: ACAluno
        ValidationResults SalvarAluno(CadastroAlunoViewModel cadastroAlunoViewModel);
        ValidationResults AlterarAluno(CadastroAlunoViewModel CadastroAlunoViewModel);
        ValidationResults ExcluirAluno(int id);
        IEnumerable<ACAlunoViewModel> ObterAlunosPorNome(string nome);
        CadastroAlunoViewModel ObterAlunoParaEdicao(int id);
        #endregion

        #region Seção: ACResponsavel
        ValidationResults AlterarResponsavel(CadastroResponsavelViewModel cadastroResponsavelViewModel);
        ValidationResults SalvarResponsavel(CadastroResponsavelViewModel cadastroResponsavelViewModel);
        ValidationResults ExcluirResponsavel(int id);
        IEnumerable<ACResponsavelViewModel> ObterResponsavelPorNome(string nome);
        CadastroResponsavelViewModel ObterResponsavelParaEdicao(int id);
        #endregion

        #region Seção: ACProfessor
        ValidationResults SalvarProfessor(CadastroProfessorViewModel cadastroProfessorViewModel);
        ValidationResults AlterarProfessor(CadastroProfessorViewModel cadastroProfessorViewModel);
        ValidationResults ExcluirProfessor(int id);
        IEnumerable<ACProfessorViewModel> ObterProfessorPorNome(string nome);
        CadastroProfessorViewModel ObterProfessorParaEdicao(int id);
        #endregion

        #region Seção: ACNivel
        IEnumerable<ACNivelViewModel> ObterNiveisAtivos();
        #endregion
        
        #region Seção: ACTurma
        ValidationResults SalvarTurma(CadastroTurmaViewModel cadastroTurmaViewModel);
        ValidationResults AlterarTurma(CadastroTurmaViewModel cadastroTurmaViewModel);
        CadastroTurmaViewModel ObterTurmaParaEdicao(int id);
        #endregion
    }
}
