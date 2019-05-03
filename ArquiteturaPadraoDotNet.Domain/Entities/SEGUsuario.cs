using One.Domain.Validations.SEGUsuarioValidation;
using One.Domain.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class SEGUsuario
    {
        #region Construtor
        protected SEGUsuario()
        {
            flAtivo = "A";
            GEUsuarioEndereco = new List<GEUsuarioEndereco>();
            GETelefone = new List<GETelefone>();
            SEGUsuarioPerfil = new List<SEGUsuarioPerfil>();
        }

        public SEGUsuario(int codigoUsuario, string nomeCompleto, string login) : this()
        {
            CodigoUsuario = codigoUsuario;
            NomeCompleto = nomeCompleto;
            Login = login;
        } 
        #endregion

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

        [NotMapped]
        public ValidationResults ValidationResult { get; set; }

        #endregion

        #region SEGUsuarioPerfil
        public virtual IEnumerable<SEGUsuarioPerfil> SEGUsuarioPerfil { get; set; }
        #endregion

        #region GETelefone
        public virtual IEnumerable<GETelefone> GETelefone { get; set; }
        #endregion

        #region GEEndereco
        public virtual IEnumerable<GEUsuarioEndereco> GEUsuarioEndereco { get; set; }
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
