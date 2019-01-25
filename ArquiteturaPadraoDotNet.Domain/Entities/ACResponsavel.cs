using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
    public class ACResponsavel
    {
        #region ACResponsavel
        [Key]
        public int CodigoResponsavel { get; set; }

        [Required]
        [MaxLength(200)]
        public string NomeCompleto { get; set; }

        [MaxLength(20)]
        public string RG { get; set; }

        [MaxLength(11)]
        public string CPF { get; set; }

        [MaxLength(1)]
        public string Sexo { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; } 
        #endregion

        #region GEEndereco
        [Required]
        public int CodigoEndereco { get; set; }

        [ForeignKey("CodigoEndereco")]
        public virtual GEEndereco GEEndereco { get; set; }
        #endregion

        #region SEGUsuario
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public virtual SEGUsuario SEGUsuario { get; set; }
        #endregion

        #region GETelefone
        public IEnumerable<GETelefone> GETelefones { get; set; }
        #endregion

        #region ACAlunoResponsavel
        public virtual IEnumerable<ACAlunoResponsavel> ACAlunoResponsavel { get; set; }
        #endregion
    }
}
