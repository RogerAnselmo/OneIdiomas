using One.Domain.Validation;
using One.Domain.Validations.ACAvaliacaoValidation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class ACAvaliacao
    {
        #region ACAvaliacao
        [Key]
        public int CodigoAvaliacao { get; set; }

        [Required]
        [MaxLength(500)]
        public string Descricao { get; set; }

        [Required]
        public DateTime DataAvaliacao { get; set; }

        [Required]
        [MaxLength(1)]
        public string flSituacao { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }

        [Required]
        public decimal NotaAvaliacao { get; set; }

        [NotMapped]
        public ValidationResults ValidationResult { get; set; }
        #endregion

        #region ACMatricula
        [Required]
        public int CodigoMatricula { get; set; }

        [ForeignKey("CodigoMatricula")]
        public virtual ACMatricula ACMatricula { get; set; }
        #endregion

        public bool IsValid()
        {
            ValidationResult = new ACAvaliacaoConsistenteValidation(this).Validate();
            return ValidationResult.IsValid;
        }
    }
}
