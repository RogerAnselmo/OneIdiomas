using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Interfaces.Service
{
    public interface IGEEnderecoService: IDisposable
    {
        void SalvarEndereco(GEEndereco GEEndereco);
        void SalvarUsuarioEndereco(GEUsuarioEndereco GEUsuarioEndereco);
    }
}
