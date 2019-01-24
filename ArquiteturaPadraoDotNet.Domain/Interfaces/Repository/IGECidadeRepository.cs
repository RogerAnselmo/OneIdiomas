using One.Domain.Entities;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Repository
{
    public interface IGECidadeRepository: IRepository<GECidade>
    {
        IEnumerable<GECidade> ObterPorUF(int pCodigoUF);
    }
}
