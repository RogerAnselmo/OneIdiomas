using One.Domain.Entities;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Repository
{
    public interface IGEUFRepository :IRepository<GEUF>
    {
        IEnumerable<GEUF> ObterTodosAtivos();
    }
}
