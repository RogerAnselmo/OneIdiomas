using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Service
{
    public interface IACTurmaService : IDisposable
    {
        ACTurma Salvar(ACTurma aCTurma);
        ACTurma Alterar(ACTurma aCTurma);
        IEnumerable<ACTurma> ObterTodos();
    }
}
