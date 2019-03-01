using One.Domain.Validations.SEGUsuarioValidation;
using One.Domain.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace One.Domain.Entities
{
    public class SEGUsuario
    {
        #region SEGUsuario
        [Key]
        public int CodigoUsuario { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(200)]
        public string NomeCompleto { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Login { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }

        public Validation.ValidationResult ValidationResult { get; set; }

        #endregion

        #region SEGUsuarioPerfil
        public virtual IEnumerable<SEGUsuarioPerfil> SEGUsuarioPerfis { get; set; }
        #endregion

        #region GETelefone
        public virtual IEnumerable<GETelefone> GETelefone { get; set; }
        #endregion

        #region GEEndereco
        public virtual GEEndereco GEEndereco { get; set; }
        #endregion

        #region Validação
        public bool IsValid()
        {
            ValidationResult = new SEGUsuarioConsistenteValidation(this).Validate();
            return ValidationResult.IsValid;
        }
        #endregion
    }
}
