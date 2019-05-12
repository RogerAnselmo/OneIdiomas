using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace One.Domain.Interfaces.Repository
{
    public interface IACTurmaRepository : IRepository<ACTurma>
    {
        IQueryable<ACTurma> ObterPorDescicaoNivelCategoria(string filtro);
    }
}
