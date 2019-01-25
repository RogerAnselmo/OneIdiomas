using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace One.Application.ViewModels
{
    public class SEGUsuarioViewModel
    {
        [DisplayName("CodigoUsuario do Usuário")]
        public int CodigoUsuario { get; set; }

        [DisplayName("Nome Completo")]
        public string NomeCompleto { get; set; }

        [DisplayName("Login")]
        public string Login { get; set; }

        [DisplayName("Login")]
        public string Email { get; set; }

        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("Sexo")]
        public string Sexo { get; set; }

        [DisplayName("Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        #region Scaffold(false)
        [ScaffoldColumn(false)]
        public string flAtivo { get; set; }

        [DisplayName("Senha: ")]
        public string Senha { get; set; }

        [DisplayName("Confirmação de Senha: ")]
        public string ConfirmacaoSenha { get; set; }

        [ScaffoldColumn(false)]
        public string Mensagem { get; set; }

        [ScaffoldColumn(false)]
        public bool Autenticado { get; set; }
        #endregion

        public IList<SEGPerfilViewModel> SEGPerfilViewModel { get; set; }
    }
}
