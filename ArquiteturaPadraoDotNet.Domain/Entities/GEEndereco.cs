using One.Domain.Validation;
using One.Domain.Validations.GEEnderecoValidation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace One.Domain.Entities
{
    public class GEEndereco
    {
        protected GEEndereco() {
            flAtivo = "A";
            GEUsuarioEndereco = new List<GEUsuarioEndereco>();
        }

        public GEEndereco(int codigoEndereco, int codigoBairro, string logradouro, string numero, string cep) : this()
        {
            CodigoEndereco = codigoEndereco;
            CodigoBairro = codigoBairro;
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
        }

        #region GEEndereco
        [Key]
        public int CodigoEndereco { get; set; }

        public string Numero { get; set; }

        [Required]
        [MaxLength(500)]
        public string Logradouro { get; set; }

        [Required]
        [MaxLength(10)]
        public string Cep { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }

        [NotMapped]
        public ValidationResults ValidationResult { get; set; }
        #endregion

        #region GEBairro
        [Required]
        public int CodigoBairro { get; set; }

        [ForeignKey("CodigoBairro")]
        public virtual GEBairro GEBairro { get; set; }
        #endregion

        #region GEUsuarioEndereco
        public virtual IEnumerable<GEUsuarioEndereco> GEUsuarioEndereco { get; set; }
        #endregion,

        #region Validação
        public bool IsValid()
        {
            ValidationResult = new GEEnderecoConsistenteValidation(this).Validate();
            return ValidationResult.IsValid;
        } 
        #endregion

        public void VincularUsuarioEndereco(SEGUsuario SEGUsuario)
        {
            var usuarioEndereco = new GEUsuarioEndereco(SEGUsuario.CodigoUsuario, CodigoEndereco);
            GEUsuarioEndereco.ToList().Add(usuarioEndereco);
        }
    }
}