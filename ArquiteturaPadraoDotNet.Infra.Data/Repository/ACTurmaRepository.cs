using Microsoft.EntityFrameworkCore;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;
using System.Linq;

namespace One.Infra.Data.Repository
{
    public class ACTurmaRepository : Repository<ACTurma>, IACTurmaRepository
    {
        public ACTurmaRepository(OneContext context) : base(context)
        {
        }

        public override IQueryable<ACTurma> ObterTodos()
            => Db.ACTurma.Where(t => t.flAtivo.Equals("A"))
                .Include(t => t.ACNivel)
                .Include(t => t.ACNivel.ACCategoria)
                .AsNoTracking();
    }
}
