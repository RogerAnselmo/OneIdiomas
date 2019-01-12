using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class GEAluno
    {
        #region GEAluno
        [Key]
        public int CodigoALuno { get; set; }

        [Required]
        [MaxLength(200)]
        public string NomeCompleto { get; set; }

        [Required]
        [MaxLength(1)]
        public string Sexo { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; } 
        #endregion

        #region GEEndereco
        [Required]
        public int CodigoEndereco { get; set; }

        [ForeignKey("CodigoEndereco")]
        public virtual GEEndereco GEEndereco { get; set; } 
        #endregion

        #region GEResponsavel
        [Required]
        public int CodigoResponsavel { get; set; }

        [ForeignKey("CodigoResponsavel")]
        public virtual GEResponsavel GEResponsavel { get; set; }
        #endregion

        #region SEGUsuario
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public virtual SEGUsuario SEGUsuario { get; set; } 
        #endregion

        public int Idade() {
            int idade = DateTime.Now.Year - DataNascimento.Year;

            if (DateTime.Now.Month < DataNascimento.Month || 
                (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))
                idade--;

            return idade;
        }

    }
}
