using System.Collections.Generic;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;
using System.Linq;

namespace One.Infra.Data.Repository
{
    public class GEBairroRepository : Repository<GEBairro>, IGEBairroRepository
    {
        public GEBairroRepository(OneContext context) : base(context)
        {
        }

        public IEnumerable<GEBairro> ObterBairroPorCidade(int CodigoCidade)
        {
            return Db.GEBairro.Where(b => b.CodigoCidade == CodigoCidade);
        }
    }
}
