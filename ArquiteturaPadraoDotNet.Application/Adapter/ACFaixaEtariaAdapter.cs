using System.Collections.Generic;
using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Domain.Entities;

namespace One.Application.Adapter
{
    public static class ACFaixaEtariaAdapter
    {
        public static ACFaixaEtariaViewModel DomainToViewModel(ACFaixaEtaria domain) => new ACFaixaEtariaViewModel
        {
            CodigoFaixaEtaria = domain.CodigoFaixaEtaria,
            Descricao = domain.Descricao,
            IdadeMaxima = domain.IdadeMaxima,
            IdadeMinima = domain.IdadeMinima
        };

        public static IEnumerable<ACFaixaEtariaViewModel> DomainToViewModel(IEnumerable<ACFaixaEtaria> listaDomain)
        {
            IList<ACFaixaEtariaViewModel> listaViewModel = new List<ACFaixaEtariaViewModel>();

            if (listaDomain != null)
                foreach (ACFaixaEtaria domain in listaDomain)
                {
                    listaViewModel.Add(DomainToViewModel(domain));
                }

            return listaViewModel;
        }

        public static ACFaixaEtaria ViewModelToDomain(ACFaixaEtariaViewModel viewModel)
        {
            throw new System.NotImplementedException();
        }

        public static IEnumerable<ACFaixaEtaria> ViewModelToDomain(IEnumerable<ACFaixaEtariaViewModel> listaViewModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
