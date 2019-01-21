using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace One.Domain.Entities
{
    public class GEParentesco
    {
        #region GEParentesco
        [Key]
        public int CodigoParentesco { get; set; }

        [Required]
        [MaxLength(60)]
        public string Descricao { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; } 
        #endregion
    }
}
