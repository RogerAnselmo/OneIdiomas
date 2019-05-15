using One.Domain.Validation;
using One.Domain.Validations.ACProfessorValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
    public class ACProfessor
    {
        #region Construtor
        protected ACProfessor() => flAtivo = "A";

        public ACProfessor(int codigoUsuario, int codigoProfessor, DateTime dataNascimento, string cpf, string rg) : this()
        {
            CodigoUsuario = codigoUsuario;
            CodigoProfessor = codigoProfessor;
            DataNascimento = dataNascimento;
            CPF = cpf;
            RG = rg;
        }
        #endregion

        #region ACProfessor
        [Key]
        public int CodigoProfessor { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string RG { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }

        [NotMapped]
        public ValidationResults ValidationResult { get; set; }
        #endregion

        #region SEGUsuario
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public virtual SEGUsuario SEGUsuario { get; set; }
        #endregion

        #region ACTurma
        public virtual IEnumerable<ACTurma> ACTurma { get; set; }
        #endregion

        #region Validação
        public virtual bool IsValid()
        {
            ValidationResult = new ACProfessorConsistenteValidation(this).Validate();
            return ValidationResult.IsValid;
        }
        #endregion
    }
}
