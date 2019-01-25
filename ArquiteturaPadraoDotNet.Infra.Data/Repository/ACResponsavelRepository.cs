using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Infra.Data.Repository
{
    public class ACResponsavelRepository : Repository<ACResponsavel>, IACResponsavelRepository
    {
        public ACResponsavelRepository(OneContext context) : base(context)
        {
        }
    }
}
