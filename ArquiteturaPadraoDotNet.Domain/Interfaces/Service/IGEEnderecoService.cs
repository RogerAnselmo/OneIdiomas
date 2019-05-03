using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Interfaces.Service
{
    public interface IGEEnderecoService : IDisposable
    {
        GEEndereco Salvar(GEEndereco GEEndereco);
        GEEndereco Alterar(GEEndereco GEEndereco);
        GEUsuarioEndereco SalvarUsuarioEndereco(GEUsuarioEndereco GEUsuarioEndereco);
        GEUsuarioEndereco AlterarUsuarioEndereco(GEUsuarioEndereco GEUsuarioEndereco);
    }
}
