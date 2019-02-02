using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;

namespace One.Infra.Data.Repository
{
    public class ACResponsavelRepository : Repository<ACResponsavel>, IACResponsavelRepository
    {
        public ACResponsavelRepository(OneContext context) : base(context)
        {
        }
    }
}
