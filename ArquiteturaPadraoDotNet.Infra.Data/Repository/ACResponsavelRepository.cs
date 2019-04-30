using Microsoft.EntityFrameworkCore;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace One.Infra.Data.Repository
{
    public class ACResponsavelRepository : Repository<ACResponsavel>, IACResponsavelRepository
    {
        public ACResponsavelRepository(OneContext context) : base(context)
        {
        }

        public IEnumerable<ACResponsavel> ObterPorNome(string nome) 
            => Db.ACResponsavel.Where(r => r.flAtivo.Equals("A") && r.SEGUsuario.NomeCompleto.Contains(nome))
            .Include(r => r.SEGUsuario)
            .AsNoTracking();
    }
}
