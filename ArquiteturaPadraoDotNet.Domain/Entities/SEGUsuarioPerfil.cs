using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
    public class SEGUsuarioPerfil
    {
        #region SEGUsuarioPerfil
        [Key]
        public int CodigoUsuarioPerfil { get; set; }

        public int CodigoPerfilPadrao { get; set; } 
        #endregion

        #region SEGUsuario
        [Required]
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public SEGUsuario SEGUsuario { get; set; }
        #endregion

        #region SEGPerfil
        [Required]
        public int CodigoPerfil { get; set; }

        [ForeignKey("CodigoPerfil")]
        public SEGPerfil SEGPerfil { get; set; }
        #endregion
    }
}
