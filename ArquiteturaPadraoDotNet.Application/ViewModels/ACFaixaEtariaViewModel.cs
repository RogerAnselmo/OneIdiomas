using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace One.Application.ViewModels
{
    public class ACFaixaEtariaViewModel
    {
        #region FaixaEtariaViewModel
        [DisplayName("Código Faixa Etária")]
        public int CodigoFaixaEtaria { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Idade Mínima")]
        public int IdadeMinima { get; set; }

        [DisplayName("Idade Máxima")]
        public int IdadeMaxima { get; set; }
        #endregion
    }
}
