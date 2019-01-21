using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
    public class FIMensalidade
    {
        #region FIMensalidade
        [Key]
        public int CodigoMensalidade { get; set; }

        [Required]
        public int NumeroParcela { get; set; }

        [Required]
        public DateTime DataVencimento { get; set; }

        [Required]
        public DateTime DataPagamento { get; set; }

        [Required]
        public DateTime DataEmissao { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public int MesCompetencia { get; set; }

        [Required]
        public int AnoCompetencia { get; set; }

        [Required]
        [MaxLength(1)]
        public string flSituacao { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region ACMatricula
        [Required]
        public int CodigoMatricula { get; set; }

        [ForeignKey("CodigoMatricula")]
        public ACMatricula ACMatricula { get; set; } 
        #endregion
    }
}
