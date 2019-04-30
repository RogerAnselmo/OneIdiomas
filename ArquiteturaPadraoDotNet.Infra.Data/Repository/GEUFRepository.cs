using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace One.Infra.Data.Repository
{
    public class GEUFRepository : Repository<GEUF>, IGEUFRepository
    {
        public GEUFRepository(OneContext context) : base(context)
        {
        }

        /// <summary>
        /// carrega todas as UF's válidas
        /// </summary>
        /// <returns>lista da GEUF</returns>
        public IEnumerable<GEUF> ObterTodosAtivos() 
            => Db.GEUF
                .Where(uf => "A".Equals(uf.flAtivo))
                .OrderBy(uf => uf.Descricao);
    }
}
