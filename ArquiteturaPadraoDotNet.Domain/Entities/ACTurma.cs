using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace One.Domain.Entities
{
    public class ACTurma
    {
        #region ACTurma
        [Key]
        public int CodigoTurma { get; set; }

        [Required]
        [MaxLength(100)]
        public string Descricao { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        [Required]
        public DateTime DataFim { get; set; } 

        [Required]
        public decimal ValorBase { get; set; }

        [Required]
        public string CodigoIdentificador { get; private set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region ACNivel
        [Required]
        public int CodigoNivel { get; set; }

        public virtual ACNivel ACNivel { get; set; }
        #endregion

        #region ACProfessor
        [Required]
        public int CodigoProfessor { get; set; }

        public virtual ACProfessor ACProfessor { get; set; } 
        #endregion
    }
}
