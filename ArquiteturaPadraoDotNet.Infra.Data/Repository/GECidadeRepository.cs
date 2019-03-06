using System.Collections.Generic;
using System.Linq;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;

namespace One.Infra.Data.Repository
{
    public class GECidadeRepository : Repository<GECidade>, IGECidadeRepository
    {
        public GECidadeRepository(OneContext context) : base(context)
        {
        }

        public IEnumerable<GECidade> ObterPorUF(int pCodigoUF)
        {
            return Db.GECidade
                .Where(c => c.CodigoUF == pCodigoUF)
                .OrderBy(c => c.Descricao);
        }
    }
}
