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
    public class ACProfessorRepository : Repository<ACProfessor>, IACProfessorRepository
    {
        public ACProfessorRepository(OneContext context) : base(context)
        {
        }

        public IEnumerable<ACProfessor> ObterProfessorPorNome(string nome)
        {
            return Db.ACProfessor
                .Where(p => p.SEGUsuario.NomeCompleto.Contains(nome))
                .Include(p => p.SEGUsuario)
                .AsNoTracking();
        }
    }
}
