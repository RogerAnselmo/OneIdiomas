using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;

namespace One.Infra.Data.Repository
{
    public class ACAlunoRepository : Repository<ACAluno>, IACAlunoRepository
    {
        public ACAlunoRepository(OneContext context) : base(context)
        {
        }

        public IEnumerable<ACAluno> ObterPorNome(string nome)
        {
            return Db.ACAluno
                .Where(a => a.NomeCompleto.ToUpper().Contains(nome.ToUpper()))
                .AsNoTracking();
        }
    }
}
