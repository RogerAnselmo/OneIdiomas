using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace One.Application.Adapter
{
    public static class ACAlunoAdapter
    {
        public static ACAlunoViewModel DomainToViewModel(ACAluno domain)
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

        public static IEnumerable<ACAlunoViewModel> DomainToViewModel(IEnumerable<ACAluno> listaDomain)
        {
            IList<ACAlunoViewModel> listaViewModel = new List<ACAlunoViewModel>();

            if (listaDomain != null)
                foreach (ACAluno domain in listaDomain)
                {
                    listaViewModel.Add(DomainToViewModel(domain));
                }

            return listaViewModel;
        }

        public static SEGUsuario ExtractSEGUsuario(CadastroAlunoViewModel cadastroAlunoViewModel) 
            => new SEGUsuario(cadastroAlunoViewModel.CodigoUsuario, cadastroAlunoViewModel.NomeCompleto, cadastroAlunoViewModel.CPF);

        public static ACAluno ExtractACAluno(CadastroAlunoViewModel cadastroAlunoViewModel) 
            => new ACAluno(cadastroAlunoViewModel.CodigoAluno, cadastroAlunoViewModel.CodigoUsuario, cadastroAlunoViewModel.RG, cadastroAlunoViewModel.CPF, Convert.ToDateTime(cadastroAlunoViewModel.DataNascimento), cadastroAlunoViewModel.DiaVencimento);

        public static GEEndereco ExtractGEEndereco(CadastroAlunoViewModel cadastroAlunoViewModel)
                    => new GEEndereco(cadastroAlunoViewModel.CodigoEndereco, cadastroAlunoViewModel.CodigoBairro, cadastroAlunoViewModel.Logradouro, cadastroAlunoViewModel.Numero, cadastroAlunoViewModel.CEP);

        public static GETelefone ExtractTelefone(CadastroAlunoViewModel cadastroAlunoViewModel)
            => new GETelefone(cadastroAlunoViewModel.CodigoTelefone, cadastroAlunoViewModel.Telefone, 1, cadastroAlunoViewModel.CodigoUsuario);

        public static CadastroAlunoViewModel ConvertAcAlunoToCadastroAlunoViewModel(ACAluno ACAluno)
        {

            GEEndereco GEEndereco = ACAluno.SEGUsuario.GEUsuarioEndereco.ToList().FirstOrDefault().GEEndereco;

            return new CadastroAlunoViewModel
            {
                CodigoUsuario = ACAluno.CodigoUsuario,
                CodigoAluno = ACAluno.CodigoAluno,
                CEP = GEEndereco.Cep,
                CodigoBairro = GEEndereco.CodigoBairro,
                CodigoCidade = GEEndereco.GEBairro.CodigoCidade,
                CodigoEndereco = GEEndereco.CodigoEndereco,
                CodigoUF = GEEndereco.GEBairro.GECidade.CodigoUF,
                CPF = ACAluno.CPF,
                DataNascimento = ACAluno.DataNascimento.ToShortDateString(),
                DiaVencimento = ACAluno.DiaVencimento,
                Idade = ACAluno.Idade(),
                Logradouro = GEEndereco.Logradouro,
                NomeCompleto = ACAluno.SEGUsuario.NomeCompleto,
                RG = ACAluno.RG,
                Telefone = ACAluno.SEGUsuario.GETelefone.FirstOrDefault().NumeroTelefone
            };
        }
    }
}
