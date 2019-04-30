using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACResponsavelSpecification
{
    public class StatusDeveSerValido : ISpecification<ACResponsavel>
    {
        public bool IsSatisfiedBy(ACResponsavel entity) 
            => !string.IsNullOrEmpty(entity.flAtivo)
               && entity.flAtivo.Length == 1
               && (entity.flAtivo.Equals("A") || entity.flAtivo.Equals("I"));
    }
}
