using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace One.Application.ViewModels
{
    public class AlunoViewModel
    {
        #region Aluno
        [DisplayName("Codigo Aluno")]
        public int CodigoALuno { get; set; }

        [DisplayName("Nome Completo")]
        public string NomeCompleto { get; set; }

        [DisplayName("Telefone: ")]
        public string Telefone { get; set; }

        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("Ativo")]
        public string flAtivo { get; set; }

        [DisplayName("Dis do Vencimento")]
        public int DiaVencimento { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Idade")]
        public int Idade { get; set; }
        #endregion

        #region ACResponsavelViewModel
        public ACResponsavelViewModel ACResponsavelViewModel { get; set; } 
        #endregion
    }
}
