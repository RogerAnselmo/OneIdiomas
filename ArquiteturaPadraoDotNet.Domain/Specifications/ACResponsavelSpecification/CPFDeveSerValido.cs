using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACResponsavelSpecification
{
    public class CPFDeveSerValido : ISpecification<ACResponsavel>
    {
        public bool IsSatisfiedBy(ACResponsavel entity) 
            => !string.IsNullOrEmpty(entity.CPF) && entity.CPF.Length <= 11;
    }
}
