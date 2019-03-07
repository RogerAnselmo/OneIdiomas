using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Application.Adapter
{
    public static class GEPArentescoAdapter
    {
        public static GEParentescoViewModel DomainToViewModel(GEParentesco domain)
        {
            GEParentescoViewModel viewModel = new GEParentescoViewModel();

            if(domain != null)
            {
                viewModel = new GEParentescoViewModel
                {
                    CodigoParentesco = domain.CodigoParentesco,
                    Descricao = domain.Descricao,
                    flAtivo = domain.flAtivo
                };
            }

            return viewModel;
        }

        public static IEnumerable<GEParentescoViewModel> DomainToViewModel(IEnumerable<GEParentesco> listaDomain)
        {
            IList<GEParentescoViewModel> listaViewModel = new List<GEParentescoViewModel>();

            if(listaDomain != null)
            {
                foreach(GEParentesco domain in listaDomain)
                {
                    listaViewModel.Add(DomainToViewModel(domain));
                }
            }

            return listaViewModel;
        }

        public static GEParentesco ViewModelToDomain(GEParentescoViewModel viewModel)
        {
            GEParentesco domain = new GEParentesco();

            if (viewModel != null)
            {
                domain = new GEParentesco
                {
                    CodigoParentesco = viewModel.CodigoParentesco,
                    Descricao = viewModel.Descricao,
                    flAtivo = viewModel.flAtivo
                };
            }

            return domain;
        }

        public static IEnumerable<GEParentesco> ViewModelToDomain(IEnumerable<GEParentescoViewModel> listaViewModel)
        {
            IList<GEParentesco> listaDomain = new List<GEParentesco>();

            if (listaDomain != null)
            {
                foreach (GEParentescoViewModel viewModel in listaViewModel)
                {
                    listaDomain.Add(ViewModelToDomain(viewModel));
                }
            }

            return listaDomain;
        }
    }
}
