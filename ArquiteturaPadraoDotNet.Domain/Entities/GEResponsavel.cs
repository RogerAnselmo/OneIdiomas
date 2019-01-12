using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
    public class GEResponsavel
    {
        #region GEResponsavel
        [Key]
        public int CodigoResponsavel { get; set; }

        [Required]
        [MaxLength(11)]
        public string CPF { get; set; }

        [Required]
        [MaxLength(300)]
        public string NomeCompleto { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; } 
        #endregion

        #region GEEndereco
        [Required]
        public int CodigoEndereco { get; set; }

        [ForeignKey("CodigoEndereco")]
        public virtual GEEndereco GEEndereco { get; set; }
        #endregion

        #region SEGUsuario
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public virtual SEGUsuario SEGUsuario { get; set; }
        #endregion
    }
}
