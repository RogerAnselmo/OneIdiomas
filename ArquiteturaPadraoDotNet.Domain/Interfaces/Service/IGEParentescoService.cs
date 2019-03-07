using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Service
{
    public interface IGEParentescoService: IDisposable
    {
        IEnumerable<GEParentesco> ObterTodos();
    }
}
