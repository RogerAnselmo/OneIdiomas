using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace One.Application.ViewModels
{
    public class GEBairroViewModel
    {
        #region GEBairroViewModel
        [DisplayName("Código do Bairro: ")]
        public int CodigoBairro { get; set; }

        [DisplayName("Bairro: ")]
        public int Descricao { get; set; }
        #endregion

        #region GECidadeViewModel
        public GECidadeViewModel GECidadeViewModel { get; set; } 
        #endregion
    }
}
