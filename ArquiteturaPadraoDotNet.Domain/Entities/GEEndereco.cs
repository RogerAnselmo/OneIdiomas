using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class GEEndereco
    {
        #region GEEndereco
        [Key]
        public int CodigoEndereco { get; set; }

        public int Numero { get; set; }

        [Required]
        [MaxLength(300)]
        public string Logradouro { get; set; }

        [Required]
        [MaxLength(10)]
        public string Cep { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region GEBairro
        [Required]
        public int CodigoBairro { get; set; }

        [ForeignKey("CodigoBairro")]
        public virtual GEBairro GEBairro { get; set; }
        #endregion

        #region SEGUsuario
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public virtual SEGUsuario SEGUsuario { get; set; }
        #endregion
    }
}
