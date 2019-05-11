using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;

namespace One.Infra.Data.Repository
{
    public class ACTurmaRepository : Repository<ACTurma>, IACTurmaRepository
    {
        public ACTurmaRepository(OneContext context) : base(context)
        {
        }
    }
}
