namespace One.Application.Extractors
{
    public static class EditarResponsavelExtractor
    {
        //public static EditarResponsavelViewModel ConvertToEditarResponsavelViewModel(ACResponsavel ACResponsavel)
        //{
        //    GEEndereco GEEndereco = ACResponsavel.SEGUsuario.GEUsuarioEndereco.ToList().FirstOrDefault().GEEndereco;

        //    return new CadastroResponsavelViewModel
        //    {
        //        CodigoUsuario = ACResponsavel.CodigoUsuario,
        //        CodigoResponsavel= ACResponsavel.CodigoResponsavel,
        //        CEP = GEEndereco.Cep,
        //        CodigoBairro = GEEndereco.CodigoBairro,
        //        CodigoCidade = GEEndereco.GEBairro.CodigoCidade,
        //        CodigoEndereco = GEEndereco.CodigoEndereco,
        //        CodigoUF = GEEndereco.GEBairro.GECidade.CodigoUF,
        //        CPF = ACResponsavel.CPF,
        //        DataNascimento = ACResponsavel.DataNascimento.ToShortDateString(),
        //        Idade = ACResponsavel.Idade(),
        //        Logradouro = GEEndereco.Logradouro,
        //        NomeCompleto = ACResponsavel.SEGUsuario.NomeCompleto,
        //        RG = ACResponsavel.RG,
        //        Telefone = ACResponsavel.SEGUsuario.GETelefone.FirstOrDefault().NumeroTelefone
        //    };
        //}

        //public static SEGUsuario ExtractSEGUsuario(EditarResponsavelViewModel editarResponsavelViewModel) => new SEGUsuario
        //{
        //    CodigoUsuario = editarResponsavelViewModel.CodigoUsuario,
        //    NomeCompleto = editarResponsavelViewModel.NomeCompleto,
        //    Login = editarResponsavelViewModel.CPF,
        //    flAtivo = "A"
        //};

        //public static ACResponsavel ExtractACResponsavel(EditarResponsavelViewModel editarResponsavelViewModel) => new ACResponsavel
        //(
        //    editarResponsavelViewModel.CodigoResponsavel,
        //    editarResponsavelViewModel.CodigoUsuario,
        //    editarResponsavelViewModel.RG,
        //    editarResponsavelViewModel.CPF,
        //    Convert.ToDateTime(editarResponsavelViewModel.DataNascimento)
        //);

        //public static GEEndereco ExtractEnderecoResponsavel(EditarResponsavelViewModel editarResponsavelViewModel) => new GEEndereco
        //{
        //    Cep = editarResponsavelViewModel.CEP,
        //    CodigoBairro = editarResponsavelViewModel.CodigoBairro,
        //    CodigoEndereco = editarResponsavelViewModel.CodigoEndereco,
        //    flAtivo = "A",
        //    Logradouro = editarResponsavelViewModel.Logradouro,
        //    Numero = editarResponsavelViewModel.Numero
        //};
    }
}
