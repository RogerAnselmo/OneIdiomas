using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
    public class ACProfessor
    {
        #region ACProfessor
        [Key]
        public int CodigoProfessor { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region SEGUsuario
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public virtual SEGUsuario SEGUsuario { get; set; }
        #endregion

        #region ACTurma
        public virtual IEnumerable<ACTurma> ACTurma { get; set; } 
        #endregion
    }
}
