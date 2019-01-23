using System.Collections.Generic;
using One.Application.ViewModels;
using One.Domain.Entities;

namespace One.Application.Adapter
{
    public static class GEUFAdapter 
    {
        public static GEUFViewModel DomainToViewModel(GEUF domain)
        {
            GEUFViewModel GEUFViewModel = new GEUFViewModel();

            if (domain != null)
            {
                GEUFViewModel = new GEUFViewModel
                {
                    CodigoUF = domain.CodigoUF,
                    Descricao = domain.Descricao,
                    Sigla = domain.Sigla
                };
            }

            return GEUFViewModel;
        }

        public static IEnumerable<GEUFViewModel> DomainToViewModel(IEnumerable<GEUF> listaDomain)
        {
            IList<GEUFViewModel> listaViewModel = new List<GEUFViewModel>();

            if(listaDomain != null)
            {
                foreach(GEUF GEUF in listaDomain)
                {
                    listaViewModel.Add(DomainToViewModel(GEUF));
                }
            }

            return listaViewModel;
        }

        public static GEUF ViewModelToDomain(GEUFViewModel viewModel)
        {
            GEUF GEUF = new GEUF();

            if(viewModel != null)
            {
                GEUF = new GEUF
                {
                    CodigoUF = viewModel.CodigoUF,
                    Descricao = viewModel.Descricao,
                    Sigla = viewModel.Sigla
                };
            }

            return GEUF;
        }

        public static IEnumerable<GEUF> ViewModelToDomain(IEnumerable<GEUFViewModel> listaViewModel)
        {
            IList<GEUF> listaDomain = new List<GEUF>();

            if(listaViewModel != null)
            {
                foreach(GEUFViewModel GEUFViewModel in listaViewModel)
                {
                    listaDomain.Add(ViewModelToDomain(GEUFViewModel));
                }
            }

            return listaDomain;
        }
    }
}
