using One.Domain.Entities;
using One.Domain.Validation;
using One.Domain.Specifications.ACAlunoSpecification;

namespace One.Domain.Validations.ACAlunoValidation
{
    public class ACAlunoConsistenteValidation: Validator<ACAluno>
    {
        public ACAlunoConsistenteValidation(ACAluno ACAluno)
        {
            #region Seção: Regras
            var CPFDeveSerValido = new CPFDeveSerValido();
            var DataDeNascimentoDeveSerValida = new DataDeNascimentoDeveSerValida();
            var CodigoDeUsuarioDeveSerMaiorQueZero = new CodigoDeUsuarioDeveSerMaiorQueZero();
            var DiaVencimentoDeveSerValido = new DiaVencimentoDeveSerValido();
            var RGDeveSerValido = new RGDeveSerValido();
            var StatusDeveSerValido = new StatusDeveSerValido();
            #endregion

            #region Seção: Validações
            base.Add("CPFDeveSerValido", new Rule<ACAluno>(CPFDeveSerValido, "Aluno deve ter um CPF válido.", ACAluno));
            base.Add("DataDeNascimentoDeveSerValida", new Rule<ACAluno>(DataDeNascimentoDeveSerValida, "Aluno deve ter data de nascimento válida.", ACAluno));
            base.Add("CodigoDeUsuarioDeveSerMaiorQueZero", new Rule<ACAluno>(CodigoDeUsuarioDeveSerMaiorQueZero, "Aluno deve ter um código de usuário.", ACAluno));
            base.Add("DiaVencimentoDeveSerValido", new Rule<ACAluno>(DiaVencimentoDeveSerValido, "Dia de vencimento deve ser válido.", ACAluno));
            base.Add("RGDeveSerValido", new Rule<ACAluno>(RGDeveSerValido, "RG deve ser válido.", ACAluno));
            base.Add("StatusDeveSerValido", new Rule<ACAluno>(StatusDeveSerValido, "Status deve ser válido.", ACAluno));
            #endregion
        }
    }
}
