using One.Application.ViewModels.ACAlunoVM;

namespace One.Application.Interfaces
{
    public interface IAcademicoAppService
    {
        #region Seção: ACAluno
        void SalvarAluno(CadastroAlunoViewModel pCadastroAlunoViewModel);
        #endregion
    }
}
