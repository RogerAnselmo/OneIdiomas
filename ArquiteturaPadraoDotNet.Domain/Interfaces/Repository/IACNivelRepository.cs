using One.Domain.Entities;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Repository
{
    public interface IACNivelRepository: IRepository<ACNivel>
    {
        IEnumerable<ACNivel> ObterTodosAtivos();
    }
}
