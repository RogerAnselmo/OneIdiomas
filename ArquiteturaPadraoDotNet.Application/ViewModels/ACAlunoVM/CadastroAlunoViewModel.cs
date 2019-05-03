using One.Domain.Validation;
using System.ComponentModel;

namespace One.Application.ViewModels.ACAlunoVM
{
    public class CadastroAlunoViewModel
    {
        #region Seção: Dados do Aluno
        [DisplayName("Código Usuário")]
        public int CodigoUsuario { get; set; }

        [DisplayName("Código Aluno")]
        public int CodigoAluno { get; set; }

        [DisplayName("Nome Completo")]
        public string NomeCompleto { get; set; }

        [DisplayName("Nascimento")]
        public string DataNascimento { get; set; }

        [DisplayName("Idade")]
        public int Idade { get; set; }

        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("Vencimento")]
        public int DiaVencimento { get; set; }
        #endregion

        #region Seção: Endereço do Aluno
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
        public int NumeroAluno { get; set; }
        #endregion

        #region Seção: Dados do Responsável
        [DisplayName("Código Responsável")]
        public int CodigoResponsavel { get; set; }

        [DisplayName("Nome Completo")]
        public string NomeCompletoResponsavel { get; set; }

        [DisplayName("Nascimento")]
        public string DataNascimentoResponsavel { get; set; }

        [DisplayName("Idade")]
        public int IdadeResponsavel { get; set; }

        [DisplayName("Parentesco")]
        public int CodigoParentesco { get; set; }

        [DisplayName("CPF")]
        public string CPFResponsavel { get; set; }

        [DisplayName("RG")]
        public string RGResponsavel { get; set; }

        [DisplayName("Telefone")]
        public string TelefoneResponsavel { get; set; }
        #endregion

        #region Seção: Endereço do Responsável
        [DisplayName("Código Endereço")]
        public int CodigoEnderecoResponsavel { get; set; }

        [DisplayName("CEP")]
        public string CEPResponsavel { get; set; }

        [DisplayName("Estado")]
        public int CodigoUFResponsavel { get; set; }

        [DisplayName("Cidade")]
        public int CodigoCidadeResponsavel { get; set; }

        [DisplayName("Bairro")]
        public int CodigoBairroResponsavel { get; set; }

        [DisplayName("Logradouro")]
        public string LogradouroResponsavel { get; set; }

        [DisplayName("Número")]
        public int Numero { get; set; }
        #endregion

        #region Seção: Booleanos
        [DisplayName("Aluno é o próprio Responsável")]
        public bool AlunoÉOProprioResponsavel { get; set; }

        [DisplayName("Usar endereço do Resposável")]
        public bool UsarEnderecoDoResponsavel { get; set; }
        #endregion

        public ValidationResults ValidationResult { get; set; }
    }
}
