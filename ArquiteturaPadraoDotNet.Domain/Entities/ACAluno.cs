using One.Domain.Validations.ACAlunoValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One.Domain.Entities
{
    public class ACAluno
    {
        #region ACAluno
        [Key]
        public int CodigoAluno { get; set; }

        //[Required]
        //[MaxLength(200)]
        //public string NomeCompleto { get; set; }

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
        public Validation.ValidationResult ValidationResult { get; set; }
        #endregion

        #region ACAlunoResponsavel
        public virtual IEnumerable<ACAlunoResponsavel> ACAlunoResponsavel { get; set; }
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
        public bool IsValid()
        {
            ValidationResult = new ACAlunoConsistenteValidation(this).Validate();
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
