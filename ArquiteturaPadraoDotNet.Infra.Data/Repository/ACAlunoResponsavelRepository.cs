using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;

namespace One.Infra.Data.Repository
{
    public class ACAlunoResponsavelRepository : Repository<ACAlunoResponsavel>,IACAlunoResponsavelRepository
    {
        public ACAlunoResponsavelRepository(OneContext context) : base(context)
        {
        }
    }
}
