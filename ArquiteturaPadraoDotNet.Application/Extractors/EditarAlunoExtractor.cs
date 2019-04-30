using One.Application.ViewModels.ACAlunoVM;
using One.Domain.Entities;
using System;
using System.Linq;

namespace One.Application.Extractors
{
    public static class EditarAlunoExtractor
    {
        public static EditarAlunoViewModel ConvertAcAlunoToEditarAlunoViewModel(ACAluno ACAluno)
        {

            GEEndereco GEEndereco = ACAluno.SEGUsuario.GEUsuarioEndereco.ToList().FirstOrDefault().GEEndereco;

            return new EditarAlunoViewModel
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

        public static SEGUsuario ExtractSEGUsuario(EditarAlunoViewModel editarAlunoViewModel) => new SEGUsuario
        {
            CodigoUsuario = editarAlunoViewModel.CodigoUsuario,
            NomeCompleto = editarAlunoViewModel.NomeCompleto,
            Login = editarAlunoViewModel.CPF,
            flAtivo = "A"
        };

        public static ACAluno ExtractACAluno(EditarAlunoViewModel editarAlunoViewModel) => new ACAluno
        {
            CodigoUsuario = editarAlunoViewModel.CodigoUsuario,
            DataNascimento = Convert.ToDateTime(editarAlunoViewModel.DataNascimento),
            CodigoAluno = editarAlunoViewModel.CodigoAluno,
            CPF = editarAlunoViewModel.CPF,
            DiaVencimento = editarAlunoViewModel.DiaVencimento,
            RG = editarAlunoViewModel.RG,
            flAtivo = "A"
        };

        public static GEEndereco ExtractEnderecoAluno(EditarAlunoViewModel editarAlunoViewModel) => new GEEndereco
        {
            Cep = editarAlunoViewModel.CEP,
            CodigoBairro = editarAlunoViewModel.CodigoBairro,
            CodigoEndereco = editarAlunoViewModel.CodigoEndereco,
            flAtivo = "A",
            Logradouro = editarAlunoViewModel.Logradouro,
            Numero = editarAlunoViewModel.Numero
        };
    }
}
