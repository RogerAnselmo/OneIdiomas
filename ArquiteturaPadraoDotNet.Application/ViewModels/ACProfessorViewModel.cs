using System;
using System.ComponentModel;

namespace One.Application.ViewModels
{
    public class ACProfessorViewModel
    {
        #region ACProfessorViewModel
        [DisplayName("Código do Professor")]
        public int CodigoProfessor { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Código do Professor")]
        public string CPF { get; set; }
        #endregion
    }
}
