using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace One.Application.ViewModels
{
    public class ACEstagioViewModel
    {
        #region ACEstagioViewModel
        [DisplayName("Código Estágio")]
        public int CodigoEstagio { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        #endregion
    }
}
