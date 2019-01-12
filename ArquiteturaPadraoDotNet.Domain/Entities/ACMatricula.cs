﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public     class ACMatricula
    {
        [Key]
        public int CoodigoMatricula { get; set; }

        [Required]
        public string CodigoIdentificador { get; private set; }

        #region GEAluno
        [Required]
        public int CodigoAluno { get; set; }

        [ForeignKey("CodigoAluno")]
        public virtual GEAluno GEAluno { get; set; } 
        #endregion
    }
}
