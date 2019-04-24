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
        public static ACAluno ExtractACAluno(CadastroAlunoViewModel pCadastroAlunoViewModel)
        {
            return new ACAluno
            {
                CodigoAluno = pCadastroAlunoViewModel.CodigoAluno,
                CPF = pCadastroAlunoViewModel.CPF,
                DataNascimento = Convert.ToDateTime(pCadastroAlunoViewModel.DataNascimento),
                DiaVencimento = pCadastroAlunoViewModel.DiaVencimento,
                RG = pCadastroAlunoViewModel.RG,
                flAtivo = "A"
            };
        }

        public static GEEndereco ExtractGEEnderecoAluno(CadastroAlunoViewModel pCadastroAlunoViewModel)
        {
            return new GEEndereco()
            {
                CodigoEndereco = pCadastroAlunoViewModel.CodigoEndereco,
                Cep = pCadastroAlunoViewModel.CEP,
                CodigoBairro = pCadastroAlunoViewModel.CodigoBairro,
                Logradouro = pCadastroAlunoViewModel.Logradouro,
                Numero = pCadastroAlunoViewModel.Numero,
                flAtivo = "A"
            };
        }

        public static ACResponsavel ExtractACResponsavel(CadastroAlunoViewModel pCadastroAlunoViewModel)
        {
            return new ACResponsavel
            {
                CodigoResponsavel = pCadastroAlunoViewModel.CodigoResponsavel,
                CPF = pCadastroAlunoViewModel.CPFResponsavel,
                RG = pCadastroAlunoViewModel.RGResponsavel,
                DataNascimento = Convert.ToDateTime(pCadastroAlunoViewModel.DataNascimentoResponsavel),
                flAtivo = "A"
            };
        }

        public static GEEndereco ExtractGEEnderecoResponsavel(CadastroAlunoViewModel pCadastroAlunoViewModel)
        {
            return new GEEndereco()
            {
                CodigoEndereco = pCadastroAlunoViewModel.CodigoEnderecoResponsavel,
                Cep = pCadastroAlunoViewModel.CEPResponsavel,
                Logradouro = pCadastroAlunoViewModel.LogradouroResponsavel,
                Numero = pCadastroAlunoViewModel.NumeroResponsavel,

                CodigoBairro = pCadastroAlunoViewModel.CodigoBairroResponsavel,
                //GEBairro = new GEBairro
                //{
                //    CodigoBairro = pCadastroAlunoViewModel.CodigoBairroResponsavel,

                //    CodigoCidade = pCadastroAlunoViewModel.CodigoCidadeResponsavel,
                //    GECidade = new GECidade
                //    {
                //        CodigoCidade = pCadastroAlunoViewModel.CodigoCidadeResponsavel,

                //        CodigoUF = pCadastroAlunoViewModel.CodigoUFResponsavel,
                //        GEUF = new GEUF
                //        {
                //            CodigoUF = pCadastroAlunoViewModel.CodigoUFResponsavel
                //        }
                //    }
                //},
                flAtivo="A"
            };
        }

        public static ACAlunoResponsavel ExtractACAlunoResponsavel(CadastroAlunoViewModel pCadastroAlunoViewModel)
        {
            return new ACAlunoResponsavel
            {
                CodigoAluno = pCadastroAlunoViewModel.CodigoAluno,
                CodigoResponsavel = pCadastroAlunoViewModel.CodigoResponsavel,
                CodigoParentesco = pCadastroAlunoViewModel.CodigoParentesco
            };
        }
    }
}
