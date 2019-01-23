using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace One.Application.ViewModels
{
    public class GECidadeViewModel
    {
        #region GECidadeViewModel
        [DisplayName("Código da Cidade")]
        public int CodigoCidade { get; set; }

        [DisplayName("Cidade")]
        public string Descricao { get; set; }
        #endregion

        #region GEUFViewModel
        public GEUFViewModel GEUFViewModel { get; set; }
        #endregion
    }
}
