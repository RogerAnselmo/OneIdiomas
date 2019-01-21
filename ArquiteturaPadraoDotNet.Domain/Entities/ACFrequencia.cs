using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class ACFrequencia
    {
        #region ACFrequencia
        [Key]
        public int Codigofrequencia { get; set; }

        [Required]
        [MaxLength(1)]
        public string flSituacao { get; set; }

        [Required]
        public DateTime DataFrequencia { get; set; }

        [MaxLength(500)]
        public string Observacao { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region ACMatricula
        [Required]
        public int CodigoMatricula { get; set; }

        [ForeignKey("CodigoMatricula")]
        public virtual ACMatricula ACMatricula { get; set; }
        #endregion
    }
}
