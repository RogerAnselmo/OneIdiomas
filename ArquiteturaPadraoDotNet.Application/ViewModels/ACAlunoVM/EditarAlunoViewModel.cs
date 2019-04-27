using System.ComponentModel;

namespace One.Application.ViewModels.ACAlunoVM
{
    public class EditarAlunoViewModel
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
        public int Numero{ get; set; }
        #endregion
    }
}
