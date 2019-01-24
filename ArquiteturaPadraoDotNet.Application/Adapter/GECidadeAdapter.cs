using One.Application.ViewModels;
using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Application.Adapter
{
    public static class GECidadeAdapter
    {
        public static GECidadeViewModel DomainToViewModel(GECidade domain)
        {
            GECidadeViewModel viewModel = new GECidadeViewModel();

            if(domain != null)
            {
                viewModel = new GECidadeViewModel
                {
                    CodigoCidade = domain.CodigoCidade,
                    Descricao = domain.Descricao,
                    GEUFViewModel = domain.GEUF != null ? GEUFAdapter.DomainToViewModel(domain.GEUF) : new GEUFViewModel()
                };
            }

            return viewModel;
        }

        public static IEnumerable<GECidadeViewModel> DomainToViewModel(IEnumerable<GECidade> listaDomain)
        {
            IList<GECidadeViewModel> listaViewModel = new List<GECidadeViewModel>();

            if(listaDomain != null)
            {
                foreach(GECidade domain in listaDomain)
                {
                    listaViewModel.Add(DomainToViewModel(domain));
                }
            }

            return listaViewModel;
        }

        public static GECidade ViewModelToDomain(GECidadeViewModel viewModel)
        {
            GECidade domain = new GECidade();

            if (domain != null)
            {
                domain = new GECidade
                {
                    CodigoCidade = viewModel.CodigoCidade,
                    Descricao = viewModel.Descricao,
                    GEUF = viewModel.GEUFViewModel != null ? GEUFAdapter.ViewModelToDomain(viewModel.GEUFViewModel) : new GEUF()
                };
            }

            return domain;
        }

        public static  IEnumerable<GECidade> ViewModelToDomain(IEnumerable<GECidadeViewModel> listaViewModel)
        {
            IList<GECidade> listaDomain = new List<GECidade>();

            if (listaViewModel != null)
            {
                foreach (GECidadeViewModel viewModel in listaViewModel)
                {
                    listaDomain.Add(ViewModelToDomain(viewModel));
                }
            }

            return listaDomain;
        }
    }
}
