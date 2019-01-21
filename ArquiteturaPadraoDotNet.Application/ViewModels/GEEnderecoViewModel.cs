using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        #region GEBairro
        [Required]
        public int CodigoBairro { get; set; }

        [ForeignKey("CodigoBairro")]
        public virtual GEBairro GEBairro { get; set; }
        #endregion
    }
}
