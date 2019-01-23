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
        #endregion

        #region GEEnderecoViewModel
        public virtual GEEnderecoViewModel GEEnderecoViewModel { get; set; }
        #endregion

        #region GEEnderecoViewModel
        public virtual SEGUsuarioViewModel SEGUsuarioViewModel { get; set; }
        #endregion

        #region GEEnderecoViewModel
        public IEnumerable<GETelefoneViewModel> GETelefoneViewModel { get; set; }
        #endregion
    }
}
