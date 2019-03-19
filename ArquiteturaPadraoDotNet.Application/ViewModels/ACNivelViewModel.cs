using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace One.Application.ViewModels
{
    public class ACNivelViewModel
    {
        #region ACNivelViewModel
        [DisplayName("Código Nível")]
        public int CodigoNivel { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        #endregion
    }
}
