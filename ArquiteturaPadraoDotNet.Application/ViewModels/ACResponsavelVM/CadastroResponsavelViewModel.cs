using System.ComponentModel;

namespace One.Application.ViewModels.ACResponsavelVM
{
    public class CadastroResponsavelViewModel
    {
        #region Seção: Dados do Responsável
        [DisplayName("Código Usuário")]
        public int CodigoUsuario { get; set; }

        [DisplayName("Código Responsável")]
        public int CodigoResponsavel { get; set; }

        [DisplayName("Nome Completo")]
        public string NomeCompleto { get; set; }

        [DisplayName("Nascimento")]
        public string DataNascimento { get; set; }

        [DisplayName("Idade")]
        public int Idade { get; set; }

        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }
        #endregion

        #region Seção: Endereço do Responsável
        [DisplayName("Código Endereço")]
        public int CodigoEndereco { get; set; }

        [DisplayName("Estado")]
        public int CodigoUF { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("Cidade")]
        public int CodigoCidade { get; set; }

        [DisplayName("Bairro")]
        public int CodigoBairro { get; set; }

        [DisplayName("Logradouro")]
        public string Logradouro { get; set; }

        [DisplayName("Número")]
        public int Numero { get; set; }
        #endregion

        #region Seção: Telefone do Responsável
        [DisplayName("CodigoTelefone")]
        public int CodigoTelefone { get; set; }

        [DisplayName("Telefone")]
        public string Telefone { get; set; } 
        #endregion
    }
}
