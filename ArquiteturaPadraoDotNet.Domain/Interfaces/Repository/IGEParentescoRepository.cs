using One.Domain.Entities;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Repository
{
    public interface IGEParentescoRepository: IRepository<GEParentesco>
    {
        IEnumerable<GEParentesco> ObterTodosParentesco();
    }
}
