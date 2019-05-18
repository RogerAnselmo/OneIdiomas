using One.Application.Enums;
using One.Application.ViewModels;
using One.Application.ViewModels.ACTurmaVM;
using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Application.Adapter
{
    public static class ACTurmaAdapter
    {
        public static ACTurma ExtractACTurma(CadastroTurmaViewModel cadastroTurmaViewModel)
            => new ACTurma(cadastroTurmaViewModel.CodigoTurma,
                           cadastroTurmaViewModel.Descricao,
                           Convert.ToDateTime(cadastroTurmaViewModel.DataInicio),
                           Convert.ToDateTime(cadastroTurmaViewModel.DataFim),
                           cadastroTurmaViewModel.HoraInicio,
                           cadastroTurmaViewModel.HoraFim,
                           Convert.ToInt32(cadastroTurmaViewModel.DiasDaSemana),
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
            ValorBase = aCTurma.ValorBase,
            HoraFim = aCTurma.HoraFim,
            HoraInicio = aCTurma.HoraInicio,
            DiasDaSemana = (DiasDaSemana)aCTurma.DiasDaSemana
        };

        public static ACTurmaViewModel DomainToViewModel(ACTurma domain) => new ACTurmaViewModel
        {
            CodigoNivel = domain.CodigoNivel,
            CodigoProfessor = domain.CodigoProfessor,
            CodigoTurma = domain.CodigoTurma,
            DataFim = domain.DataFim,
            DataInicio = domain.DataInicio,
            Descricao = domain.Descricao,
            ValorBase = domain.ValorBase,
            ACNivelViewModel = ACNivelAdapter.DomainToViewModel(domain.ACNivel),
            DiasDaSemana = (DiasDaSemana)domain.DiasDaSemana,
            HoraFim = domain.HoraFim,
            HoraInicio = domain.HoraInicio,
            ACProfessorViewModel = domain.ACProfessor == null ? new ACProfessorViewModel(): ACProfessorAdapter.DomainToViewModel(domain.ACProfessor)
        };

        public static IEnumerable<ACTurmaViewModel> DomainToViewModel(IEnumerable<ACTurma> listaDomain)
        {
            IList<ACTurmaViewModel> listaViewModel = new List<ACTurmaViewModel>();

            if (listaDomain != null)
                foreach (ACTurma domain in listaDomain)
                {
                    listaViewModel.Add(DomainToViewModel(domain));
                }

            return listaViewModel;
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
