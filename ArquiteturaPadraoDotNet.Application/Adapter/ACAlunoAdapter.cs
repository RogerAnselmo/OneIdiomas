using One.Application.Interfaces;
using One.Application.ViewModels;
using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Application.Adapter
{
    public class ACAlunoAdapter : IAppAdapter<ACAluno, ACAlunoViewModel>
    {
        public ACAlunoViewModel DomainToViewModel(ACAluno domain)
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

        public IEnumerable<ACAlunoViewModel> DomainToViewModel(IEnumerable<ACAluno> listaDomain)
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

        public ACAluno ViewModelToDomain(ACAlunoViewModel viewModel)
        {
            ACAluno domain = new ACAluno();

            if(viewModel != null)
            {
                domain = new ACAluno
                {
                    CodigoAluno = viewModel.CodigoAluno,
                    //CodigoEndereco = viewModel.GEEnderecoViewModel != null ? viewModel.GEEnderecoViewModel.CodigoEndereco : 0,
                    CodigoUsuario = viewModel.SEGUsuarioViewModel != null ? viewModel.SEGUsuarioViewModel.CodigoUsuario: 0
                };
            }

            return domain;
        }

        public IEnumerable<ACAluno> ViewModelToDomain(IEnumerable<ACAlunoViewModel> listaViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
