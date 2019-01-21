using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace One.Domain.Entities
{
    public class GEUF
    {
        #region GEUF
        [Key]
        public int CodigoUF { get; set; }

        [Required]
        [MaxLength(30)]
        public string Descricao { get; set; }

        [Required]
        [MaxLength(2)]
        public string Sigla { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; } 
        #endregion

        #region GECidade
        public virtual IEnumerable<GECidade> GECidade { get; set; } 
        #endregion
    }
}
