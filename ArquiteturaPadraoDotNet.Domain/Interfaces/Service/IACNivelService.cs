using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Service
{
    public interface IACNivelService: IDisposable
    {
        IEnumerable<ACNivel> ObterTodosAtivos();
    }
}
