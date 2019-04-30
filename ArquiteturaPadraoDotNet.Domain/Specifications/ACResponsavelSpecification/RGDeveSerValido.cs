using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACResponsavelSpecification
{
    public class RGDeveSerValido : ISpecification<ACResponsavel>
    {
        public bool IsSatisfiedBy(ACResponsavel entity) 
            => !string.IsNullOrEmpty(entity.RG) && entity.RG.Length <= 20;
    }
}
