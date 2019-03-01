using One.Domain.Validations.ACAlunoResponsavelValidation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class ACAlunoResponsavel
    {
        #region ACAlunoResponsavel
        [Key]
        public int CodigoAlunoResponsavel { get; set; }

        [NotMapped]
        public Validation.ValidationResult ValidationResult { get; set; }
        #endregion

        #region ACAluno
        [Required]
        public int CodigoAluno { get; set; }

        [ForeignKey("CodigoAluno")]
        public virtual ACAluno ACAluno { get; set; }
        #endregion

        #region ACResponsavel
        [Required]
        public int CodigoResponsavel { get; set; }

        [ForeignKey("CodigoResponsavel")]
        public virtual ACResponsavel ACResponsavel { get; set; }
        #endregion

        #region GEParentesco
        [Required]
        public int CodigoParentesco { get; set; }

        [ForeignKey("CodigoParentesco")]
        public virtual GEParentesco GEParentesco { get; set; }
        #endregion

        #region Validação
        public bool IsValid()
        {
            ValidationResult = new ACAlunoResponsavelConsistenteValidation(this).Validate();
            return ValidationResult.IsValid;
        } 
        #endregion
    }
}
