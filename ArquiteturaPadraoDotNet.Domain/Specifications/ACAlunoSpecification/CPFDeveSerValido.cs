using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACAlunoSpecification
{
    public class CPFDeveSerValido : ISpecification<ACAluno>
    {
        public bool IsSatisfiedBy(ACAluno entity) 
            => string.IsNullOrEmpty(entity.CPF) && entity.CPF.Length <= 11;
    }
}
