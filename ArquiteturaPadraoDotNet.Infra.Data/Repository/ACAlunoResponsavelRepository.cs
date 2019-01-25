using One.Domain.Entities;
using One.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Infra.Data.Repository
{
    public class ACAlunoResponsavelRepository : Repository<ACAlunoResponsavel>
    {
        public ACAlunoResponsavelRepository(OneContext context) : base(context)
        {
        }
    }
}
