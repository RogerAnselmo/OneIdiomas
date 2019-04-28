using One.Application.ViewModels;
using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Application.Adapter
{
    public static class ACAlunoAdapter
    {
        public static ACAlunoViewModel DomainToViewModel(ACAluno domain)
        {
            ACAlunoViewModel viewModel = new ACAlunoViewModel();

            if (domain != null)
            {
                viewModel = new ACAlunoViewModel
                {
                    CodigoAluno = domain.CodigoAluno,
                    DiaVencimento = domain.DiaVencimento,
                    Idade = domain.Idade(),
                    SEGUsuarioViewModel = domain.SEGUsuario != null ? SEGUsuarioAdapter.DomainToViewModel(domain.SEGUsuario) : new SEGUsuarioViewModel()
                };
            }

            return viewModel;
        }

        public static IEnumerable<ACAlunoViewModel> DomainToViewModel(IEnumerable<ACAluno> listaDomain)
        {
            IList<ACAlunoViewModel> listaViewModel = new List<ACAlunoViewModel>();

            if (listaDomain != null)
            {
                foreach (ACAluno domain in listaDomain)
                {
                    listaViewModel.Add(DomainToViewModel(domain));
                }
            }

            return listaViewModel;
        }

        public static ACAluno ViewModelToDomain(ACAlunoViewModel viewModel)
        {
            ACAluno domain = new ACAluno();

            if (viewModel != null)
            {
                domain = new ACAluno
                {
                    CodigoAluno = viewModel.CodigoAluno,
                    CodigoUsuario = viewModel.SEGUsuarioViewModel != null ? viewModel.SEGUsuarioViewModel.CodigoUsuario : 0
                };
            }

            return domain;
        }

        public static IEnumerable<ACAluno> ViewModelToDomain(IEnumerable<ACAlunoViewModel> listaViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
