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
        [MaxLength(200)]
        public string NomeCompleto { get; set; }

        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Login { get; set; }

        [MaxLength(11)]
        public string CPF { get; set; }

        [MaxLength(1)]
        public string Sexo { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }
        #endregion

        #region SEGUsuarioPerfil
        public virtual IEnumerable<SEGUsuarioPerfil> SEGUsuarioPerfis { get; set; }
        #endregion
    }
}
