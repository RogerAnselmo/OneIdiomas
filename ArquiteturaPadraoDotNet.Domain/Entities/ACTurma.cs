using One.Domain.Validation;
using One.Domain.Validations.ACTurmaValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace One.Domain.Entities
{
    public class ACTurma
    {
        protected ACTurma()
        {
            flAtivo = "A";
            CodigoIdentificador = DateTime.Now.ToString();
        }

        public ACTurma(int codigoTurma, string descricao, DateTime dataInicio, DateTime dataFim, string horaInicial, string horaFinal, int diasDaSemana, decimal valorBase, int codigoNivel, int codigoProfessor) : this()
        {
            CodigoTurma = codigoTurma;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            ValorBase = valorBase;
            CodigoNivel = codigoNivel;
            CodigoProfessor = codigoProfessor;
            HoraInicio = horaInicial;
            HoraFim = horaFinal;
            DiasDaSemana = diasDaSemana;
        }

        #region ACTurma
        [Key]
        public int CodigoTurma { get; set; }

        [Required]
        [MaxLength(400)]
        public string Descricao { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        [Required]
        public DateTime DataFim { get; set; }

        [Required]
        public string HoraInicio { get; set; }

        [Required]
        public string HoraFim { get; set; }

        [Required]
        public decimal ValorBase { get; set; }

        [Required]
        public int DiasDaSemana { get; set; }

        [Required]
        public string CodigoIdentificador { get; private set; }

        [Required]
        [MaxLength(1)]
        public string flAtivo { get; set; }

        [NotMapped]
        public ValidationResults ValidationResult { get; set; }
        #endregion

        #region ACNivel
        [Required]
        public int CodigoNivel { get; set; }

        public virtual ACNivel ACNivel { get; set; }
        #endregion

        #region ACProfessor
        [Required]
        public int CodigoProfessor { get; set; }

        public virtual ACProfessor ACProfessor { get; set; }
        #endregion

        public bool IsValid()
        {
            ValidationResult = new ACTurmaConsistenteValidation(this).Validate();
            return ValidationResult.IsValid;
        }
    }
}
