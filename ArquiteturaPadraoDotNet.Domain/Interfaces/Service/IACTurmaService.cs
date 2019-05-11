using One.Domain.Entities;
using System;

namespace One.Domain.Interfaces.Service
{
    public interface IACTurmaService : IDisposable
    {
        ACTurma Salvar(ACTurma aCTurma);
        ACTurma Alterar(ACTurma aCTurma);
    }
}
