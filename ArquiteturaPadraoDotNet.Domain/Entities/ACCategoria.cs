using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace One.Domain.Entities
{
    public class ACCategoria
    {
        #region ACCategoria
        [Key]
        [Required]
        public int CodigoCategoria { get; set; }

        [Required]
        [MaxLength(50)]
        public string DescicaoCategoria { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region ACNivel
        public IEnumerable<ACNivel> ACNivel { get; set; } 
        #endregion
    }
}
