using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;

namespace One.Infra.Data.Repository
{
    public class GEEndercoRepository : Repository<GEEndereco>, IGEEnderecoRepository
    {
        public GEEndercoRepository(OneContext context) : base(context)
        {
        }
    }
}
