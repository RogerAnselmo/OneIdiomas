using System;
using System.ComponentModel;

namespace One.Application.ViewModels
{
    public class ACProfessorViewModel
    {
        #region ACProfessorViewModel
        [DisplayName("Código do usuário")]
        public int CodigoUsuario { get; set; }

        [DisplayName("Nome Completo")]
        public string NomeCompleto { get; set; }

        [DisplayName("Código do Professor")]
        public int CodigoProfessor { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("CPF do Professor")]
        public string CPF { get; set; }

        [DisplayName("RG do Professor")]
        public string RG { get; set; }
        #endregion
    }
}
