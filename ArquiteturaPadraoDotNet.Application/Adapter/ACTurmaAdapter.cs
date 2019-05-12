﻿using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Application.ViewModels.ACTurmaVM;
using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Application.Adapter
{
    public static class ACTurmaAdapter
    {
        public static ACTurma ExtractACTurma(CadastroTurmaViewModel cadastroTurmaViewModel)
            => new ACTurma(cadastroTurmaViewModel.CodigoTurma,
                           cadastroTurmaViewModel.Descricao,
                           Convert.ToDateTime(cadastroTurmaViewModel.DataInicio),
                           Convert.ToDateTime(cadastroTurmaViewModel.DataFim),
                           cadastroTurmaViewModel.ValorBase,
                           cadastroTurmaViewModel.CodigoNivel,
                           cadastroTurmaViewModel.CodigoProfessor);

        public static CadastroTurmaViewModel ConvertToCadastroTurmaViewModel(ACTurma aCTurma) => new CadastroTurmaViewModel
        {
            CodigoIdentificador = aCTurma.CodigoIdentificador,
            CodigoNivel = aCTurma.CodigoNivel,
            CodigoProfessor = aCTurma.CodigoProfessor,
            CodigoTurma = aCTurma.CodigoTurma,
            DataFim = aCTurma.DataFim.ToShortDateString(),
            DataInicio = aCTurma.DataInicio.ToShortDateString(),
            Descricao = aCTurma.Descricao,
            ValorBase = aCTurma.ValorBase
        };


        public static ACTurmaViewModel DomainToViewModel(ACTurma domain)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<ACTurmaViewModel> DomainToViewModel(IEnumerable<ACTurma> listaDomain)
        {
            throw new NotImplementedException();
        }

        public static ACTurma ViewModelToDomain(ACTurmaViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<ACTurma> ViewModelToDomain(IEnumerable<ACTurmaViewModel> listaViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
