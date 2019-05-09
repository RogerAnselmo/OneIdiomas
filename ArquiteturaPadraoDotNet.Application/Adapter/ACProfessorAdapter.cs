using One.Application.ViewModels;
using One.Application.ViewModels.ACProfessorVM;
using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Application.Adapter
{
    public static class ACProfessorAdapter
    {
        public static ACProfessorViewModel DomainToViewModel(ACProfessor domain)
        {
            ACProfessorViewModel viewModel = new ACProfessorViewModel();

            if (domain != null)
            {
                viewModel = new ACProfessorViewModel
                {
                    CodigoUsuario = domain.CodigoUsuario,
                    CodigoProfessor = domain.CodigoProfessor,
                    CPF = domain.CPF,
                    RG = domain.RG
                };
            }

            return viewModel;
        }

        public static IEnumerable<ACProfessorViewModel> DomainToViewModel(IEnumerable<ACProfessor> listaDomain)
        {
            IList<ACProfessorViewModel> listaViewModel = new List<ACProfessorViewModel>();

            if (listaDomain != null)
                foreach (ACProfessor domain in listaDomain)
                {
                    listaViewModel.Add(DomainToViewModel(domain));
                }

            return listaViewModel;
        }

        public static SEGUsuario ExtractSEGUsuario(CadastroProfessorViewModel cadastroProfessorViewModel) 
            => new SEGUsuario(cadastroProfessorViewModel.CodigoUsuario, cadastroProfessorViewModel.NomeProfessor, cadastroProfessorViewModel.CPF);

        public static ACProfessor ExtractACProfessor(CadastroProfessorViewModel cadastroProfessorViewModel) 
            => new ACProfessor(cadastroProfessorViewModel.CodigoUsuario, cadastroProfessorViewModel.CodigoProfessor, Convert.ToDateTime(cadastroProfessorViewModel.DataNascimento), cadastroProfessorViewModel.CPF, cadastroProfessorViewModel.RG);
    }
}
