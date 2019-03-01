using One.Domain.Validations.GEEnderecoValidation;
using System.Collections.Generic;
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
        [MaxLength(500)]
        public string Logradouro { get; set; }

        [Required]
        [MaxLength(10)]
        public string Cep { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }

        public Validation.ValidationResult ValidationResult { get; set; }
        #endregion

        #region GEBairro
        [Required]
        public int CodigoBairro { get; set; }

        [ForeignKey("CodigoBairro")]
        public virtual GEBairro GEBairro { get; set; }
        #endregion

        #region GEUsuarioEndereco
        IEnumerable<GEUsuarioEndereco> GEUsuarioEndereco { get; set; }
        #endregion,

        #region Validação
        public bool IsValid()
        {
            ValidationResult = new GEEnderecoConsistenteValidation(this).Validate();
            return ValidationResult.IsValid;
        } 
        #endregion
    }
}
