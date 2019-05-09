using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Service
{
    public interface IACProfessorService : IDisposable
    {
        ACProfessor Salvar(ACProfessor ACProfessor);
        ACProfessor Alterar(ACProfessor ACProfessor);
        ACProfessor Excluir(int id);
        ACProfessor ObterProfessorParaEdicao(int id);
        IEnumerable<ACProfessor> ObterProfessorPorNome(string nome);
    }
}
