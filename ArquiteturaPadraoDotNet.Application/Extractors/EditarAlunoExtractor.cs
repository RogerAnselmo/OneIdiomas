using One.Application.ViewModels.ACAlunoVM;
using One.Domain.Entities;
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
