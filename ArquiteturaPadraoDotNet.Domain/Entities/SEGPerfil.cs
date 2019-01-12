using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace One.Domain.Entities
{
    public class SEGPerfil
    {
        #region SEGPerfil
        [Key]
        public int CoigoPerfil { get; set; }

        [Required]
        [MaxLength(30)]
        public string Descricao { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region SEGUsuarioPerfil
        public virtual IEnumerable<SEGUsuarioPerfil> SEGUsuarioPerfis { get; set; }
        #endregion
    }
}
