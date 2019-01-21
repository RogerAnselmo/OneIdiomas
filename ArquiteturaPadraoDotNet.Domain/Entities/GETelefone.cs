using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class GETelefone
    {
        #region GETelefone
        [Key]
        public int CodigoTelefone { get; set; }

        [Required]
        [MaxLength(20)]
        public string NumeroTelefone { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region GETipoTelefone
        [Required]
        public int CodigoTipoTelefone { get; set; }

        [ForeignKey("CodigoTipoTelefone")]
        public virtual GETipoTelefone TipoTelefone { get; set; }
        #endregion

        #region SEGUsuario
        [Required]
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public virtual SEGUsuario SEGUsuario { get; set; }
        #endregion
    }
}
