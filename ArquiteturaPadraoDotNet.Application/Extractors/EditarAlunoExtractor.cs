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

        public static SEGUsuario ExtractSEGUsuario(EditarAlunoViewModel editarAlunoViewModel)
            => new SEGUsuario(editarAlunoViewModel.CodigoUsuario, editarAlunoViewModel.NomeCompleto, editarAlunoViewModel.CPF);

        public static ACAluno ExtractACAluno(EditarAlunoViewModel editarAlunoViewModel) => new ACAluno
        (
            editarAlunoViewModel.CodigoAluno,
            editarAlunoViewModel.CodigoUsuario,
            editarAlunoViewModel.RG,
            editarAlunoViewModel.CPF,
            Convert.ToDateTime(editarAlunoViewModel.DataNascimento),
            editarAlunoViewModel.DiaVencimento
        );

        public static GEEndereco ExtractEnderecoAluno(EditarAlunoViewModel editarAlunoViewModel) 
            => new GEEndereco(editarAlunoViewModel.CodigoEndereco, editarAlunoViewModel.CodigoBairro, editarAlunoViewModel.Logradouro, editarAlunoViewModel.Numero, editarAlunoViewModel.CEP);
    }
}
