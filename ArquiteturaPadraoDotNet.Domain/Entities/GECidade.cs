using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
    public class GECidade
    {
        #region GECidade
        [Key]
        public int CodigoCidade { get; set; }

        [Required]
        [MaxLength(50)]
        public string Descricao { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region GEUF
        [ForeignKey("CodigoUF")]
        public int CodigoUF { get; set; }
        public virtual GEUF GEUF { get; set; } 
        #endregion
    }
}
