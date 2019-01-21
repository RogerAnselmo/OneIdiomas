using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class GEBairro
    {
        #region ACEstagio
        [Key]
        public int CodigoBairro { get; set; }

        [Required]
        [MaxLength(50)]
        public string descricao { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region GECidade
        [Required]
        public int CodigoCidade { get; set; }

        [ForeignKey("CodigoCidade")]
        public virtual GECidade GECidade { get; set; } 
        #endregion
    }
}
