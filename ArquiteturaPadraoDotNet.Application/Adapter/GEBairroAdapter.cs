using One.Application.ViewModels;
using One.Domain.Entities;
using System.Collections.Generic;

namespace One.Application.Adapter
{
    public static class GEBairroAdapter
    {
        public static GEBairroViewModel DomainToViewModel(GEBairro domain)
        {
            GEBairroViewModel viewModel = new GEBairroViewModel();

            if(domain != null)
            {
                viewModel = new GEBairroViewModel
                {
                    CodigoBairro = domain.CodigoBairro,
                    Descricao = domain.descricao,
                    GECidadeViewModel = domain.GECidade == null ? new GECidadeViewModel() : GECidadeAdapter.DomainToViewModel(domain.GECidade)
                };
            }

            return viewModel;
        }
        public static IEnumerable<GEBairroViewModel> DomainToViewModel(IEnumerable<GEBairro> listaDomain)
        {
            IList<GEBairroViewModel> listaViewModel = new List<GEBairroViewModel>();

            if (listaDomain != null)
            {
                foreach (GEBairro domain in listaDomain)
                {
                    listaViewModel.Add(DomainToViewModel(domain));
                }
            }

            return listaViewModel;
        }

        public static GEBairro ViewModelToDimain(GEBairroViewModel viewModel)
        {
            GEBairro domain = new GEBairro();

            if (viewModel != null)
            {
                domain = new GEBairro
                {
                    CodigoBairro = viewModel.CodigoBairro,
                    descricao = viewModel.Descricao,
                    GECidade = viewModel.GECidadeViewModel == null ? new GECidade() : GECidadeAdapter.ViewModelToDomain(viewModel.GECidadeViewModel)
                };
            }

            return domain;
        }
        public static IEnumerable<GEBairro> ViewModelToDimain(IEnumerable<GEBairroViewModel> listaViewModel)
        {
            IList<GEBairro> listaDomain = new List<GEBairro>();

            if (listaDomain != null)
            {
                foreach (GEBairroViewModel viewModel in listaViewModel)
                {
                    listaDomain.Add(ViewModelToDimain(viewModel));
                }
            }

            return listaDomain;
        }
    }
}
