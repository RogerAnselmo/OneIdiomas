using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Application.Extractors
{
    public static class CadastroAlunoExtractor
    {
        public static SEGUsuario ExtractSEGUsuarioAluno(CadastroAlunoViewModel CadastroAlunoViewModel) => new SEGUsuario
        {
            Login = CadastroAlunoViewModel.CPF,
            NomeCompleto = CadastroAlunoViewModel.NomeCompleto,
            flAtivo = "A"
        };

        public static SEGUsuario ExtractSEGUsuarioResponsavel(CadastroAlunoViewModel CadastroAlunoViewModel) => new SEGUsuario
            {
                Login = CadastroAlunoViewModel.CPF,
                NomeCompleto = CadastroAlunoViewModel.NomeCompleto,
                flAtivo = "A"
            };

        public static ACAluno ExtractACAluno(CadastroAlunoViewModel CadastroAlunoViewModel) => new ACAluno
        {
            CodigoAluno = CadastroAlunoViewModel.CodigoAluno,
            CPF = CadastroAlunoViewModel.CPF,
            DataNascimento = Convert.ToDateTime(CadastroAlunoViewModel.DataNascimento),
            DiaVencimento = CadastroAlunoViewModel.DiaVencimento,
            RG = CadastroAlunoViewModel.RG,
            flAtivo = "A"
        };

        public static GEEndereco ExtractGEEnderecoAluno(CadastroAlunoViewModel CadastroAlunoViewModel) => new GEEndereco()
        {
            CodigoEndereco = CadastroAlunoViewModel.CodigoEndereco,
            Cep = CadastroAlunoViewModel.CEP,
            CodigoBairro = CadastroAlunoViewModel.CodigoBairro,
            Logradouro = CadastroAlunoViewModel.Logradouro,
            Numero = CadastroAlunoViewModel.Numero,
            flAtivo = "A"
        };

        public static ACResponsavel ExtractACResponsavel(CadastroAlunoViewModel CadastroAlunoViewModel) => new ACResponsavel
        {
            CodigoResponsavel = CadastroAlunoViewModel.CodigoResponsavel,
            CPF = CadastroAlunoViewModel.CPFResponsavel,
            RG = CadastroAlunoViewModel.RGResponsavel,
            DataNascimento = Convert.ToDateTime(CadastroAlunoViewModel.DataNascimentoResponsavel),
            flAtivo = "A"
        };

        public static GEEndereco ExtractGEEnderecoResponsavel(CadastroAlunoViewModel CadastroAlunoViewModel) => new GEEndereco()
        {
            CodigoEndereco = CadastroAlunoViewModel.CodigoEnderecoResponsavel,
            Cep = CadastroAlunoViewModel.CEPResponsavel,
            Logradouro = CadastroAlunoViewModel.LogradouroResponsavel,
            Numero = CadastroAlunoViewModel.NumeroResponsavel,
            CodigoBairro = CadastroAlunoViewModel.CodigoBairroResponsavel,
            flAtivo = "A"
        };

        public static ACAlunoResponsavel ExtractACAlunoResponsavel(CadastroAlunoViewModel CadastroAlunoViewModel) => new ACAlunoResponsavel
        {
            CodigoAluno = CadastroAlunoViewModel.CodigoAluno,
            CodigoResponsavel = CadastroAlunoViewModel.CodigoResponsavel,
            CodigoParentesco = CadastroAlunoViewModel.CodigoParentesco
        };

        public static GETelefone ExtractTelefoneAluno(CadastroAlunoViewModel CadastroAlunoViewModel) => new GETelefone
        {
            NumeroTelefone = CadastroAlunoViewModel.Telefone,
            flAtivo = "A",
            CodigoTipoTelefone = 1
        };

        public static GETelefone ExtractTelefoneResponsavel(CadastroAlunoViewModel CadastroAlunoViewModel) => new GETelefone
        {
            NumeroTelefone = CadastroAlunoViewModel.TelefoneResponsavel,
            flAtivo = "A",
            CodigoTipoTelefone = 1
        };
    }
}
