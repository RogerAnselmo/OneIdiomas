using System;
using System.Collections.Generic;
using System.Linq;
using One.Application.ViewModels;
using One.Application.ViewModels.ACResponsavelVM;
using One.Domain.Entities;

namespace One.Application.Adapter
{
    public static class ACResponsavelAdapter
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

        public static CadastroResponsavelViewModel ConvertToCadastroResponsavelViewModel(ACResponsavel ACResponsavel)
        {
            GEEndereco GEEndereco = ACResponsavel.SEGUsuario.GEUsuarioEndereco.ToList().FirstOrDefault().GEEndereco;
            GETelefone GETelefone = ACResponsavel.SEGUsuario.GETelefone.FirstOrDefault();

            return new CadastroResponsavelViewModel
            {
                CodigoUsuario = ACResponsavel.CodigoUsuario,
                CodigoResponsavel = ACResponsavel.CodigoResponsavel,
                CEP = GEEndereco.Cep,
                CodigoBairro = GEEndereco.CodigoBairro,
                CodigoCidade = GEEndereco.GEBairro.CodigoCidade,
                CodigoEndereco = GEEndereco.CodigoEndereco,
                CodigoUF = GEEndereco.GEBairro.GECidade.CodigoUF,
                CPF = ACResponsavel.CPF,
                DataNascimento = ACResponsavel.DataNascimento.ToShortDateString(),
                Idade = ACResponsavel.Idade(),
                Logradouro = GEEndereco.Logradouro,
                NomeCompleto = ACResponsavel.SEGUsuario.NomeCompleto,
                RG = ACResponsavel.RG,
                Telefone = GETelefone.NumeroTelefone,
                CodigoTelefone = GETelefone.CodigoTelefone
            };
        }

        public static SEGUsuario ExtractSEGUsuario(CadastroResponsavelViewModel cadastroResponsavelViewModel)
            => new SEGUsuario(cadastroResponsavelViewModel.CodigoUsuario, cadastroResponsavelViewModel.NomeCompleto, cadastroResponsavelViewModel.CPF);

        public static ACResponsavel ExtractACResponsavel(CadastroResponsavelViewModel cadastroResponsavelViewModel)
            => new ACResponsavel(cadastroResponsavelViewModel.CodigoResponsavel, cadastroResponsavelViewModel.CodigoUsuario, cadastroResponsavelViewModel.RG, cadastroResponsavelViewModel.CPF, Convert.ToDateTime(cadastroResponsavelViewModel.DataNascimento));

        public static GEEndereco ExtractGEEndereco(CadastroResponsavelViewModel cadastroResponsavelViewModel)
            => new GEEndereco(cadastroResponsavelViewModel.CodigoEndereco, cadastroResponsavelViewModel.CodigoBairro, cadastroResponsavelViewModel.Logradouro, cadastroResponsavelViewModel.Numero, cadastroResponsavelViewModel.CEP);

        public static GETelefone ExtractTelefone(CadastroResponsavelViewModel cadastroResponsavelViewModel) 
            => new GETelefone(cadastroResponsavelViewModel.CodigoTelefone, cadastroResponsavelViewModel.Telefone, 1, cadastroResponsavelViewModel.CodigoUsuario);
    }
}
