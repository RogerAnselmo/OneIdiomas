using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACResponsavelSpecification
{
    public class ACResponsavelDeveSerMaiorDeIdade : ISpecification<ACResponsavel>
    {
        public bool IsSatisfiedBy(ACResponsavel entity)
            => entity.Idade() >= 18;
    }
}