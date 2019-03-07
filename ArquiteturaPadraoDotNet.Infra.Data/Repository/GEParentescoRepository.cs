using Microsoft.EntityFrameworkCore;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace One.Infra.Data.Repository
{
    public class GEParentescoRepository : Repository<GEParentesco>, IGEParentescoRepository
    {
        public GEParentescoRepository(OneContext context) : base(context)
        {
        }

        public IEnumerable<GEParentesco> ObterTodosParentesco()
        {
            return Db.GEParentesco
                .Where(p => "A".Equals(p.flAtivo))
                .AsNoTracking();
        }
    }
}
