using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Application.ViewModels
{
    public class GEEnderecoViewModel
    {
        #region GEEnderecoViewModel
        [DisplayName("Código Endereço")]
        public int CodigoEndereco { get; set; }

        [DisplayName("Número")]
        public int Numero { get; set; }

        [DisplayName("Logradouro")]
        public string Logradouro { get; set; }

        [Required]
        [MaxLength(10)]
        public string Cep { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region GEBairroViewModel
        public virtual GEBairroViewModel GEBairroViewModel { get; set; }
        #endregion
    }
}
