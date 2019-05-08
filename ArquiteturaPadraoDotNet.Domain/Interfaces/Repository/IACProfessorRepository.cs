using One.Domain.Entities;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Repository
{
    public interface IACProfessorRepository : IRepository<ACProfessor>
    {
        IEnumerable<ACProfessor> ObterProfessorPorNome(string nome);
    }
}
