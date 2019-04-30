using One.Domain.Entities;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Repository
{
    public interface IACResponsavelRepository: IRepository<ACResponsavel>
    {
        IEnumerable<ACResponsavel> ObterPorNome(string nome);
    }
}
