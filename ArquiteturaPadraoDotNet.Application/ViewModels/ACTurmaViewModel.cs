﻿using System;
using System.ComponentModel;

namespace One.Application.ViewModels
{
    public class ACTurmaViewModel
    {
        #region ACTurmaViewModel
        [DisplayName("Código da Turma")]
        public int CodigoTurma { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Data de Início")]
        public DateTime DataInicio { get; set; }

        [DisplayName("Data Fim")]
        public DateTime DataFim { get; set; }

        [DisplayName("Valor Base")]
        public decimal ValorBase { get; set; }

        [DisplayName("Código Identificador da Turma")]
        public string CodigoIdentificador { get; private set; }
        #endregion

        #region ACEstagioViewModel
        [DisplayName("Código do Estágio")]
        public int CodigoEstagio { get; set; }

        public ACEstagioViewModel ACEstagioViewModel { get; set; }
        #endregion

        #region ACProfessorViewModel
        [DisplayName("Código do Professor")]
        public int CodigoProfessor { get; set; }

        public ACProfessorViewModel ACProfessorViewModel { get; set; }
        #endregion
    }
}