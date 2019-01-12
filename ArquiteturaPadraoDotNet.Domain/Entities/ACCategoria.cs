using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
    public class ACCategoria
    {
        #region ACCategoria
        [Key]
        public int CodigoCategoria { get; set; }

        [Required]
        [MaxLength(30)]
        public string DescricaoCategoria { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region ACFaixaEtaria
        public int CodigoFaixaEtaria { get; set; }

        [ForeignKey("CodigoFaixaEtaria")]
        public ACFaixaEtaria ACFaixaEtaria { get; set; } 
        #endregion
    }
}
