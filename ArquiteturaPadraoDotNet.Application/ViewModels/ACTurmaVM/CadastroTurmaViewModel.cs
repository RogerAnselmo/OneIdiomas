using One.Application.Enums;
using System;
using System.ComponentModel;

namespace One.Application.ViewModels.ACTurmaVM
{
    public class CadastroTurmaViewModel
    {
        [DisplayName("Código da Turma")]
        public int CodigoTurma { get; set; }

        [DisplayName("Professor")]
        public int CodigoProfessor { get; set; }

        [DisplayName("Nível")]
        public int CodigoNivel { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Data de Início")]
        public string DataInicio { get; set; }

        [DisplayName("Data Fim")]
        public string DataFim { get; set; }

        [DisplayName("Hora Início")]
        public string HoraInicio { get; set; }

        [DisplayName("Hora Fim")]
        public string HoraFim { get; set; }

        [DisplayName("Valor Base (R$)")]
        public decimal ValorBase { get; set; }

        [DisplayName("Código Identificador da Turma")]
        public string CodigoIdentificador { get; set; }

        [DisplayName("Dias da Semana")]
        public DiasDaSemana DiasDaSemana { get; set; }
    }
}
