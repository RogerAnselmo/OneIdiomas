using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace One.Domain.Entities
{
    public class ACFaixaEtaria
    {
        #region ACFaixaEtaria
        [Key]
        public int CodigoFaixaEtaria { get; set; }

        [Required]
        [MaxLength(30)]
        public string Descricao { get; set; }

        [Required]
        public int IdadeMinima { get; set; }

        [Required]
        public int IdadeMaxima { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

    }
}
