using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Interfaces.Service
{
    public interface IGEEnderecoService: IDisposable
    {
        GEEndereco SalvarEndereco(GEEndereco GEEndereco);
        GEUsuarioEndereco SalvarUsuarioEndereco(GEUsuarioEndereco GEUsuarioEndereco);
        GEEndereco AlterarEndereco(GEEndereco GEEndereco);    
    }
}
