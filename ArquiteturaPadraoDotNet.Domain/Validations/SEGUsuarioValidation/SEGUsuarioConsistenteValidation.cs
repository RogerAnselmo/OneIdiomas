using One.Domain.Entities;
using One.Domain.Specifications.SEGUsuarioSpecification;
using One.Domain.Validation;

namespace One.Domain.Validations.SEGUsuarioValidation
{
    public class SEGUsuarioConsistenteValidation: Validator<SEGUsuario>
    {
        public SEGUsuarioConsistenteValidation(SEGUsuario SEGUsuario)
        {

            #region Seção: Regras
            //Login
            var LoginDeveSerValido = new LoginDeveSerValido();
            var LoginDeveTerNoMaximo100Caracteres = new LoginDeveTerNoMaximo100Caracteres();
            var LoginDeveTerNoMinimo3Caracteres = new LoginDeveTerNoMinimo3Caracteres();

            //Nome
            var NomeDeveSerValido = new NomeDeveSerValido();
            var NomeDeveTerMinimo3Caracteres = new NomeDeveTerMinimo3Caracteres();
            var NomeDeveTerAte200Caracteres = new NomeDeveTerAte200Caracteres();

            //Status
            var DeveTerUmStatusValido = new StatusDeveSerValido();
            #endregion

            #region Seção: Validações
            //Login
            base.Add("LoginDeveSerValido", new Rule<SEGUsuario>(LoginDeveSerValido, "Usuário deve ter um login válido.", SEGUsuario));
            base.Add("LoginDeveTerNoMaximo100Caracteres", new Rule<SEGUsuario>(LoginDeveSerValido, "Login do Usuário deve ter no máximo 100 caracteres.", SEGUsuario));
            base.Add("LoginDeveTerNoMinimo3Caracteres", new Rule<SEGUsuario>(LoginDeveTerNoMinimo3Caracteres, "Login do Usuário deve ter no mínimo 3 caracteres", SEGUsuario));

            //Nome
            base.Add("NomeDeveSerValido", new Rule<SEGUsuario>(NomeDeveSerValido, "Usuário deve ter um nome válido.", SEGUsuario));
            base.Add("NomeDeveTerMinimo3Caracteres", new Rule<SEGUsuario>(NomeDeveTerMinimo3Caracteres, "Nome do usuário deve ter no mínimo 3 caracteres.", SEGUsuario));
            base.Add("NomeDeveTerAte200Caracteres", new Rule<SEGUsuario>(NomeDeveTerAte200Caracteres, "Nome do usuário deve ter no mráximo 200 caracteres.", SEGUsuario));

            //Status
            base.Add("DeveTerUmStatusValido", new Rule<SEGUsuario>(DeveTerUmStatusValido, "Usuário deve ter um status válido", SEGUsuario));
            #endregion
        }
    }
}
