using One.Domain.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace One.Application.ViewModels
{
    public class ACResponsavelViewModel
    {
        #region ACResponsavelViewModel
        [DisplayName("Código Responsável")]
        public int CodigoResponsavel { get; set; }

        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("Sexo")]
        public string Sexo { get; set; }

        [DisplayName("Data Nascimento")]
        public string DataNascimento { get; set; }

        [DisplayName("Status")]
        public string flAtivo { get; set; }

        [DisplayName("Idade")]
        public int Idade { get; set; }

        public ValidationResults ValidationResult { get; set; }
        #endregion

        #region SEGUsuarioViewModel
        [DisplayName("Código Usuário")]
        public int CodigoUsuario { get; set; }

        public virtual SEGUsuarioViewModel SEGUsuario { get; set; }
        #endregion

        #region ACAlunoResponsavel
        public virtual IEnumerable<ACAlunoResponsavelViewModel> ACAlunoResponsavel { get; set; }
        #endregion

    }
}
