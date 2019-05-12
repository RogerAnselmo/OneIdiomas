using System;
using System.ComponentModel;

namespace One.Application.ViewModels.ACTurmaVM
{
    public class CadastroTurmaViewModel
    {
        [DisplayName("Código da Turma")]
        public int CodigoTurma { get; set; }

        [DisplayName("Código do Professor")]
        public int CodigoProfessor { get; set; }

        [DisplayName("Nível")]
        public int CodigoNivel { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Data de Início")]
        public string DataInicio { get; set; }

        [DisplayName("Data Fim")]
        public string DataFim { get; set; }

        [DisplayName("Valor Base (R$)")]
        public decimal ValorBase { get; set; }

        [DisplayName("Código Identificador da Turma")]
        public string CodigoIdentificador { get; set; }
    }
}
