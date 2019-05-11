using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace One.Infra.Data.Repository
{
    public class ACNivelRepository : Repository<ACNivel>, IACNivelRepository
    {
        public ACNivelRepository(OneContext context) : base(context)
        {
        }

        public IEnumerable<ACNivel> ObterTodosAtivos() => Db.ACNivel.Where(n => n.flAtivo.Equals("A"));
    }
}
