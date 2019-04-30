using One.Domain.Validation;
using One.Domain.Validations.ACResponsavelValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class ACResponsavel
    {
        #region ACResponsavel
        [Key]
        public int CodigoResponsavel { get; set; }
        
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

        [NotMapped]
        public ValidationResults ValidationResult { get; set; }
        #endregion

        #region SEGUsuario
        [Required]
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public virtual SEGUsuario SEGUsuario { get; set; }
        #endregion
        
        #region ACAlunoResponsavel
        public virtual IEnumerable<ACAlunoResponsavel> ACAlunoResponsavel { get; set; }
        #endregion

        #region Validação
        public bool IsValid()
        {
            ValidationResult = new ACResponsavelConsistenteValidation(this).Validate();
            return ValidationResult.IsValid;
        } 
        #endregion

        #region Métodos Inteligentes
        public int Idade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;

            if (DateTime.Now.Month < DataNascimento.Month ||
                (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))
                idade--;

            return idade;
        }
        #endregion
    }
}
