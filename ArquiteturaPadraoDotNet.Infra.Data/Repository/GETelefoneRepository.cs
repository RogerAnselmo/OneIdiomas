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
    public class GETelefoneRepository : Repository<GETelefone>, IGETelefoneRepository
    {
        public GETelefoneRepository(OneContext context) : base(context)
        {
        }

        public IEnumerable<GETelefone> ObterTelefonesPorUsuario(int CodigoUsuario)
        {
            return Db.GETelefone
                .Where(t => t.CodigoUsuario == CodigoUsuario)
                .Include(t=>t.GETipoTelefone)
                .AsNoTracking();

        }

        public void SalvarTelefone(GETelefone GETelefone)
        {
            Db.GETelefone.Add(GETelefone);
            Db.SaveChanges();
        }
    }
}
