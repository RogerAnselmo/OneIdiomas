using One.Domain.Validation;
using One.Domain.Validations.GEUsuarioEnderecoValidation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class GEUsuarioEndereco
    {
        #region GEUsuarioEndereco
        [Key]
        public int CodigoUsuarioEndereco { get; set; }

        [NotMapped]
        public ValidationResults ValidationResult { get; set; }
        #endregion

        #region SEGUsuario
        [Required]
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario ")]
        public virtual SEGUsuario SEGUsuario { get; set; }
        #endregion

        #region GEEndereco
        [Required]
        public int CodigoEndereco { get; set; }

        [ForeignKey("CodigoEndereco")]
        public virtual GEEndereco GEEndereco { get; set; }
        #endregion

        #region Validação
        public bool IsValid()
        {
            ValidationResult = new GEUsuarioEnderecoConsistenteValidation(this).Validate();
            return ValidationResult.IsValid;
        } 
        #endregion
    }
}
