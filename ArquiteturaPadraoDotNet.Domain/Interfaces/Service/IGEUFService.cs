using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Service
{
    public interface IGEUFService: IDisposable
    {
        IEnumerable<GEUF> ObterTodos();
    }
}
