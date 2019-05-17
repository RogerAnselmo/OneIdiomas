using System.ComponentModel;

namespace One.Application.ViewModels.ACResponsavelVM
{
    public class FormResponsavelViewModel
    {
        #region Seção: Dados do Responsável
        [DisplayName("Código Usuário")]
        public int CodigoUsuarioResponsavel { get; set; }

        [DisplayName("Código Responsável")]
        public int CodigoResponsavel { get; set; }

        [DisplayName("Nome do Responsável")]
        public string NomeResponsavel { get; set; }

        [DisplayName("Nascimento")]
        public string DataNascimentoResponsavel { get; set; }

        [DisplayName("Idade")]
        public int IdadeResponsavel { get; set; }

        [DisplayName("RG")]
        public string RGResponsavel { get; set; }

        [DisplayName("CPF")]
        public string CPFResponsavel { get; set; }

        [DisplayName("Parentesco")]
        public int CodigoParentesco { get; set; }
        #endregion

        #region Seção: Endereço do Responsável
        [DisplayName("Código Endereço")]
        public int CodigoEnderecoResponsavel { get; set; }

        [DisplayName("Estado")]
        public int CodigoUFResponsavel { get; set; }

        [DisplayName("Cidade")]
        public int CodigoCidadeResponsavel { get; set; }

        [DisplayName("Bairro")]
        public int CodigoBairroResponsavel { get; set; }

        [DisplayName("Logradouro")]
        public string LogradouroResponsavel { get; set; }

        [DisplayName("Número")]
        public string NumeroResponsavel { get; set; }
        #endregion

        #region Seção: Telefone do Responsável
        [DisplayName("CodigoTelefone")]
        public int CodigoTelefoneResponsavel { get; set; }

        [DisplayName("Telefone")]
        public string TelefoneResponsavel { get; set; } 
        #endregion
    }
}
