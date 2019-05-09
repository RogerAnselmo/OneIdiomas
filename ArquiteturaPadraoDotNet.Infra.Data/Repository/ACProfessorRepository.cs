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
        public ACProfessorRepository(OneContext context) : base(context) { }

        public IEnumerable<ACProfessor> ObterProfessorPorNome(string nome)
            => Db.ACProfessor
                .Where(p => p.SEGUsuario.NomeCompleto.Contains(nome) && p.flAtivo.Equals("A"))
                .Include(p => p.SEGUsuario)
                .AsNoTracking();

        public override ACProfessor ObterPorId(int id)
            => Db.ACProfessor
                .Where(p => p.CodigoProfessor == id)
                .Include(p => p.SEGUsuario)
                .AsNoTracking()
                .FirstOrDefault();
    }
}
