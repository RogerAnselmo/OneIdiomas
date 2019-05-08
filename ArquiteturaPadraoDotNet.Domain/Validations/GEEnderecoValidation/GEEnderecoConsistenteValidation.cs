using One.Domain.Entities;
using One.Domain.Validation;
using One.Domain.Specifications.GEEnderecoSpecification;

namespace One.Domain.Validations.GEEnderecoValidation
{
    public class GEEnderecoConsistenteValidation : Validator<GEEndereco>
    {
        public GEEnderecoConsistenteValidation(GEEndereco GEEndereco)
        {
            #region Seção: Regras
            var CEPDeveSerValido = new CEPDeveSerValido();
            var CodigoBairroDeveSerMaiorQueZero = new CodigoBairroDeveSerMaiorQueZero();
            var LogradouroDeveSerValido = new LogradouroDeveSerValido();
            var StatusDeveSerValido = new StatusDeveSerValido();
            var NumeroDeveSerValido = new NumeroDeveSerValido();
            #endregion

            #region Seção: Validações
            base.Add("CEPDeveSerValido", new Rule<GEEndereco>(CEPDeveSerValido, "CEP deve ser válido", GEEndereco));
            base.Add("CodigoBairroDeveSerMaiorQueZero", new Rule<GEEndereco>(CodigoBairroDeveSerMaiorQueZero, "O endereço deve ter um bairro válido", GEEndereco));
            base.Add("LogradouroDeveSerValido", new Rule<GEEndereco>(LogradouroDeveSerValido, "Logradouro deve ser válido e ter no máximo 100 caracteres", GEEndereco));
            base.Add("StatusDeveSerValido", new Rule<GEEndereco>(StatusDeveSerValido, "Status de ve ser válido", GEEndereco));
            base.Add("NumeroDeveSerValido", new Rule<GEEndereco>(StatusDeveSerValido, "Número de ve ser válido", GEEndereco));
            #endregion
        }
    }
}
