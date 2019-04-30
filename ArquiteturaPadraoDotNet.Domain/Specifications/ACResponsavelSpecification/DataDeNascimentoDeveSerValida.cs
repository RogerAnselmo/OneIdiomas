using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACResponsavelSpecification
{
    public class DataDeNascimentoDeveSerValida : ISpecification<ACResponsavel>
    {
        public bool IsSatisfiedBy(ACResponsavel entity) 
            => entity.DataNascimento > new DateTime(1900, 1, 1).Date
                   && entity.DataNascimento <= DateTime.Now.Date;
    }
}
