using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace One.Application.ViewModels
{
    public class GEUFViewModel
    {
        #region GEUFViewModel
        [DisplayName("Código UF")]
        public int CodigoUF { get; set; }

        [DisplayName("Estado")]
        public string Descricao { get; set; }

        [DisplayName("Sigla")]
        public string Sigla { get; set; }
        #endregion

        #region GECidade
        public IEnumerable<GECidadeViewModel> GECidadeViewModel { get; set; }
        #endregion
    }
}
