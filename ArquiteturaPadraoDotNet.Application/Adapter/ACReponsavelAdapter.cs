using System.Collections.Generic;
using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Domain.Entities;

namespace One.Application.Adapter
{
    public static class ACReponsavelAdapter 
    {

        public static ACResponsavelViewModel DomainToViewModel(ACResponsavel domain)
        {
            return new ACResponsavelViewModel
            {
                CodigoUsuario = domain.CodigoUsuario,
                CodigoResponsavel = domain.CodigoResponsavel,
                CPF = domain.CPF,
                DataNascimento = domain.DataNascimento.ToShortDateString(),
                flAtivo = domain.flAtivo,
                RG = domain.RG,
                Sexo = domain.Sexo,
                Idade = domain.Idade(),
                SEGUsuario = domain.SEGUsuario != null ? SEGUsuarioAdapter.DomainToViewModel(domain.SEGUsuario) : new SEGUsuarioViewModel()
            };
        }

        public static IEnumerable<ACResponsavelViewModel> DomainToViewModel(IEnumerable<ACResponsavel> listaDomain)
        {
            IList<ACResponsavelViewModel> listaViewModel = new List<ACResponsavelViewModel>();

            if (listaDomain != null)
                foreach (ACResponsavel domain in listaDomain)
                {
                    listaViewModel.Add(DomainToViewModel(domain));
                }

            return listaViewModel;
        }

        public static ACResponsavel ViewModelToDomain(ACResponsavelViewModel viewModel)
        {
            throw new System.NotImplementedException();
        }

        public static IEnumerable<ACResponsavel> ViewModelToDomain(IEnumerable<ACResponsavelViewModel> listaViewModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
