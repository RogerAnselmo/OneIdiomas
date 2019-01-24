using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Service
{
    public interface IGECidadeService: IDisposable
    {
        IEnumerable<GECidade> ObterPorUF(int pCodigoUF);
    }
}
