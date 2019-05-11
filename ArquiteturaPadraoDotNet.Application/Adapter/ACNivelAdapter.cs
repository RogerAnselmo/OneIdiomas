using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Application.Adapter
{
    public static class ACNivelAdapter
    {
        public static ACNivelViewModel DomainToViewModel(ACNivel domain) => new ACNivelViewModel
        {
            CodigoNivel = domain.CodigoNivel,
            Descricao = domain.Descricao
        };

        public static IEnumerable<ACNivelViewModel> DomainToViewModel(IEnumerable<ACNivel> listaDomain)
        {
            IList<ACNivelViewModel> listaViewModel = new List<ACNivelViewModel>();

            if (listaDomain != null)
                foreach (ACNivel domain in listaDomain)
                    listaViewModel.Add(DomainToViewModel(domain));

            return listaViewModel;
        }
    }
}
