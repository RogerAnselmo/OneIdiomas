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

        public IQueryable<ACTurma> ObterPorDescicaoNivelCategoria(string filtro)
            => Db.ACTurma.Where(t => t.flAtivo.Equals("A") &&
                                (t.Descricao.Contains(filtro)
                                || t.ACNivel.Descricao.Contains(filtro)
                                || t.ACProfessor.SEGUsuario.NomeCompleto.Contains(filtro)
                                || t.ACNivel.ACCategoria.DescicaoCategoria.Contains(filtro)))
                .Include(t => t.ACNivel)
                .Include(t => t.ACNivel.ACCategoria)
                .Include(t => t.ACProfessor)
                .Include(t => t.ACProfessor.SEGUsuario)
                .AsNoTracking();
    }
}
