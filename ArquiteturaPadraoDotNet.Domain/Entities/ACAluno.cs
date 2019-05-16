using One.Domain.Validation;
using One.Domain.Validations.ACAlunoValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class ACAluno
    {
        #region Construtor
        protected ACAluno()
        {
            ACResponsavel = new List<ACResponsavel>();
            flAtivo = "A";
        }

        public ACAluno(int codigoAluno, int codigoUsuario, string rg, string cpf, DateTime dataNascimento, int diaVencimento) : this()
        {
            CodigoAluno = codigoAluno;
            CodigoUsuario = codigoUsuario;
            RG = rg;
            CPF = cpf;
            DataNascimento = dataNascimento;
            DiaVencimento = diaVencimento;
        } 
        #endregion

        #region ACAluno
        [Key]
        public int CodigoAluno { get; set; }

        [MaxLength(20)]
        public string RG { get; set; }

        [MaxLength(11)]
        public string CPF { get; set; }

        [MaxLength(1)]
        public string Sexo { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public int DiaVencimento { get; set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }

        [NotMapped]
        public ValidationResults ValidationResult { get; set; }
        #endregion

        #region ACResponsavel
        public virtual IEnumerable<ACResponsavel> ACResponsavel { get; set; }
        #endregion

        #region SEGUsuario
        [Required]
        public int CodigoUsuario { get; set; }

        [ForeignKey("CodigoUsuario")]
        public virtual SEGUsuario SEGUsuario { get; set; }
        #endregion        

        #region ACMatricula
        public virtual IEnumerable<ACMatricula> ACMatricula { get; set; }
        #endregion

        #region Validação
        public virtual bool IsValid()
        {
            ValidationResult = new ACAlunoConsistenteValidation(this).Validate();
            return ValidationResult.IsValid;
        }
        #endregion

        #region Métodos Inteligentes
        public int Idade(DateTime dataAtual) 
            => new DateTime(dataAtual.Subtract(DataNascimento).Ticks).Year;
        #endregion
    }
}
