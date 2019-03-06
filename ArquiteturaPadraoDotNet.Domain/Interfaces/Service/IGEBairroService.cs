using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Service
{
    public interface IGEBairroService: IDisposable
    {
        IEnumerable<GEBairro> ObterBairroPorCidade(int CodigoCidade);
    }
}
