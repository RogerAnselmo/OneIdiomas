using One.Domain.Entities;
using One.Domain.Validation;
using One.Domain.Specifications.ACResponsavelSpecification;

namespace One.Domain.Validations.ACResponsavelValidation
{
    public class ACResponsavelConsistenteValidation: Validator<ACResponsavel>
    {
        public ACResponsavelConsistenteValidation(ACResponsavel ACResponsavel)
        {
            #region Seção: Regras
            var CPFDeveSerValido = new CPFDeveSerValido();
            var DataDeNascimentoDeveSerValida = new DataDeNascimentoDeveSerValida();
            var CodigoDeUsuarioDeveSerMaiorQueZero = new CodigoDeUsuarioDeveSerMaiorQueZero();
            var RGDeveSerValido = new RGDeveSerValido();
            var RGDeveTerNoMaximo20caracteres = new RGDeveTerNoMaximo20caracteres();
            var StatusDeveSerValido = new StatusDeveSerValido();
            #endregion

            #region Seção: Validações
            base.Add("CPFDeveSerValido", new Rule<ACResponsavel>(CPFDeveSerValido, "Responsável deve ter um CPF válido.", ACResponsavel));
            base.Add("DataDeNascimentoDeveSerValida", new Rule<ACResponsavel>(DataDeNascimentoDeveSerValida, "Responsável deve ter data de nascimento válida.", ACResponsavel));
            base.Add("CodigoDeUsuarioDeveSerMaiorQueZero", new Rule<ACResponsavel>(CodigoDeUsuarioDeveSerMaiorQueZero, "Responsável deve ter um código de usuário.", ACResponsavel));
            base.Add("RGDeveSerValido", new Rule<ACResponsavel>(RGDeveSerValido, "RG do responsável deve ser válido.", ACResponsavel));
            base.Add("RGDeveTerNoMaximo20caracteres", new Rule<ACResponsavel>(RGDeveTerNoMaximo20caracteres, "RG do responsável deve ter no máximo 20 caracteres.", ACResponsavel));
            base.Add("StatusDeveSerValido", new Rule<ACResponsavel>(StatusDeveSerValido, "Status do responsável deve ser válido.", ACResponsavel));
            #endregion
        }
    }
}
