using One.Domain.Validation;
using One.Domain.Validations.GETelefoneValidation;
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

        [NotMapped]
        public ValidationResults ValidationResult { get; set; }
        #endregion

        #region GETipoTelefone
        [Required]
        public int CodigoTipoTelefone { get; set; }

        [ForeignKey("CodigoTipoTelefone")]
        public virtual GETipoTelefone GETipoTelefone { get; set; }
        #endregion

        #region SEGUsuario
        [Required]
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public virtual SEGUsuario SEGUsuario { get; set; }
        #endregion

        #region Seção: Validação
        public bool IsValid()
        {
            ValidationResult = new GETelefoneConsistenteValidation(this).Validate();
            return ValidationResult.IsValid;
        } 
        #endregion
    }
}
