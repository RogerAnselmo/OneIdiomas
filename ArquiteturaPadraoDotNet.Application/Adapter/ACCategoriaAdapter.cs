using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Application.Adapter
{
    public static class ACCategoriaAdapter
    {
        public static ACCategoriaViewModel DomainToViewModel(ACCategoria domain) => new ACCategoriaViewModel
        {
            CodigoCategoria = domain.CodigoCategoria,
            DescicaoCategoria = domain.DescicaoCategoria
        };

        public static IEnumerable<ACCategoriaViewModel> DomainToViewModel(IEnumerable<ACCategoria> listaDomain)
        {
            IList<ACCategoriaViewModel> listaViewModel = new List<ACCategoriaViewModel>();

            if (listaDomain != null)
                foreach (ACCategoria domain in listaDomain)
                {
                    listaViewModel.Add(DomainToViewModel(domain));
                }

            return listaViewModel;
        }

        public static ACCategoria ViewModelToDomain(ACCategoriaViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<ACCategoria> ViewModelToDomain(IEnumerable<ACCategoriaViewModel> listaViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
