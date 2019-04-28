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
                .Include(a => a.SEGUsuario)
                .Where(a => a.SEGUsuario.NomeCompleto.ToUpper().Contains(nome.ToUpper()) && a.flAtivo.Equals("A"))
                .OrderBy(a => a.SEGUsuario.NomeCompleto)
                .AsNoTracking();
        }

        public ACAluno ObterAlunoParaEdicao(int id)
        {
            return Db.ACAluno
                .Include(a => a.SEGUsuario)
                .Include(a => a.SEGUsuario.GEUsuarioEndereco)
                .Where(a => a.CodigoAluno == id)
                .AsNoTracking()
                .FirstOrDefault();
        }
    }
}
