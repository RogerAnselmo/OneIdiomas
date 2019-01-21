﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class ACMatricula
    {
        #region ACMatricula
        [Key]
        public int CodigoMatricula { get; set; }

        [Required]
        public string CodigoIdentificador { get; private set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }

        #endregion

        #region ACAluno
        [Required]
        public int CodigoAluno { get; set; }

        [ForeignKey("CodigoAluno")]
        public virtual ACAluno ACAluno { get; set; }
        #endregion

        #region ACTurma
        public int CodigoTurma { get; set; }

        [ForeignKey("CodigoTurma")]
        public ACTurma ACTurma { get; set; }
        #endregion

        #region ACFrequencia
        public virtual IEnumerable<ACFrequencia> ACFrequencia { get; set; }
        #endregion

        #region ACAvaliacao
        public virtual IEnumerable<ACAvaliacao> ACAvaliacao { get; set; }
        #endregion
    }
}
